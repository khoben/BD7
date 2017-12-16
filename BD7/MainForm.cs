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
using System.Reflection;

namespace BD7
{
    public partial class MainForm : Form
    {
        // этот кусок кода нужен, чтобы убрать закрывающий крестик на форме

        //const int MF_BYPOSITION = 0x400;
        //[DllImport("User32")]
        //private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        //[DllImport("User32")]
        //private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        //[DllImport("User32")]
        //private static extern int GetMenuItemCount(IntPtr hWnd);

        private static bool itWasChangeUser = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            //IntPtr hMenu = GetSystemMenu(Handle, false);
            //int menuItemCount = GetMenuItemCount(hMenu);
            //RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            this.LabelUsername.Text = "Пользователь: " + Authorization.login;

            this.queryInfoLabel.Text = "Клиенты";
            ClientsList();
        }
        // ------------------------------------

        private AccessRoles _currentRole;           // уровень доступа
        private Authorization _link;
        private string _current_table = "";
        //private delegate void CurrentFunction(object sender, EventArgs e);
        //private CurrentFunction _currFunc = null;

        private bool itWasReplaceFKtoName = false;


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

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (!itWasChangeUser)
                _link.Close();
        }

        // смена пользователя
        private void OnChangeUser(object sender, EventArgs e)
        {
            itWasChangeUser = true;
            _link.Reset();
            Close();
            itWasChangeUser = false;
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
        public void ClientsList()
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
            if (index == -1 || _current_table == "") //_currFunc == null 
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridView["ID", index].Value.ToString();

                Authorization.ODBC.Delete(_current_table, new Tuple<string, string>("\"ID\"", id));
                //_currFunc(null, null);
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
                if (_current_table == "\"Client\"") //TODO: Добавить русские названия
                    names.Add(Config.clientEnglishColumns[column.Name]);
                else
                    names.Add(column.Name);
            }

            return names;
        }

        //Обновление записи в таблице через DataGridView

        private void UpdateEntry()
        {
            bool no_access;
            switch (_current_table)
            {
                case "\"Client\"":   //TODO: Разделить права
                case "\"Contract\"":
                case "\"Employee\"":
                case "\"Payment\"":
                case "\"Fine\"":
                case "\"Call\"":
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

            if (index == -1 || _current_table == "")
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
                // _currFunc(null, null);
                MessageBox.Show("Запись успешно обновлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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

        public void ContractsList()
        {
            try
            {
                string currentTable = "\"Contract\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Date\""] = "\"Дата\"",
                    ["\"ID_client\""] = "\"Клиент\"",
                    ["\"Apartment_ID\""] = "\"Квартира\"",
                    ["\"Subscription_fee\""] = "\"Цена договора\"",
                    ["\"ID_employee_client\""] = "\"Сотрудник\""
                }
                );

                itWasReplaceFKtoName = true;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells["Клиент"].Value = Authorization.ODBC.getNameByFK("\"Surname\"", "\"Client\"", row.Cells["Клиент"].Value.ToString());
                    row.Cells["Квартира"].Value = Authorization.ODBC.getNameByFK("\"Address\"", "\"Apartment\"", row.Cells["Квартира"].Value.ToString());
                    row.Cells["Сотрудник"].Value = Authorization.ODBC.getNameByFK("\"Surname\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());

                }

                itWasReplaceFKtoName = false;

                _current_table = currentTable;
            }
            catch (Exception ex)
            {
                itWasReplaceFKtoName = false;
                MessageBox.Show(ex.Message.ToString());
            }


        }

        public void EmployeesList()
        {
            try
            {
                string currentTable = "\"Employee\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Surname\""] = "\"Фамилия\"",
                    ["\"Name\""] = "\"Имя\"",
                    ["\"Otch\""] = "\"Отчество\"",
                    ["\"ID_position\""] = "\"Должность\""
                }
                );


                _current_table = currentTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void PaymentsList()
        {
            try
            {
                string currentTable = "\"Payment\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Payment_date\""] = "\"Дата\"",
                    ["\"Payment_sum\""] = "\"Сумма\"",
                    ["\"ID_invoice_type\""] = "\"Тип платежа\"",
                    ["\"Contract_ID\""] = "\"Договор\"",
                    ["\"ID_accountant\""] = "\"Сотрудник\""
                }
                );

                _current_table = currentTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void FinesList()
        {
            try
            {
                string currentTable = "\"Fine\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Date\""] = "\"Дата\"",
                    ["\"Sum\""] = "\"Сумма\"",
                    ["\"Contract_ID\""] = "\"Договор\"",
                    ["\"ID_type_fine\""] = "\"Тип\"",
                    ["\"ID_accountant\""] = "\"Сотрудник\""
                }
                );

                _current_table = currentTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void CallsList()
        {
            try
            {
                string currentTable = "\"Call\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Date\""] = "\"Дата\"",
                    ["\"Call_time\""] = "\"Время\"",
                    ["\"Arrival_time\""] = "\"Время прибытия экипажа\"",
                    ["\"Is_false_call\""] = "\"Ложный вызов\"",
                    ["\"Is_hacked\""] = "\"Был взлом\"",
                    ["\"Contract_ID\""] = "\"Договор\"",
                    ["\"ID_bossfight_thiscall\""] = "\"Начальник наряда\"",
                    ["\"ID_dispatcher_thiscall\""] = "\"Диспетчер\""
                }
                );

                _current_table = currentTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        //вызывает метод вида <tableName>List
        private void ChangeCurrentContext(object sender, EventArgs e)
        {
            this.queryInfoLabel.Text = sender.ToString();

            Type t = this.GetType();
            MethodInfo method = t.GetMethod(Config.methodTranslate[sender.ToString()] + "List");
            method.Invoke(this, null);
        }


        //вызывает форму вида Add<formName>
        private void callFormFromCurrentContext(object sender, EventArgs e)
        {
            string nameForm = "Add" + _current_table.Substring(1, _current_table.Length - 2);

            try
            {
                var form = Activator.CreateInstance(Type.GetType("BD7." + nameForm)) as Form;
                form.Show();
            }
            catch (ArgumentNullException arg)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }

        private void ToogleRawEditSwitch(object sender, EventArgs e)
        {
            this.dataGridView.ReadOnly = !this.dataGridView.ReadOnly;
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!itWasReplaceFKtoName)
                UpdateEntry();
        }
    }
}
