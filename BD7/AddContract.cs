using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD7
{
    public partial class AddContract : Form
    {
        // Храним ИД внешних записей
        private List<int> flatIDs = new List<int>(),
                          emplIDs = new List<int>(),
                          clientIDs = new List<int>();

        public AddContract()
        {
            InitializeComponent();


        }

        // Заполнение формы при старте
        private void FillForm()
        {
            DateMTextBox.Text = "01.01.2000";
            SubMTextBox.Text = "000000000.00";
            updateComboBoxies();
        }

        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void updateComboBoxies()
        {
            // Очищаем все комбоБоксы
            FlatComboBox.Items.Clear();
            EmplComboBox.Items.Clear();
            ClientComboBox.Items.Clear();

            // И список ключей
            flatIDs.Clear();
            emplIDs.Clear();
            clientIDs.Clear();

            // Заполняем данными все комбоБоксы
            // Квартиры
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"Apartment\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Address\""] = "Address"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    flatIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    FlatComboBox.Items.Add(row["Address"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();

            // Сотрудники
            try
            {
                currentTable = "\"Employee\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Surname\""] = "Surname",
                                                            ["\"Name\""] = "Name",
                                                            ["\"Otch\""] = "Otch",
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    emplIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    EmplComboBox.Items.Add(
                          row["Surname"].ToString() + " "
                        + row["Name"].ToString() + " "
                        + row["Otch"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();

            // Клиенты
            try
            {
                currentTable = "\"Client\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Surname\""] = "Surname",
                                                            ["\"Name\""] = "Name",
                                                            ["\"Otch\""] = "Otch",
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    clientIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    ClientComboBox.Items.Add(
                          row["Surname"].ToString() + " "
                        + row["Name"].ToString() + " "
                        + row["Otch"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
        }

        private void AddFlatButton_Click(object sender, EventArgs e)
        {
            new AddApartment().ShowDialog(this);
            updateComboBoxies();
        }

        private void AddEmplButton_Click(object sender, EventArgs e)
        {
            new AddEmployee().ShowDialog(this);
            updateComboBoxies();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            new AddClient().ShowDialog(this);
            updateComboBoxies();
        }

        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }

        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }

        private string ConvertFromRoubleToDoubleDB(string text)
        {
            text = text.Substring(1);
            text = text.Replace(',', '.');
            return text;
        }

        // Убирает все пустые значения, выполняет преобразования к строке или к дате
        private Dictionary<string, string> PrepareData(Dictionary<string, string> vals)
        {
            IList<string> keysToRemove = new List<string>();
            foreach (var pair in vals)
            {
                if (vals[pair.Key] == "")
                    keysToRemove.Add(pair.Key);
            }
            foreach (var key in keysToRemove)
            {
                vals.Remove(key);
            }

            if (vals["\"Date\""] == "  .  .")
            {
                vals.Remove("\"Date\"");
            }

            var newDict = new Dictionary<string, string>();

            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));

                }
                else if (key.ToLower().Contains("subscription_fee"))
                {
                    newDict.Add(key, ConvertFromRoubleToDoubleDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
            }

            return newDict;
        }

        private void SubMTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.AddButton.Text = "Сохранить";

                DateMTextBox.Text = Config.valueFromTableForEdit["Дата"];
                SubMTextBox.Text = Config.valueFromTableForEdit["Цена договора"];

                updateComboBoxies();

                FlatComboBox.SelectedIndex = FlatComboBox.FindStringExact(Config.valueFromTableForEdit["Квартира"]);
                EmplComboBox.SelectedIndex = EmplComboBox.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                ClientComboBox.SelectedIndex = ClientComboBox.FindStringExact(Config.valueFromTableForEdit["Клиент"]);
            }
            else
                FillForm();
        }

        // Добавление договора
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Заглушка на проверку правильности ввода
            if ((FlatComboBox.SelectedIndex == -1) ||
                (EmplComboBox.SelectedIndex == -1) ||
                (ClientComboBox.SelectedIndex == -1))
                return;

            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Date\""] = DateMTextBox.Text,
                ["\"Subscription_fee\""] = SubMTextBox.Text,
                ["\"Apartment_ID\""] = Convert.ToString(flatIDs[FlatComboBox.SelectedIndex]),
                ["\"ID_employee_client\""] = Convert.ToString(emplIDs[EmplComboBox.SelectedIndex]),
                ["\"ID_client\""] = Convert.ToString(clientIDs[ClientComboBox.SelectedIndex])
            };

            vals = PrepareData(vals);

            try
            {
                if (Text == "Редактирование")
                {
                    Authorization.ODBC.Update("\"Contract\"", Config.valueFromTableForEdit["ID"], vals);

                    MessageBox.Show("Договор успешно обновлен.");
                    this.Close();
                    return;
                }
                else
                {

                    Authorization.ODBC.Insert("\"Contract\"",
                        vals
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            MessageBox.Show("Договор добавлен.");

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
