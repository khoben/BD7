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
    public partial class MainForm : Form
    {
        private AccessRoles _currentRole;           // уровень доступа
        private Authorization _link;

        public MainForm(AccessRoles role, Authorization link)
        {
            InitializeComponent();
            _currentRole = role;
            _link = link;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _link.Close();
        }


        // список клиентов
        private void ClientsList(object sender, EventArgs e)
        {
            // select из таблицы Client
            Authorization.ODBC.Select("\"Client\"", tableView: dataGridView, 
                values: new Dictionary<string, string>()
                {
                    ["\"Name\""] = "\"Имя\"",
                    ["\"Surname\""] = "\"Фамилия\"",
                    ["\"Otch\""] = "\"Отчество\"",
                    ["\"Passport_series\""] = "\"Серия паспорта\"",
                    ["\"Passport_ID\""] = "\"Номер\"",
                    ["\"Date_of_Birth\""] = "\"Дата рождения\"",
                    ["\"Home_address\""] = "\"Домашний адрес\"",
                    ["\"INN\""] = "\"ИНН\""
                }
            );
        }
    }
}
