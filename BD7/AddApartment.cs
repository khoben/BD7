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
    public partial class AddApartment : Form
    {
        public AddApartment()
        {
            InitializeComponent();
        }

        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }

        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }

        private string ConvertFromRoubleToDoubleDB(string text)
        {
            text = text.Substring(1);
            text = text.Replace(',', '.');
            return text;
        }

        // Убирает все пустые значения, выполняет преобразования к строке
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

            var newDict = new Dictionary<string, string>();

            foreach (var key in vals.Keys)
                newDict.Add(key, ConvertToStringDB(vals[key]));

            return newDict;
        }

        // Добавление квартиры
        private void AddButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> vals = new Dictionary<string, string>()
            {
                ["\"Address\""] = AddressTextBox.Text
            };

            vals = PrepareData(vals);

            try
            {
                Authorization.ODBC.Insert("\"Apartment\"",
                    vals
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            MessageBox.Show("Квартира добавлена.");

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
