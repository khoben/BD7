namespace BD7
{
    partial class AddPayment
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
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typePaymentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contractComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accountantComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(186, 46);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(525, 26);
            this.dateTextBox.TabIndex = 0;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата платежа";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(186, 103);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(525, 26);
            this.sumTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма платежа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип платежа";
            // 
            // typePaymentComboBox
            // 
            this.typePaymentComboBox.FormattingEnabled = true;
            this.typePaymentComboBox.Location = new System.Drawing.Point(186, 156);
            this.typePaymentComboBox.Name = "typePaymentComboBox";
            this.typePaymentComboBox.Size = new System.Drawing.Size(525, 28);
            this.typePaymentComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Договор";
            // 
            // contractComboBox
            // 
            this.contractComboBox.FormattingEnabled = true;
            this.contractComboBox.Location = new System.Drawing.Point(186, 216);
            this.contractComboBox.Name = "contractComboBox";
            this.contractComboBox.Size = new System.Drawing.Size(525, 28);
            this.contractComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Бухгалтер";
            // 
            // accountantComboBox
            // 
            this.accountantComboBox.FormattingEnabled = true;
            this.accountantComboBox.Location = new System.Drawing.Point(186, 277);
            this.accountantComboBox.Name = "accountantComboBox";
            this.accountantComboBox.Size = new System.Drawing.Size(525, 28);
            this.accountantComboBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(49, 349);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 38);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(614, 349);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 38);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 425);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.accountantComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contractComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typePaymentComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTextBox);
            this.Name = "AddPayment";
            this.Text = "Добавить платеж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typePaymentComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox contractComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox accountantComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}