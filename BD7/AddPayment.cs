﻿using System;
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
    public partial class AddPayment : Form
    {
        private MainForm mainForm;

        // храним ид внешний ключей
        private List<int> typePaymentIDS,
                            contractIDs,
                            accountantIDs;
        public AddPayment()
        {
            InitializeComponent();
            FillForm();
        }

        public AddPayment(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
        }

        public void SetForm()
        {
            if (Text == "Редактирование")
            {
                addButton.Text = "Сохранить";
                string res = Authorization.ODBC.getNameByFK(
                    "TO_CHAR(\"Payment_date\", 'DD.MM.YYYY') || '_' || \"Payment_sum\" || '_ ' " +
                    "|| \"ID_invoice_type\" || '_' || \"Contract_ID\" || '_' || \"ID_accountant\"", 
                    "\"Payment\"", Config.CurrentIndex.ToString());
                string[] columns = res.Split('_');

                dateTextBox.Text = columns[0];          // дата платежа
                sumTextBox.Text = columns[1];           // сумма платежа
                typePaymentComboBox.SelectedIndex = typePaymentIDS.IndexOf(int.Parse(columns[2]));      // тип платежа
                contractComboBox.SelectedIndex = contractIDs.IndexOf(int.Parse(columns[3]));       // договор
                accountantComboBox.SelectedIndex = accountantIDs.IndexOf(int.Parse(columns[4]));    // бухгалтер
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
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

            if (vals["\"Payment_date\""] == "  .  .")
            {
                vals.Remove("\"Payment_date\"");
            }

            var newDict = new Dictionary<string, string>();

            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));

                }
                else
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
            }

            return newDict;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Заглушка на проверку правильности ввода
            if ((typePaymentComboBox.SelectedIndex == -1) ||
                (accountantComboBox.SelectedIndex == -1) ||
                (contractComboBox.SelectedIndex == -1) ||
                sumTextBox.Text == ""
                || dateTextBox.Text == "  .  .")
            {
                MessageBox.Show("Не указаны одно или более полей");
                return;
            }

            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Payment_date\""] = dateTextBox.Text,
                ["\"Payment_sum\""] = sumTextBox.Text,
                ["\"ID_invoice_type\""] = Convert.ToString(typePaymentIDS[typePaymentComboBox.SelectedIndex]),
                ["\"Contract_ID\""] = Convert.ToString(contractIDs[contractComboBox.SelectedIndex]),
                ["\"ID_accountant\""] = Convert.ToString(accountantIDs[accountantComboBox.SelectedIndex])
            };

            vals = PrepareData(vals);

            if (Text != "Редактирование")
            {
                try
                {
                    Authorization.ODBC.Insert("\"Payment\"",
                        vals
                    );
                    MessageBox.Show("Платеж добавлен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
            else
            {
                try
                {
                    Authorization.ODBC.Update("\"Payment\"", Config.CurrentIndex.ToString(), vals);
                    MessageBox.Show("Платеж обновлен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
            
      
            this.Close();
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            SetForm();
            
        }

        public void FillForm()
        {
            typePaymentIDS = new List<int>();
            contractIDs = new List<int>();
            accountantIDs = new List<int>();
            UpdateComboboxes();
        }

        public void UpdateComboboxes()
        {
            // очищаем все комбобоксы
            typePaymentComboBox.Items.Clear();
            accountantComboBox.Items.Clear();
            contractComboBox.Items.Clear();

            // и список ключей
            typePaymentIDS = new List<int>();
            contractIDs = new List<int>();
            accountantIDs = new List<int>();

            // заполняем комбобоксы
            // тип платежа
            string currentTable;

            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"InvoiceType\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Name\""] = "Name"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    typePaymentIDS.Add(Convert.ToInt32(row["ID"].ToString()));
                    typePaymentComboBox.Items.Add(row["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
            typePaymentComboBox.SelectedIndex = 0;

            // контракт
            try
            {
                currentTable = "\"Contract\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"ID_client\""] = "ID_client",
                                                            ["\"Subscription_fee\""] = "Subscription_fee"
                                                        });
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    contractIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    string text = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Client\"", row["ID_client"].ToString());
                    text += " , сумма оплаты - " + row["Subscription_fee"].ToString();
                    contractComboBox.Items.Add(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
            contractComboBox.SelectedIndex = 0;

            // бухгалтер
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
                                                            ["\"ID_position\""] = "ID_position"
                                                        });
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    string text = Authorization.ODBC.getNameByFK("\"Name\"", "\"Position\"", row["ID_position"].ToString());
                    // добавляем только бухгалтеров
                    if (text != "Бухгалтер")
                        continue;
                    accountantIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    accountantComboBox.Items.Add(String.Format("{0} {1} {1}", row["Surname"], row["Name"], row["Otch"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
            accountantComboBox.SelectedIndex = 0;

        }
    }
}
