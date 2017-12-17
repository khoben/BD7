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
    public partial class AddEmployee : Form
    {
        // Храним ИД внешних записей
        private List<int> posIDs = new List<int>();
        private MainForm mainForm;

        public AddEmployee()
        {
            InitializeComponent();
            FillForm();
        }

        public AddEmployee(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
        }

        // Заполнение формы при старте
        private void FillForm()
        {
            updateComboBoxies();
        }

        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void updateComboBoxies()
        {
            // Очищаем все комбоБоксы
            PosComboBox.Items.Clear();

            // И список ключей
            posIDs.Clear();

            // Заполняем данными все комбоБоксы
            // Должности
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"Position\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Name\""] = "Name"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    posIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    PosComboBox.Items.Add(row["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
        }

        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
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

            var newDict = new Dictionary<string, string>();

            foreach (var key in vals.Keys)
                newDict.Add(key, ConvertToStringDB(vals[key]));

            return newDict;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Заглушка на проверку правильности ввода
            if ((PosComboBox.SelectedIndex == -1))
                return;

            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Surname\""] = surnameTextBox.Text,
                ["\"Name\""] = nameTextBox.Text,
                ["\"Otch\""] = otchTextBox.Text,
                ["\"ID_position\""] = Convert.ToString(posIDs[PosComboBox.SelectedIndex])
            };

            vals = PrepareData(vals);

            try
            {
                Authorization.ODBC.Insert("\"Employee\"",
                    vals
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            MessageBox.Show("Сотрудник добавлен.");
            if (mainForm != null)
            {
                mainForm.EmployeesList();
            }
            this.Close();
        }

        private void сancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
