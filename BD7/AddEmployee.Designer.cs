namespace BD7
{
    partial class AddEmployee
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
            this.сancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.otchTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PosComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // сancelButton
            // 
            this.сancelButton.Location = new System.Drawing.Point(166, 144);
            this.сancelButton.Name = "сancelButton";
            this.сancelButton.Size = new System.Drawing.Size(80, 33);
            this.сancelButton.TabIndex = 19;
            this.сancelButton.Text = "Отмена";
            this.сancelButton.UseVisualStyleBackColor = true;
            this.сancelButton.Click += new System.EventHandler(this.сancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(81, 144);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 33);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // otchTextBox
            // 
            this.otchTextBox.Location = new System.Drawing.Point(81, 63);
            this.otchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.otchTextBox.Name = "otchTextBox";
            this.otchTextBox.Size = new System.Drawing.Size(105, 20);
            this.otchTextBox.TabIndex = 25;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(81, 39);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(105, 20);
            this.nameTextBox.TabIndex = 24;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(81, 15);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(105, 20);
            this.surnameTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя";
            // 
            // PosComboBox
            // 
            this.PosComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PosComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PosComboBox.FormattingEnabled = true;
            this.PosComboBox.Location = new System.Drawing.Point(81, 102);
            this.PosComboBox.Name = "PosComboBox";
            this.PosComboBox.Size = new System.Drawing.Size(121, 21);
            this.PosComboBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Должность";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 198);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PosComboBox);
            this.Controls.Add(this.otchTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.сancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddEmployee";
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button сancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox otchTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PosComboBox;
        private System.Windows.Forms.Label label4;
    }
}