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
    public partial class AddStolen_stuffs : Form
    {
        private List<int> signalIDS;
        public AddStolen_stuffs()
        {
            InitializeComponent();
            PrepareCheckboxes();
        }

        public AddStolen_stuffs(MainForm form)
        {
            InitializeComponent();
            PrepareCheckboxes();
        }

        public void PrepareCheckboxes()
        {
            signalIDS = new List<int>();
            signalComboBox.Items.Clear();

            string currentTable;
            DataTable dataTable = new DataTable();

            try
            {
                currentTable = "\"Call\"";
                var adapter = Authorization.ODBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"ID\""] = "ID",
                                                            ["\"Contract_ID\""] = "Contract_ID",
                                                            ["TO_CHAR(\"Date\", 'DD.MM.YYYY')"] = "Date",
                                                            ["\"Call_time\""] = "Call_time"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string client_id = Authorization.ODBC.getNameByFK("\"ID_client\"", "\"Contract\"", row["Contract_ID"].ToString());
                    string fio = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Client\"", client_id);

                    signalIDS.Add(Convert.ToInt32(row["ID"].ToString()));
                    signalComboBox.Items.Add(fio + " " + row["Date"].ToString() + " " + row["Call_time"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            signalComboBox.SelectedIndex = 0;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
            {
                newDict.Add(key, ConvertToStringDB(vals[key]));   
            }

            return newDict;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text == ""
                || priceTextBox.Text == ""
                )
            {
                MessageBox.Show("Не заполнено одно из полей");
                return;
            }

            var vals = PrepareData(new Dictionary<string, string>()
            {
                ["\"Name\""] = nameTextBox.Text,
                ["\"Price\""] =  priceTextBox.Text,
                ["\"Amount\""] = amountNumeric.Value.ToString(),
                ["\"Call_ID\""] = signalIDS[signalComboBox.SelectedIndex].ToString()
            });

            if (Text != "Редактирование")
            {
                try
                {
                    Authorization.ODBC.Insert("\"Stolen_stuffs\"", vals);
                    MessageBox.Show("Запись успешно добавлена");
                    Close();
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
                    Authorization.ODBC.Update("\"Stolen_stuffs\"", Config.CurrentIndex.ToString(), vals);
                    MessageBox.Show("Запись успешно обновлена");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        private void AddStolen_stuffs_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                addButton.Text = "Сохранить";
                string res = Authorization.ODBC.getNameByFK(
                    " \"Name\" || '_' || \"Price\" || '_ ' " +
                    "|| \"Amount\" || '_' || \"Call_ID\"",
                    "\"Stolen_stuffs\"", Config.CurrentIndex.ToString());
                string[] columns = res.Split('_');

                nameTextBox.Text = columns[0];          // наименование
                priceTextBox.Text = columns[1];         //цена
                amountNumeric.Value = int.Parse(columns[2]);    // количество
                signalComboBox.SelectedIndex = signalIDS.IndexOf(int.Parse(columns[3]));
            }
        }
    }
}
