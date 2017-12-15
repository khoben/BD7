namespace BD7
{
    partial class AddContract
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
            this.AddButton = new System.Windows.Forms.Button();
            this.сancelButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SubcriptionLabel = new System.Windows.Forms.Label();
            this.FlatLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.SubTextBox = new System.Windows.Forms.TextBox();
            this.FlatTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(176, 247);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 33);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // сancelButton
            // 
            this.сancelButton.Location = new System.Drawing.Point(296, 245);
            this.сancelButton.Name = "сancelButton";
            this.сancelButton.Size = new System.Drawing.Size(80, 35);
            this.сancelButton.TabIndex = 1;
            this.сancelButton.Text = "Отмена";
            this.сancelButton.UseVisualStyleBackColor = true;
            this.сancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(29, 35);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(97, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Дата заключения";
            // 
            // SubcriptionLabel
            // 
            this.SubcriptionLabel.AutoSize = true;
            this.SubcriptionLabel.Location = new System.Drawing.Point(12, 62);
            this.SubcriptionLabel.Name = "SubcriptionLabel";
            this.SubcriptionLabel.Size = new System.Drawing.Size(115, 13);
            this.SubcriptionLabel.TabIndex = 3;
            this.SubcriptionLabel.Text = "Ежемесячная оплата";
            // 
            // FlatLabel
            // 
            this.FlatLabel.AutoSize = true;
            this.FlatLabel.Location = new System.Drawing.Point(76, 95);
            this.FlatLabel.Name = "FlatLabel";
            this.FlatLabel.Size = new System.Drawing.Size(55, 13);
            this.FlatLabel.TabIndex = 4;
            this.FlatLabel.Text = "Квартира";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(29, 130);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(60, 13);
            this.EmployeeLabel.TabIndex = 5;
            this.EmployeeLabel.Text = "Сотрудник";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Location = new System.Drawing.Point(132, 170);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(168, 20);
            this.ClientTextBox.TabIndex = 6;
            // 
            // SubTextBox
            // 
            this.SubTextBox.Location = new System.Drawing.Point(132, 59);
            this.SubTextBox.Name = "SubTextBox";
            this.SubTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTextBox.TabIndex = 7;
            // 
            // FlatTextBox
            // 
            this.FlatTextBox.Location = new System.Drawing.Point(132, 92);
            this.FlatTextBox.Name = "FlatTextBox";
            this.FlatTextBox.Size = new System.Drawing.Size(211, 20);
            this.FlatTextBox.TabIndex = 8;
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(132, 130);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(168, 20);
            this.EmployeeTextBox.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 32);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(46, 177);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(43, 13);
            this.ClientLabel.TabIndex = 11;
            this.ClientLabel.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Сотруднику, клиенту и квартире нужно по идее combobox для выбора";
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.FlatTextBox);
            this.Controls.Add(this.SubTextBox);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.FlatLabel);
            this.Controls.Add(this.SubcriptionLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.сancelButton);
            this.Controls.Add(this.AddButton);
            this.Name = "AddContract";
            this.Text = "AddContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button сancelButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label SubcriptionLabel;
        private System.Windows.Forms.Label FlatLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.TextBox SubTextBox;
        private System.Windows.Forms.TextBox FlatTextBox;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label label1;
    }
}