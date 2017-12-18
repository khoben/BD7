namespace BD7
{
    partial class AddCall
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
            this.DateMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StartTimeMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ArrivalTLable = new System.Windows.Forms.Label();
            this.FalseCallCheckBox = new System.Windows.Forms.CheckBox();
            this.IsHackedCheckBox = new System.Windows.Forms.CheckBox();
            this.BossLabel = new System.Windows.Forms.Label();
            this.DispLabel = new System.Windows.Forms.Label();
            this.BossComboBox = new System.Windows.Forms.ComboBox();
            this.DispComboBox = new System.Windows.Forms.ComboBox();
            this.AddEmplButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ContractComboBox = new System.Windows.Forms.ComboBox();
            this.ContractLabel = new System.Windows.Forms.Label();
            this.AddContractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateMTextBox
            // 
            this.DateMTextBox.Location = new System.Drawing.Point(110, 21);
            this.DateMTextBox.Mask = "00/00/0000";
            this.DateMTextBox.Name = "DateMTextBox";
            this.DateMTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateMTextBox.TabIndex = 12;
            this.DateMTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(30, 24);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(74, 13);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Дата вызова";
            // 
            // StartTimeMTextBox
            // 
            this.StartTimeMTextBox.Location = new System.Drawing.Point(110, 47);
            this.StartTimeMTextBox.Mask = "00:00";
            this.StartTimeMTextBox.Name = "StartTimeMTextBox";
            this.StartTimeMTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartTimeMTextBox.TabIndex = 14;
            this.StartTimeMTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // StartTLabel
            // 
            this.StartTLabel.AutoSize = true;
            this.StartTLabel.Location = new System.Drawing.Point(23, 50);
            this.StartTLabel.Name = "StartTLabel";
            this.StartTLabel.Size = new System.Drawing.Size(81, 13);
            this.StartTLabel.TabIndex = 13;
            this.StartTLabel.Text = "Время вызова";
            // 
            // ArrivalTimeMTextBox
            // 
            this.ArrivalTimeMTextBox.Location = new System.Drawing.Point(110, 73);
            this.ArrivalTimeMTextBox.Mask = "00:00";
            this.ArrivalTimeMTextBox.Name = "ArrivalTimeMTextBox";
            this.ArrivalTimeMTextBox.Size = new System.Drawing.Size(100, 20);
            this.ArrivalTimeMTextBox.TabIndex = 16;
            this.ArrivalTimeMTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ArrivalTLable
            // 
            this.ArrivalTLable.AutoSize = true;
            this.ArrivalTLable.Location = new System.Drawing.Point(12, 76);
            this.ArrivalTLable.Name = "ArrivalTLable";
            this.ArrivalTLable.Size = new System.Drawing.Size(92, 13);
            this.ArrivalTLable.TabIndex = 15;
            this.ArrivalTLable.Text = "Время прибытия";
            // 
            // FalseCallCheckBox
            // 
            this.FalseCallCheckBox.AutoSize = true;
            this.FalseCallCheckBox.Location = new System.Drawing.Point(110, 110);
            this.FalseCallCheckBox.Name = "FalseCallCheckBox";
            this.FalseCallCheckBox.Size = new System.Drawing.Size(103, 17);
            this.FalseCallCheckBox.TabIndex = 17;
            this.FalseCallCheckBox.Text = "Ложный вызов";
            this.FalseCallCheckBox.UseVisualStyleBackColor = true;
            this.FalseCallCheckBox.CheckedChanged += new System.EventHandler(this.FalseCallCheckBox_CheckedChanged);
            // 
            // IsHackedCheckBox
            // 
            this.IsHackedCheckBox.AutoSize = true;
            this.IsHackedCheckBox.Location = new System.Drawing.Point(110, 133);
            this.IsHackedCheckBox.Name = "IsHackedCheckBox";
            this.IsHackedCheckBox.Size = new System.Drawing.Size(82, 17);
            this.IsHackedCheckBox.TabIndex = 18;
            this.IsHackedCheckBox.Text = "Был взлом";
            this.IsHackedCheckBox.UseVisualStyleBackColor = true;
            this.IsHackedCheckBox.CheckedChanged += new System.EventHandler(this.IsHackedCheckBox_CheckedChanged);
            // 
            // BossLabel
            // 
            this.BossLabel.AutoSize = true;
            this.BossLabel.Location = new System.Drawing.Point(243, 50);
            this.BossLabel.Name = "BossLabel";
            this.BossLabel.Size = new System.Drawing.Size(101, 13);
            this.BossLabel.TabIndex = 19;
            this.BossLabel.Text = "Начальник наряда";
            // 
            // DispLabel
            // 
            this.DispLabel.AutoSize = true;
            this.DispLabel.Location = new System.Drawing.Point(283, 73);
            this.DispLabel.Name = "DispLabel";
            this.DispLabel.Size = new System.Drawing.Size(62, 13);
            this.DispLabel.TabIndex = 20;
            this.DispLabel.Text = "Диспетчер";
            // 
            // BossComboBox
            // 
            this.BossComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BossComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BossComboBox.FormattingEnabled = true;
            this.BossComboBox.Location = new System.Drawing.Point(351, 47);
            this.BossComboBox.Name = "BossComboBox";
            this.BossComboBox.Size = new System.Drawing.Size(121, 21);
            this.BossComboBox.TabIndex = 21;
            // 
            // DispComboBox
            // 
            this.DispComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DispComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DispComboBox.FormattingEnabled = true;
            this.DispComboBox.Location = new System.Drawing.Point(351, 70);
            this.DispComboBox.Name = "DispComboBox";
            this.DispComboBox.Size = new System.Drawing.Size(121, 21);
            this.DispComboBox.TabIndex = 22;
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(478, 47);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(140, 46);
            this.AddEmplButton.TabIndex = 23;
            this.AddEmplButton.Text = "Добавить сотрудника";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            this.AddEmplButton.Click += new System.EventHandler(this.AddEmplButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(199, 179);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 33);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(110, 179);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 33);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContractComboBox
            // 
            this.ContractComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ContractComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ContractComboBox.FormattingEnabled = true;
            this.ContractComboBox.Location = new System.Drawing.Point(351, 21);
            this.ContractComboBox.Name = "ContractComboBox";
            this.ContractComboBox.Size = new System.Drawing.Size(121, 21);
            this.ContractComboBox.TabIndex = 26;
            // 
            // ContractLabel
            // 
            this.ContractLabel.AutoSize = true;
            this.ContractLabel.Location = new System.Drawing.Point(293, 24);
            this.ContractLabel.Name = "ContractLabel";
            this.ContractLabel.Size = new System.Drawing.Size(51, 13);
            this.ContractLabel.TabIndex = 27;
            this.ContractLabel.Text = "Договор";
            // 
            // AddContractButton
            // 
            this.AddContractButton.Location = new System.Drawing.Point(478, 21);
            this.AddContractButton.Name = "AddContractButton";
            this.AddContractButton.Size = new System.Drawing.Size(140, 21);
            this.AddContractButton.TabIndex = 28;
            this.AddContractButton.Text = "Добавить договор";
            this.AddContractButton.UseVisualStyleBackColor = true;
            this.AddContractButton.Click += new System.EventHandler(this.AddContractButton_Click);
            // 
            // AddCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 234);
            this.Controls.Add(this.AddContractButton);
            this.Controls.Add(this.ContractLabel);
            this.Controls.Add(this.ContractComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddEmplButton);
            this.Controls.Add(this.DispComboBox);
            this.Controls.Add(this.BossComboBox);
            this.Controls.Add(this.DispLabel);
            this.Controls.Add(this.BossLabel);
            this.Controls.Add(this.IsHackedCheckBox);
            this.Controls.Add(this.FalseCallCheckBox);
            this.Controls.Add(this.ArrivalTimeMTextBox);
            this.Controls.Add(this.ArrivalTLable);
            this.Controls.Add(this.StartTimeMTextBox);
            this.Controls.Add(this.StartTLabel);
            this.Controls.Add(this.DateMTextBox);
            this.Controls.Add(this.DateLabel);
            this.Name = "AddCall";
            this.Text = "Добавить вызов";
            this.Load += new System.EventHandler(this.AddCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox DateMTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.MaskedTextBox StartTimeMTextBox;
        private System.Windows.Forms.Label StartTLabel;
        private System.Windows.Forms.MaskedTextBox ArrivalTimeMTextBox;
        private System.Windows.Forms.Label ArrivalTLable;
        private System.Windows.Forms.CheckBox FalseCallCheckBox;
        private System.Windows.Forms.CheckBox IsHackedCheckBox;
        private System.Windows.Forms.Label BossLabel;
        private System.Windows.Forms.Label DispLabel;
        private System.Windows.Forms.ComboBox BossComboBox;
        private System.Windows.Forms.ComboBox DispComboBox;
        private System.Windows.Forms.Button AddEmplButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ContractComboBox;
        private System.Windows.Forms.Label ContractLabel;
        private System.Windows.Forms.Button AddContractButton;
    }
}