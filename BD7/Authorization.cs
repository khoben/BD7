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
using System.Data.Odbc;

namespace BD7
{
    public partial class Authorization : Form
    {
        // обертка для соединения с базой PGsql
        public static ODBCPostrgreSQL ODBC { private set; get; }

        public Authorization()
        {                    
            try
            {
                ODBC = ODBCPostrgreSQL.CreateODBCPostgreSQL(
                    host: "174.129.195.73", 
                    port: "5432",
                    username: "jgompwtodtycna", 
                    password: "5677ee64b6c00a044d0f7fb4be945d0fd0be95fd4fcbe48d3e7caf77ad060ac7",
                    database: "d2mqvjtl2st7rf"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\nПроверьте подключение к Интернету");
                Environment.Exit(1);
            }
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            AccessRoles role;

            // работник отдела по работе с клиентами
            if (login == "manager" && password == "12345")
            {
                role = AccessRoles.Manager;
            }

            // бухгалтер
            else if (login == "accountant" && password == "12345")
            {
                role = AccessRoles.Accountant;
            }

            // диспетчер
            else if (login == "dispatcher" && password == "12345")
            {
                role = AccessRoles.Dispatcher;
            }

            // начальник наряда
            else if (login == "inspector" && password == "12345")
            {
                role = AccessRoles.Inspector;
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            // вывести на экран форму и передать ей роль управления
            // в соответствии с введенным логином и паролем
            new MainForm(role, this).Show();
            Hide();         // скроем логинку
        }

        public void Reset()
        {
            Show();
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
