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
    public partial class AddCall : Form
    {
        public AddCall()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FalseCallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FalseCallCheckBox.Checked)
                IsHackedCheckBox.Enabled = false;
            else
                IsHackedCheckBox.Enabled = true;
        }
    }
}
