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
    public partial class AddFine : Form
    {
        // Храним ИД внешних записей
        private List<int> contractIDs = new List<int>(),
                          BIDs = new List<int>(),
                          fineTypeIDs = new List<int>();

        private MainForm mainForm;

        public AddFine()
        {
            InitializeComponent();

            FillForm();
        }

        // Заполнение формы при старте
        private void FillForm()
        {
            DateMTextBox.Text = "01.01.2000";
            SubMTextBox.Text = "000000000";
            updateComboBoxies();
        }

        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void updateComboBoxies()
        {
            // Очищаем все комбоБоксы
            BComboBox.Items.Clear();
            FineTypeComboBox.Items.Clear();
            ContractComboBox.Items.Clear();

            // И список ключей
            contractIDs.Clear();
            BIDs.Clear();
            fineTypeIDs.Clear();

            // Заполняем данными все комбоБоксы
            // Договора
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"Contract\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    contractIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    ContractComboBox.Items.Add(row["ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();

            // Бухгалтер
            dataTable = new DataTable();
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
                                                            ["\"ID_position\""] = "Position"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Position"].ToString() != "41") // если не бухгалтер
                        continue;
                    BIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    BComboBox.Items.Add(
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

            // Тип штрафа
            dataTable = new DataTable();
            try
            {
                currentTable = "\"FineType\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Name\""] = "Name"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    fineTypeIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    FineTypeComboBox.Items.Add(row["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
        }

        public AddFine(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
        }

        private void AddContractButton_Click(object sender, EventArgs e)
        {
            new AddContract().ShowDialog(this);
            updateComboBoxies();
        }

        private void AddEmplButton_Click(object sender, EventArgs e)
        {
            new AddEmployee().ShowDialog(this);
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
            //text = text.Substring(1);
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
                else if (key.ToLower().Contains("sum"))
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Заглушка на проверку правильности ввода
            if ((ContractComboBox.SelectedIndex == -1) ||
                (BComboBox.SelectedIndex == -1) ||
                (FineTypeComboBox.SelectedIndex == -1))
            {
                MessageBox.Show("Не указаны одно или более обязательных полей");
                return;
            }

            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Date\""] = DateMTextBox.Text,
                ["\"Sum\""] = SubMTextBox.Text,
                ["\"Contract_ID\""] = Convert.ToString(contractIDs[ContractComboBox.SelectedIndex]),
                ["\"ID_type_fine\""] = Convert.ToString(fineTypeIDs[FineTypeComboBox.SelectedIndex]),
                ["\"ID_accountant\""] = Convert.ToString(BIDs[BComboBox.SelectedIndex])
            };

            vals = PrepareData(vals);

            try
            {
                Authorization.ODBC.Insert("\"Fine\"",
                        vals
                    );
                MessageBox.Show("Штраф успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }


            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
