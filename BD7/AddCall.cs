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
    public partial class AddCall : Form
    {
        // Храним ИД внешних записей
        private List<int> contrIDs = new List<int>(), 
                          emplBIDs = new List<int>(),
                          emplDIDs = new List<int>();

        private MainForm mainForm;

        public AddCall()
        {
            InitializeComponent();

            FillForm();
        }

        public AddCall(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
        }

        // Заполнение формы при старте
        private void FillForm()
        {
            DateMTextBox.Text = "01.01.2000";
            StartTimeMTextBox.Text = "00:00";
            ArrivalTimeMTextBox.Text = "00:00";
            updateComboBoxies();
        }

        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void updateComboBoxies()
        {
            // Очищаем все комбоБоксы
            BossComboBox.Items.Clear();
            DispComboBox.Items.Clear();
            ContractComboBox.Items.Clear();

            // И список ключей
            emplBIDs.Clear();
            emplDIDs.Clear();
            contrIDs.Clear();

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
                    contrIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    ContractComboBox.Items.Add(row["ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();

            // Начальники наряда
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
                    if (row["Position"].ToString() != "22") // если не начальник наряда
                        continue;
                    emplBIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    BossComboBox.Items.Add(
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

            // Диспетчеры
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
                    if (row["Position"].ToString() != "20") // если не диспетчер
                        continue;
                    emplDIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    DispComboBox.Items.Add(
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

        private void FalseCallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FalseCallCheckBox.Checked)
                IsHackedCheckBox.Enabled = false;
            else
                IsHackedCheckBox.Enabled = true;
        }

        private void IsHackedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsHackedCheckBox.Checked)
                FalseCallCheckBox.Enabled = false;
            else
                FalseCallCheckBox.Enabled = true;
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

        private string ConvertToTimeDB(string text)
        {
            return String.Format("TO_TIMESTAMP('{0}', 'HH24:MI')", text);
        }

        // Убирает все пустые значения, выполняет преобразования к строке, к дате или времени
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

            if (vals["\"Call_time\""] == "  :")
            {
                vals.Remove("\"Call_time\"");
            }

            if (vals["\"Arrival_time\""] == "  :")
            {
                vals.Remove("\"Arrival_time\"");
            }

            var newDict = new Dictionary<string, string>();

            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));

                }
                else if (key.ToLower().Contains("call_time") || key.ToLower().Contains("arrival_time"))
                {
                    newDict.Add(key, ConvertToTimeDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
            }

            return newDict;
        }

        // Проверяет существует ли Ид в промежуточных таблицах Начальника наряда и Диспетчера,
        // если нет, то добавляет его
        private void checkBossAndDispTables()
        {
            // Начальник наряда
            List<int> bossIDs = new List<int>();
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"BossFightThisCall\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID_bossfight\""] = "ID_bossfight"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                    bossIDs.Add(Convert.ToInt32(row["ID_bossfight"].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
            for (int i = 0; i < emplBIDs.Count; i++)
                if (!bossIDs.Contains(emplBIDs[i]))
                {
                    Dictionary<string, string> vals = new Dictionary<string, string>()
                    {
                        ["\"ID_bossfight\""] = ConvertToStringDB(Convert.ToString(emplBIDs[i]))
                    };

                    try
                    {
                        Authorization.ODBC.Insert("\"BossFightThisCall\"",
                                vals
                            );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
            dataTable.Clear();

            // Дипетчер
            List<int> dispIDs = new List<int>();
            dataTable = new DataTable();
            try
            {
                currentTable = "\"DispatcherThisCall\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID_dispatcher\""] = "ID_dispatcher"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                    dispIDs.Add(Convert.ToInt32(row["ID_dispatcher"].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
            for (int i = 0; i < emplDIDs.Count; i++)
                if (!dispIDs.Contains(emplDIDs[i]))
                {
                    Dictionary<string, string> vals = new Dictionary<string, string>()
                    {
                        ["\"ID_dispatcher\""] = ConvertToStringDB(Convert.ToString(emplDIDs[i]))
                    };

                    try
                    {
                        Authorization.ODBC.Insert("\"DispatcherThisCall\"",
                                vals
                            );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
            dataTable.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Заглушка на проверку правильности ввода
            if ((BossComboBox.SelectedIndex == -1) ||
                (DispComboBox.SelectedIndex == -1))
            {
                MessageBox.Show("Не указаны одно или более обязательных полей");
                return;
            }

            checkBossAndDispTables();

            int BossID = -1, DispID = -1;

            // Начальник наряда
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"BossFightThisCall\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"ID_bossfight\""] = "ID_bossfight"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                    if (row["ID_bossfight"].ToString() == Convert.ToString(emplBIDs[BossComboBox.SelectedIndex]))
                        BossID = Convert.ToInt32(row["ID"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();

            // Диспетчер
            dataTable = new DataTable();
            try
            {
                currentTable = "\"DispatcherThisCall\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"ID_dispatcher\""] = "ID_dispatcher"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                    if (row["ID_dispatcher"].ToString() == Convert.ToString(emplDIDs[DispComboBox.SelectedIndex]))
                        DispID = Convert.ToInt32(row["ID"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();

            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Date\""] = DateMTextBox.Text,
                ["\"Call_time\""] = StartTimeMTextBox.Text,
                ["\"Arrival_time\""] = ArrivalTimeMTextBox.Text,
                ["\"Is_false_call\""] = Convert.ToString(FalseCallCheckBox.Checked),
                ["\"Is_hacked\""] = Convert.ToString(IsHackedCheckBox.Checked),
                ["\"Contract_ID\""] = Convert.ToString(contrIDs[ContractComboBox.SelectedIndex]),
                ["\"ID_bossfight_thiscall\""] = Convert.ToString(BossID),
                ["\"ID_dispatcher_thiscall\""] = Convert.ToString(DispID)
            };

            vals = PrepareData(vals);

            try
            {
                Authorization.ODBC.Insert("\"Call\"",
                        vals
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            if (mainForm != null)
            {
                mainForm.ContractsList();
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
