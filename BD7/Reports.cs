using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace BD7
{
    public partial class Reports : Form
    {
        private List<int> contractIDs;

        public Reports()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            contractIDs = new List<int>();
            string currentTable;

            DataTable dataTable = new DataTable();
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
        }

        public bool CheckGrid()
        {
            return dataGridView1.Columns.Count >= 1;
        }

        private void unpaidInvoicesButton_Click(object sender, EventArgs e)
        {
            if (contractComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать контракт");
                return;
            }

            string selectString = String.Format(@"select distinct ""inv_type"".""Name"" as ""Тип платежа"", 
                 ""c"".""Surname"" || ' ' || ""c"".""Name"" || ' ' || ""c"".""Otch"" as ""ФИО клиента"",
                ""table"".""Invoice_sdate"" as ""Дата выставления счета"",
                ""con"".""Subscription_fee"" as ""Сумма к оплате""
                from unpaid_invoices({0}) ""table"", ""InvoiceType"" ""inv_type"", ""Client"" ""c"", 
                ""Employee"" ""e"", ""Contract"" ""con""
                where ""table"".""ID_invoice_type"" = ""inv_type"".""ID"" and 
                ""table"".""Contract_ID"" = ""con"".""ID"" and ""con"".""ID_client"" = ""c"".""ID""", contractIDs[contractComboBox.SelectedIndex]);

            NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.ODBC._connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        // экспорт в html
        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckGrid())
            {
                MessageBox.Show("Сначала нужно выполнить запрос");
                return;
            }

            string table = "";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table += String.Format("<th>{0}</th>", dataGridView1.Columns[i].Name);
            }
            table = String.Format("<tr>{0}</tr>", table);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                table += "<tr>";
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table += String.Format("<td>{0}</td>", dataGridView1[j, i].Value.ToString());
                }
                table += "</tr>";
            }
            table = String.Format("<table style=\"border-style: solid\">{0}</table>", table);

            string html = "<html>" +
                "<head>" +
                "<meta charset=\"UTF-8\">" +
                "<style>" +
                "table {" +
                "    border-style: solid;" +
                "    border-collapse: collapse;" +
                "}" +
                "th {" +
                "   padding: 15px;" +
                "   border-style: solid;" +
                "}" +
                "tr {" +
                "    border-style: solid;" +
                "}" +
                "td {" +
                "    border-style: solid;" +
                "    padding: 15px;" +
                "    text-align: center;" +
                "}" +
                "</style>" +
                "</head>" +
                "" +
                "<body>" +
                "^" +
                "</body>" +
                "" +
                "</html>";

            html = html.Split('^')[0] + table + html.Split('^')[1];

            saveFileDialog1.Filter = "Html страницы|*.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(html);
                writer.Close();
                MessageBox.Show("Отчет успешно сохранен");
            }
        }
    }
}
