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

namespace BD7
{
    public partial class Reports : Form
    {
        private List<int> contractIDs;

        public Reports()
        {
            InitializeComponent();
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
            /*select distinct "inv_type"."Name" as "Тип платежа",
"c"."Surname" || ' ' || "c"."Name" || ' ' || "c"."Otch" as "ФИО клиента",
"table"."Invoice_sdate" as "Дата выставления счета",
"con"."Subscription_fee" as "Сумма к оплате"
from unpaid_invoices(30) "table", "InvoiceType" "inv_type", "Client" "c", "Employee" "e", "Contract" "con"
where "table"."ID_invoice_type" = "inv_type"."ID" and "table"."Contract_ID" = "con"."ID" and "con"."ID_client" = "c"."ID"*/

            NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.ODBC._connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
