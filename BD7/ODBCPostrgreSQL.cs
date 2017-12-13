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
            string password, string database, string sslMode="Require", 
            string trustServerCertificate="true")
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
            }

            return adapter;
        }
    }
}
