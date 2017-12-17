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
            this.CancelButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SubcriptionLabel = new System.Windows.Forms.Label();
            this.FlatLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.DateMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.AddFlatButton = new System.Windows.Forms.Button();
            this.AddEmplButton = new System.Windows.Forms.Button();
            this.FlatComboBox = new System.Windows.Forms.ComboBox();
            this.EmplComboBox = new System.Windows.Forms.ComboBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.SubMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(132, 182);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 33);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(221, 182);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 33);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(29, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(97, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Дата заключения";
            // 
            // SubcriptionLabel
            // 
            this.SubcriptionLabel.AutoSize = true;
            this.SubcriptionLabel.Location = new System.Drawing.Point(12, 36);
            this.SubcriptionLabel.Name = "SubcriptionLabel";
            this.SubcriptionLabel.Size = new System.Drawing.Size(115, 13);
            this.SubcriptionLabel.TabIndex = 3;
            this.SubcriptionLabel.Text = "Ежемесячная оплата";
            // 
            // FlatLabel
            // 
            this.FlatLabel.AutoSize = true;
            this.FlatLabel.Location = new System.Drawing.Point(71, 88);
            this.FlatLabel.Name = "FlatLabel";
            this.FlatLabel.Size = new System.Drawing.Size(55, 13);
            this.FlatLabel.TabIndex = 4;
            this.FlatLabel.Text = "Квартира";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(67, 114);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(60, 13);
            this.EmployeeLabel.TabIndex = 5;
            this.EmployeeLabel.Text = "Сотрудник";
            // 
            // DateMTextBox
            // 
            this.DateMTextBox.Location = new System.Drawing.Point(132, 6);
            this.DateMTextBox.Mask = "00/00/0000";
            this.DateMTextBox.Name = "DateMTextBox";
            this.DateMTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateMTextBox.TabIndex = 10;
            this.DateMTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(84, 140);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(43, 13);
            this.ClientLabel.TabIndex = 11;
            this.ClientLabel.Text = "Клиент";
            // 
            // AddFlatButton
            // 
            this.AddFlatButton.Location = new System.Drawing.Point(306, 82);
            this.AddFlatButton.Name = "AddFlatButton";
            this.AddFlatButton.Size = new System.Drawing.Size(156, 23);
            this.AddFlatButton.TabIndex = 12;
            this.AddFlatButton.Text = "Добавить квартиру";
            this.AddFlatButton.UseVisualStyleBackColor = true;
            this.AddFlatButton.Click += new System.EventHandler(this.AddFlatButton_Click);
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(306, 109);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(156, 23);
            this.AddEmplButton.TabIndex = 13;
            this.AddEmplButton.Text = "Добавить сотрудника";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            this.AddEmplButton.Click += new System.EventHandler(this.AddEmplButton_Click);
            // 
            // FlatComboBox
            // 
            this.FlatComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FlatComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FlatComboBox.FormattingEnabled = true;
            this.FlatComboBox.Location = new System.Drawing.Point(132, 83);
            this.FlatComboBox.Name = "FlatComboBox";
            this.FlatComboBox.Size = new System.Drawing.Size(168, 21);
            this.FlatComboBox.TabIndex = 14;
            // 
            // EmplComboBox
            // 
            this.EmplComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EmplComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EmplComboBox.FormattingEnabled = true;
            this.EmplComboBox.Location = new System.Drawing.Point(132, 110);
            this.EmplComboBox.Name = "EmplComboBox";
            this.EmplComboBox.Size = new System.Drawing.Size(168, 21);
            this.EmplComboBox.TabIndex = 15;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(132, 137);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(168, 21);
            this.ClientComboBox.TabIndex = 16;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(306, 136);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(156, 23);
            this.AddClientButton.TabIndex = 17;
            this.AddClientButton.Text = "Добавить клиента";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // SubMTextBox
            // 
            this.SubMTextBox.Location = new System.Drawing.Point(132, 32);
            this.SubMTextBox.Mask = "$999999999.00";
            this.SubMTextBox.Name = "SubMTextBox";
            this.SubMTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubMTextBox.TabIndex = 18;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 234);
            this.Controls.Add(this.SubMTextBox);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.EmplComboBox);
            this.Controls.Add(this.FlatComboBox);
            this.Controls.Add(this.AddEmplButton);
            this.Controls.Add(this.AddFlatButton);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.DateMTextBox);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.FlatLabel);
            this.Controls.Add(this.SubcriptionLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Name = "AddContract";
            this.Text = "Добавить договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label SubcriptionLabel;
        private System.Windows.Forms.Label FlatLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.MaskedTextBox DateMTextBox;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Button AddFlatButton;
        private System.Windows.Forms.Button AddEmplButton;
        private System.Windows.Forms.ComboBox FlatComboBox;
        private System.Windows.Forms.ComboBox EmplComboBox;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.MaskedTextBox SubMTextBox;
    }
}