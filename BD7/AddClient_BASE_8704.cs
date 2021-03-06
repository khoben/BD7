﻿using System;
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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();

            ClearForm();
        }

        private void ClearForm()
        {
            surnameTextBox.Text = "";
            nameTextBox.Text = "";
            otchTextBox.Text = "";
            INNMTextBox.Text = "000000000000";
            birthTextBox.Text = "01.01.2000";
            addressTextBox.Text = "";
            IDMTextBox.Text = "000000";
            SMTextBox.Text = "0000";
        }

        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }

        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }

        // убирает все пустые значения, выполняет преобразования к строке или к дате
        private Dictionary<string, string> PrepareData(Dictionary<string, string> vals)
        {
            IList<string> keysToRemove = new List<string>();
            foreach (var pair in vals)
            {
                if (vals[pair.Key] == "")
                    keysToRemove.Add(pair.Key);
            }
            foreach (var key in keysToRemove)
            {
                vals.Remove(key);
            }

            if (vals["\"Date_of_Birth\""] == "  .  .")
            {
                vals.Remove("\"Date_of_Birth\"");
            }

            var newDict = new Dictionary<string, string>();

            foreach (var key in vals.Keys)
            {
                if (!key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));
                }
            }
            return newDict;
        }

        private void AddInfo(object sender, EventArgs e)
        {
            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Surname\""] = surnameTextBox.Text,
                ["\"Name\""] = nameTextBox.Text,
                ["\"Otch\""] = otchTextBox.Text,
                ["\"Passport_series\""] = SMTextBox.Text,
                ["\"Passport_ID\""] = IDMTextBox.Text,
                ["\"Date_of_Birth\""] = birthTextBox.Text,
                ["\"Home_address\""] = addressTextBox.Text,
                ["\"INN\""] = INNMTextBox.Text
            };

            vals = PrepareData(vals);

            try
            {
                Authorization.ODBC.Insert("\"Client\"",
                    vals
                );
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            MessageBox.Show("Клиент добавлен.");

            this.Close();
        }

        private void CancelAdding(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
