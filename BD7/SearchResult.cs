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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        // произвести поиск по заданному паттерну и вставить результаты в таблицу
        public void MakeSearch(string searchPattern, DataGridView table)
        {

            //вставим в таблицу те же столбцы, что в той, в которой ищем
            foreach (DataGridViewColumn column in table.Columns)
            {
                dataGridView.Columns.Add(column.Clone() as DataGridViewColumn);
            }

            // теперь произведем поиск
            foreach (DataGridViewRow row in table.Rows)
            {
                bool isGood = false;
                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        string value = cell.Value.ToString();
                        // если хотя бы один столбцец строки соответствует паттерну,
                        // вставим эту строку в результат поиска
                        if (value.ToLower().Contains(searchPattern.ToLower()))
                        {
                            isGood = true;
                            break;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        break;
                    }
                }

                if (isGood)
                {
                    int index = dataGridView.Rows.Add();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dataGridView.Rows[index].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
