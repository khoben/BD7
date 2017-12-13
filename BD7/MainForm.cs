using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BD7
{
    public partial class MainForm : Form
    {
        // этот кусок кода нужен, чтобы убрать закрывающий крестик на форме
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        private void MainForm_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }
        // ------------------------------------

        private AccessRoles _currentRole;           // уровень доступа
        private Authorization _link;

        public MainForm(AccessRoles role, Authorization link)
        {
            InitializeComponent();
            _currentRole = role;
            _link = link;
        }

        /// <summary>
        /// Если condition false, показывает MessageBox с предупреждением
        /// </summary>
        /// <param name="condition">Условие, обозначющее, есть ли доступ у этого юзера</param>
        /// <returns>true, если messagebox был показан</returns>
        private bool NoAccessMessageBox(bool condition)
        {
            if (!condition)
            {
                MessageBox.Show("У вас нет прав для выполнения данной операции");
                return true;
            }
            return false;
        }

        // при закрытии формы, также выходим из приложения
        private void OnClose(object sender, EventArgs e)
        {
            _link.Close();
        }

        // смена пользователя
        private void OnChangeUser(object sender, EventArgs e)
        {
            _link.Reset();
            Close();
        }

        // поиск
        private void Search(object sender, EventArgs e)
        {
            SearchResult search = new SearchResult();
            search.Show();
            search.MakeSearch(searchPatternTextBox.Text, dataGridView);
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
            
            queryInfoLabel.Text = "Список клиентов";
        }

        // добавить клиента
        private void AddClient(object sender, EventArgs e)
        {
            // добавлять клиентов могут только директор и 
            // сотрудник отдела по работе с клиентами
            if (NoAccessMessageBox(
                _currentRole == AccessRoles.Director 
                || _currentRole == AccessRoles.Manager)
            )
                return;

            new AddClient().Show();

        }
        
    }
}
