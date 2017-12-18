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
            this.SubMTextBox.Location = new System.Drawing.Point(200, 65);
            this.SubMTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubMTextBox.Name = "SubMTextBox";
            this.SubMTextBox.Size = new System.Drawing.Size(148, 26);
            this.SubMTextBox.TabIndex = 20;
            // 
            // SubcriptionLabel
            // 
            this.SubcriptionLabel.AutoSize = true;
            this.SubcriptionLabel.Location = new System.Drawing.Point(75, 69);
            this.SubcriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubcriptionLabel.Name = "SubcriptionLabel";
            this.SubcriptionLabel.Size = new System.Drawing.Size(116, 20);
            this.SubcriptionLabel.TabIndex = 19;
            this.SubcriptionLabel.Text = "Цена штрафа";
            // 
            // DateMTextBox
            // 
            this.DateMTextBox.Location = new System.Drawing.Point(200, 25);
            this.DateMTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateMTextBox.Mask = "00/00/0000";
            this.DateMTextBox.Name = "DateMTextBox";
            this.DateMTextBox.Size = new System.Drawing.Size(148, 26);
            this.DateMTextBox.TabIndex = 22;
            this.DateMTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(45, 29);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(144, 20);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Дата заключения";
            // 
            // AddContractButton
            // 
            this.AddContractButton.Location = new System.Drawing.Point(682, 126);
            this.AddContractButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddContractButton.Name = "AddContractButton";
            this.AddContractButton.Size = new System.Drawing.Size(210, 32);
            this.AddContractButton.TabIndex = 34;
            this.AddContractButton.Text = "Добавить договор";
            this.AddContractButton.UseVisualStyleBackColor = true;
            this.AddContractButton.Click += new System.EventHandler(this.AddContractButton_Click);
            // 
            // ContractLabel
            // 
            this.ContractLabel.AutoSize = true;
            this.ContractLabel.Location = new System.Drawing.Point(112, 131);
            this.ContractLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContractLabel.Name = "ContractLabel";
            this.ContractLabel.Size = new System.Drawing.Size(73, 20);
            this.ContractLabel.TabIndex = 33;
            this.ContractLabel.Text = "Договор";
            // 
            // ContractComboBox
            // 
            this.ContractComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ContractComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ContractComboBox.FormattingEnabled = true;
            this.ContractComboBox.Location = new System.Drawing.Point(200, 126);
            this.ContractComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContractComboBox.Name = "ContractComboBox";
            this.ContractComboBox.Size = new System.Drawing.Size(427, 28);
            this.ContractComboBox.TabIndex = 32;
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(682, 166);
            this.AddEmplButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(210, 32);
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
            this.BComboBox.Location = new System.Drawing.Point(200, 166);
            this.BComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BComboBox.Name = "BComboBox";
            this.BComboBox.Size = new System.Drawing.Size(427, 28);
            this.BComboBox.TabIndex = 30;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(102, 171);
            this.BLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(87, 20);
            this.BLabel.TabIndex = 29;
            this.BLabel.Text = "Бухгалтер";
            // 
            // FineTypeComboBox
            // 
            this.FineTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FineTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FineTypeComboBox.FormattingEnabled = true;
            this.FineTypeComboBox.Location = new System.Drawing.Point(200, 208);
            this.FineTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FineTypeComboBox.Name = "FineTypeComboBox";
            this.FineTypeComboBox.Size = new System.Drawing.Size(427, 28);
            this.FineTypeComboBox.TabIndex = 36;
            // 
            // TypeFineLabel
            // 
            this.TypeFineLabel.AutoSize = true;
            this.TypeFineLabel.Location = new System.Drawing.Point(88, 212);
            this.TypeFineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeFineLabel.Name = "TypeFineLabel";
            this.TypeFineLabel.Size = new System.Drawing.Size(104, 20);
            this.TypeFineLabel.TabIndex = 35;
            this.TypeFineLabel.Text = "Тип штрафа";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(333, 282);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 51);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(200, 282);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 51);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 368);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddFine";
            this.Text = "Добавить штраф";
            this.Load += new System.EventHandler(this.AddFine_Load);
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