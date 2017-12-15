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

        public static string login { private set; get; }
        public static string password { private set; get; }

        public Authorization()
        {
            try
            {
                ODBC = ODBCPostrgreSQL.CreateODBCPostgreSQL(
                    host: Config.host,
                    port: Config.port,
                    username: Config.username,
                    password: Config.password,
                    database: Config.database
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
            login = loginTextBox.Text;
            password = passwordTextBox.Text;
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

            Hide();         // скроем логинку
            new MainForm(role, this).Show();
        }

        public void Reset()
        {
            Show();
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
