using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace BD7
{
    public class ODBCPostrgreSQL
    {

        private static ODBCPostrgreSQL instance = null;
        private NpgsqlConnection _connection;

        public static ODBCPostrgreSQL CreateODBCPostgreSQL(string host, string port, string username,
            string password, string database, string sslMode = "Require",
            string trustServerCertificate = "true")
        {
            if (instance != null)
            {
                return instance;
            }

            string connection = String.Format("Host={0}; Port={1}; Username={2}; " +
                "Password={3}; Database={4}; SSL Mode={5}; Trust Server Certificate={6}",
                host, port, username, password, database, sslMode, trustServerCertificate);

            return new ODBCPostrgreSQL(connection);

        }

        private ODBCPostrgreSQL(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        ~ODBCPostrgreSQL()
        {
            _connection.Close();
        }

        // далее идут методы для работы с бд



        /// <summary>
        /// Возвращает объект NpgsqlDataAdapter.
        /// table - таблица, из которой будем выбирать.
        /// values - словарь, где ключ - это столбцец, а значение - алиас.
        /// Если values = null, то выбираем все.
        /// Если tableView != null, выборка произойдет в нее.
        /// </summary>
        /// 
        public NpgsqlDataAdapter Select(string table, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";

            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }

            selectString += String.Format(" from {0}", table);

            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;

            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                tableView.DataSource = dataTable;

                adapter.Fill(dataTable);
                tableView.Columns["ID"].Visible = false;
            }

            return adapter;
        }


        /// <summary>
        /// Вставляет в таблицу table значения из словаря vals
        /// </summary>
        /// <param name="table">Таблица, куда будем вставлять.</param>
        /// <param name="vals">Ключи словаря - это столбцы, куда вставляем, а значения, что вставляем.</param>
        public void Insert(string table, Dictionary<string, string> vals)
        {
            string where = "";              // что вставляем
            string what = "";               // куда вставляем

            foreach (var pair in vals)
            {
                where += pair.Key + ", ";
                what += pair.Value + ", ";
            }
            where = where.Substring(0, where.Length - 2);
            what = what.Substring(0, what.Length - 2);

            string insertString = String.Format("insert into {0} ({1}) values ({2})", table, where, what);
            NpgsqlCommand command = new NpgsqlCommand(insertString, _connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаляет информацию из таблицы по заданным условиям в кортеже.
        /// </summary>
        /// <param name="table">Таблица из которой удаляем</param>
        /// <param name="condition">Для конструкции вида: where Item1=Item2</param>
        public void Delete(string table, Tuple<string, string> condition)
        {
            string deleteString = "delete from " + table + " ";

            if (condition == null)
                return;

            deleteString += String.Format("where {0}={1}", condition.Item1, condition.Item2);

            NpgsqlCommand command = new NpgsqlCommand(deleteString, _connection);
            command.ExecuteNonQuery();
        }



        /// <summary>
        /// Обновление записи в таблице.
        /// </summary>
        public void Update(string table, string idEntry, List<string> name, List<string> value)
        {
            //"Update <table> set <what>=<value>, ... where ID=<idEntry>;
            string updateString = "update " + table + " set ";

            if (value == null || name == null)
                return;

            for (int i = 0; i < name.Count; i++)
            {
                if (value[i] == "" || name[i] == "ID")
                    continue;
                if (name[i].Split('_')[0] == "Date")
                {

                    DateTime date = DateTime.ParseExact(value[i], "dd.MM.yyyy H:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    value[i] = date.ToString("yyyy-MM-dd HH:mm:ss");

                }
                updateString += "\"" + name[i] + "\" = '" + value[i] + "' ,";
            }

            updateString = updateString.Substring(0, updateString.Length - 2);
            updateString += String.Format(" where \"ID\" = {0}", idEntry);

            NpgsqlCommand command = new NpgsqlCommand(updateString, _connection);
            command.ExecuteNonQuery();

        }
    }
}
