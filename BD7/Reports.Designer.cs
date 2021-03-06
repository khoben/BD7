﻿namespace BD7
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unpaidInvoicesButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contractComboBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.unpaidFinesButton = new System.Windows.Forms.Button();
            this.commonInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // unpaidInvoicesButton
            // 
            this.unpaidInvoicesButton.Location = new System.Drawing.Point(12, 397);
            this.unpaidInvoicesButton.Name = "unpaidInvoicesButton";
            this.unpaidInvoicesButton.Size = new System.Drawing.Size(396, 32);
            this.unpaidInvoicesButton.TabIndex = 0;
            this.unpaidInvoicesButton.Text = "Список неоплаченных платежей по договору";
            this.unpaidInvoicesButton.UseVisualStyleBackColor = true;
            this.unpaidInvoicesButton.Click += new System.EventHandler(this.unpaidInvoicesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(929, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(396, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Экспорт в HTML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Экспорт в Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contractComboBox
            // 
            this.contractComboBox.FormattingEnabled = true;
            this.contractComboBox.Location = new System.Drawing.Point(435, 444);
            this.contractComboBox.Name = "contractComboBox";
            this.contractComboBox.Size = new System.Drawing.Size(374, 28);
            this.contractComboBox.TabIndex = 4;
            // 
            // unpaidFinesButton
            // 
            this.unpaidFinesButton.Location = new System.Drawing.Point(12, 444);
            this.unpaidFinesButton.Name = "unpaidFinesButton";
            this.unpaidFinesButton.Size = new System.Drawing.Size(396, 32);
            this.unpaidFinesButton.TabIndex = 5;
            this.unpaidFinesButton.Text = "Список неоплаченных штрафов по договору";
            this.unpaidFinesButton.UseVisualStyleBackColor = true;
            this.unpaidFinesButton.Click += new System.EventHandler(this.unpaidFinesButton_Click);
            // 
            // commonInfoButton
            // 
            this.commonInfoButton.Location = new System.Drawing.Point(12, 488);
            this.commonInfoButton.Name = "commonInfoButton";
            this.commonInfoButton.Size = new System.Drawing.Size(396, 32);
            this.commonInfoButton.TabIndex = 6;
            this.commonInfoButton.Text = "Общая денежная информация по договору";
            this.commonInfoButton.UseVisualStyleBackColor = true;
            this.commonInfoButton.Click += new System.EventHandler(this.commonInfoButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 644);
            this.Controls.Add(this.commonInfoButton);
            this.Controls.Add(this.unpaidFinesButton);
            this.Controls.Add(this.contractComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.unpaidInvoicesButton);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unpaidInvoicesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox contractComboBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button unpaidFinesButton;
        private System.Windows.Forms.Button commonInfoButton;
    }
}