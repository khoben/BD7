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
        public static NpgsqlConnection Connection { private set; get; }
        public const string CONNECTION_STRING = "Host=174.129.195.73;" +
            "Port=5432; Username=jgompwtodtycna; Password=5677ee64b6c00a044d0f7fb4be945d0fd0be95fd4fcbe48d3e7caf77ad060ac7;" +
            "Database=d2mqvjtl2st7rf; SSL Mode=Require;Trust Server Certificate=true";

        public Authorization()
        {           
            
            try
            {
                Connection = new NpgsqlConnection(CONNECTION_STRING);
                Connection.Open();
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

        }
    }
}
