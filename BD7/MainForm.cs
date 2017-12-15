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
using Npgsql;

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
        private string _current_table = "";
        private delegate void CurrentFunction(object sender, EventArgs e);
        private CurrentFunction _currFunc = null;


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

        private int GetSelectedRow()
        {
            int index;
            try
            {
                index = dataGridView.CurrentCell.RowIndex;
            }
            catch (Exception)
            {
                index = -1;
            }
            return index;
        }

        // поиск
        private void Search(object sender, EventArgs e)
        {
            if (searchPatternTextBox.Text.Length == 0)
            {
                MessageBox.Show("Пустой поисковый запрос");
                return;
            }
            SearchResult search = new SearchResult();
            search.Show();
            search.MakeSearch(searchPatternTextBox.Text, dataGridView);
        }

        // список клиентов
        private void ClientsList(object sender, EventArgs e)
        {
            // select из таблицы Client 
            // TODO: Надо бы склеить серию и номер паспорта
            try
            {
                Authorization.ODBC.Select("\"Client\"", tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
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
                _currFunc = ClientsList;
                _current_table = "\"Client\"";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


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

        private void DeleteClient(object sendet, EventArgs e)
        {
            bool no_access;
            switch (_current_table)
            {
                case "\"Client\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Manager
                    );
                    break;
                default:
                    no_access = false;
                    break;
            }
            if (no_access)
                return;

            int index = GetSelectedRow();
            if (index == -1 || _currFunc == null || _current_table == "")
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridView["ID", index].Value.ToString();

                Authorization.ODBC.Delete(_current_table, new Tuple<string, string>("\"ID\"", id));
                _currFunc(null, null);
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void topLevelExit_Click(object sender, EventArgs e)
        {
            _link.Close();
        }

        private List<string> GetRowValues(int id)
        {
            List<string> values = new List<string>();

            foreach (DataGridViewCell cell in dataGridView.Rows[id].Cells)
            {
                values.Add(cell.Value.ToString());
            }

            return values;
        }

        //TODO: Добавить словари для остальных таблиц
        public List<string> GetTableColumnsName(string table)
        {
            List<string> names = new List<string>();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                names.Add(Config.clientEnglishColumns[column.Name]);
            }

            return names;
        }

        //Обновление записи в таблице через DataGridView

        private void UpdateEntry()
        {
            bool no_access;
            switch (_current_table)
            {
                case "\"Client\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Manager
                    );
                    break;
                default:
                    no_access = false;
                    break;
            }
            if (no_access)
                return;

            int index = GetSelectedRow();
            if (index == -1 || _currFunc == null || _current_table == "")
            {
                MessageBox.Show("Необходимо выбрать запись.");
                return;
            }
            try
            {
                string id = dataGridView["ID", index].Value.ToString();

                //TODO: Можно объединить в словарь
                List<string> columnNames = GetTableColumnsName(_current_table);
                List<string> columnValues = GetRowValues(index);

                Authorization.ODBC.Update(_current_table, id, columnNames, columnValues);
                _currFunc(null, null);
                MessageBox.Show("Запись успешно обновлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEntry();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // добавлять клиентов могут только директор и 
            // сотрудник отдела по работе с клиентами
            if (NoAccessMessageBox(
                _currentRole == AccessRoles.Director
                || _currentRole == AccessRoles.Manager)
            )
                return;

            new AddContract().Show();
        }
    }
}
