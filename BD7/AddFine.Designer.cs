namespace BD7
{
    partial class AddFine
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
            this.SubMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SubcriptionLabel = new System.Windows.Forms.Label();
            this.DateMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AddContractButton = new System.Windows.Forms.Button();
            this.ContractLabel = new System.Windows.Forms.Label();
            this.ContractComboBox = new System.Windows.Forms.ComboBox();
            this.AddEmplButton = new System.Windows.Forms.Button();
            this.BComboBox = new System.Windows.Forms.ComboBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.FineTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeFineLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubMTextBox
            // 
            this.SubMTextBox.Location = new System.Drawing.Point(133, 42);
            this.SubMTextBox.Name = "SubMTextBox";
            this.SubMTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubMTextBox.TabIndex = 20;
            // 
            // SubcriptionLabel
            // 
            this.SubcriptionLabel.AutoSize = true;
            this.SubcriptionLabel.Location = new System.Drawing.Point(12, 45);
            this.SubcriptionLabel.Name = "SubcriptionLabel";
            this.SubcriptionLabel.Size = new System.Drawing.Size(115, 13);
            this.SubcriptionLabel.TabIndex = 19;
            this.SubcriptionLabel.Text = "Ежемесячная оплата";
            // 
            // DateMTextBox
            // 
            this.DateMTextBox.Location = new System.Drawing.Point(133, 16);
            this.DateMTextBox.Mask = "00/00/0000";
            this.DateMTextBox.Name = "DateMTextBox";
            this.DateMTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateMTextBox.TabIndex = 22;
            this.DateMTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(30, 19);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(97, 13);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Дата заключения";
            // 
            // AddContractButton
            // 
            this.AddContractButton.Location = new System.Drawing.Point(260, 82);
            this.AddContractButton.Name = "AddContractButton";
            this.AddContractButton.Size = new System.Drawing.Size(140, 21);
            this.AddContractButton.TabIndex = 34;
            this.AddContractButton.Text = "Добавить договор";
            this.AddContractButton.UseVisualStyleBackColor = true;
            this.AddContractButton.Click += new System.EventHandler(this.AddContractButton_Click);
            // 
            // ContractLabel
            // 
            this.ContractLabel.AutoSize = true;
            this.ContractLabel.Location = new System.Drawing.Point(75, 85);
            this.ContractLabel.Name = "ContractLabel";
            this.ContractLabel.Size = new System.Drawing.Size(51, 13);
            this.ContractLabel.TabIndex = 33;
            this.ContractLabel.Text = "Договор";
            // 
            // ContractComboBox
            // 
            this.ContractComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ContractComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ContractComboBox.FormattingEnabled = true;
            this.ContractComboBox.Location = new System.Drawing.Point(133, 82);
            this.ContractComboBox.Name = "ContractComboBox";
            this.ContractComboBox.Size = new System.Drawing.Size(121, 21);
            this.ContractComboBox.TabIndex = 32;
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(260, 108);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(140, 21);
            this.AddEmplButton.TabIndex = 31;
            this.AddEmplButton.Text = "Добавить сотрудника";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            this.AddEmplButton.Click += new System.EventHandler(this.AddEmplButton_Click);
            // 
            // BComboBox
            // 
            this.BComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BComboBox.FormattingEnabled = true;
            this.BComboBox.Location = new System.Drawing.Point(133, 108);
            this.BComboBox.Name = "BComboBox";
            this.BComboBox.Size = new System.Drawing.Size(121, 21);
            this.BComboBox.TabIndex = 30;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(68, 111);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(58, 13);
            this.BLabel.TabIndex = 29;
            this.BLabel.Text = "Бухгалтер";
            // 
            // FineTypeComboBox
            // 
            this.FineTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FineTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FineTypeComboBox.FormattingEnabled = true;
            this.FineTypeComboBox.Location = new System.Drawing.Point(133, 135);
            this.FineTypeComboBox.Name = "FineTypeComboBox";
            this.FineTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.FineTypeComboBox.TabIndex = 36;
            // 
            // TypeFineLabel
            // 
            this.TypeFineLabel.AutoSize = true;
            this.TypeFineLabel.Location = new System.Drawing.Point(59, 138);
            this.TypeFineLabel.Name = "TypeFineLabel";
            this.TypeFineLabel.Size = new System.Drawing.Size(68, 13);
            this.TypeFineLabel.TabIndex = 35;
            this.TypeFineLabel.Text = "Тип штрафа";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(222, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 33);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(133, 183);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 33);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 239);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FineTypeComboBox);
            this.Controls.Add(this.TypeFineLabel);
            this.Controls.Add(this.AddContractButton);
            this.Controls.Add(this.ContractLabel);
            this.Controls.Add(this.ContractComboBox);
            this.Controls.Add(this.AddEmplButton);
            this.Controls.Add(this.BComboBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.DateMTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SubMTextBox);
            this.Controls.Add(this.SubcriptionLabel);
            this.Name = "AddFine";
            this.Text = "Добавить штраф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox SubMTextBox;
        private System.Windows.Forms.Label SubcriptionLabel;
        private System.Windows.Forms.MaskedTextBox DateMTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button AddContractButton;
        private System.Windows.Forms.Label ContractLabel;
        private System.Windows.Forms.ComboBox ContractComboBox;
        private System.Windows.Forms.Button AddEmplButton;
        private System.Windows.Forms.ComboBox BComboBox;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.ComboBox FineTypeComboBox;
        private System.Windows.Forms.Label TypeFineLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}