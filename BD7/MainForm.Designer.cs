namespace BD7
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.штрафыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.звонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.queryInfoLabel = new System.Windows.Forms.Label();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.договораToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.платежиToolStripMenuItem,
            this.штрафыToolStripMenuItem,
            this.звонкиToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.ClientsList);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddClient);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // договораToolStripMenuItem
            // 
            this.договораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem1,
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1});
            this.договораToolStripMenuItem.Name = "договораToolStripMenuItem";
            this.договораToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.договораToolStripMenuItem.Text = "Договоры";
            // 
            // списокToolStripMenuItem1
            // 
            this.списокToolStripMenuItem1.Name = "списокToolStripMenuItem1";
            this.списокToolStripMenuItem1.Size = new System.Drawing.Size(175, 30);
            this.списокToolStripMenuItem1.Text = "Список";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(175, 30);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(175, 30);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem2,
            this.добавитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // списокToolStripMenuItem2
            // 
            this.списокToolStripMenuItem2.Name = "списокToolStripMenuItem2";
            this.списокToolStripMenuItem2.Size = new System.Drawing.Size(175, 30);
            this.списокToolStripMenuItem2.Text = "Список";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(175, 30);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(175, 30);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem3,
            this.добавитьToolStripMenuItem3,
            this.изменитьToolStripMenuItem3});
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.платежиToolStripMenuItem.Text = "Платежи";
            // 
            // списокToolStripMenuItem3
            // 
            this.списокToolStripMenuItem3.Name = "списокToolStripMenuItem3";
            this.списокToolStripMenuItem3.Size = new System.Drawing.Size(175, 30);
            this.списокToolStripMenuItem3.Text = "Список";
            // 
            // добавитьToolStripMenuItem3
            // 
            this.добавитьToolStripMenuItem3.Name = "добавитьToolStripMenuItem3";
            this.добавитьToolStripMenuItem3.Size = new System.Drawing.Size(175, 30);
            this.добавитьToolStripMenuItem3.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem3
            // 
            this.изменитьToolStripMenuItem3.Name = "изменитьToolStripMenuItem3";
            this.изменитьToolStripMenuItem3.Size = new System.Drawing.Size(175, 30);
            this.изменитьToolStripMenuItem3.Text = "Изменить";
            // 
            // штрафыToolStripMenuItem
            // 
            this.штрафыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem4,
            this.добавитьToolStripMenuItem4,
            this.изменитьToolStripMenuItem4});
            this.штрафыToolStripMenuItem.Name = "штрафыToolStripMenuItem";
            this.штрафыToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.штрафыToolStripMenuItem.Text = "Штрафы";
            // 
            // списокToolStripMenuItem4
            // 
            this.списокToolStripMenuItem4.Name = "списокToolStripMenuItem4";
            this.списокToolStripMenuItem4.Size = new System.Drawing.Size(175, 30);
            this.списокToolStripMenuItem4.Text = "Список";
            // 
            // добавитьToolStripMenuItem4
            // 
            this.добавитьToolStripMenuItem4.Name = "добавитьToolStripMenuItem4";
            this.добавитьToolStripMenuItem4.Size = new System.Drawing.Size(175, 30);
            this.добавитьToolStripMenuItem4.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem4
            // 
            this.изменитьToolStripMenuItem4.Name = "изменитьToolStripMenuItem4";
            this.изменитьToolStripMenuItem4.Size = new System.Drawing.Size(175, 30);
            this.изменитьToolStripMenuItem4.Text = "Изменить";
            // 
            // звонкиToolStripMenuItem
            // 
            this.звонкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem5,
            this.добавитьToolStripMenuItem5,
            this.изменитьToolStripMenuItem5});
            this.звонкиToolStripMenuItem.Name = "звонкиToolStripMenuItem";
            this.звонкиToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.звонкиToolStripMenuItem.Text = "Звонки";
            // 
            // списокToolStripMenuItem5
            // 
            this.списокToolStripMenuItem5.Name = "списокToolStripMenuItem5";
            this.списокToolStripMenuItem5.Size = new System.Drawing.Size(175, 30);
            this.списокToolStripMenuItem5.Text = "Список";
            // 
            // добавитьToolStripMenuItem5
            // 
            this.добавитьToolStripMenuItem5.Name = "добавитьToolStripMenuItem5";
            this.добавитьToolStripMenuItem5.Size = new System.Drawing.Size(175, 30);
            this.добавитьToolStripMenuItem5.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem5
            // 
            this.изменитьToolStripMenuItem5.Name = "изменитьToolStripMenuItem5";
            this.изменитьToolStripMenuItem5.Size = new System.Drawing.Size(175, 30);
            this.изменитьToolStripMenuItem5.Text = "Изменить";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.OnChangeUser);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.OnClose);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 95);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1132, 307);
            this.dataGridView.TabIndex = 1;
            // 
            // queryInfoLabel
            // 
            this.queryInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryInfoLabel.Location = new System.Drawing.Point(12, 44);
            this.queryInfoLabel.Name = "queryInfoLabel";
            this.queryInfoLabel.Size = new System.Drawing.Size(1132, 36);
            this.queryInfoLabel.TabIndex = 2;
            this.queryInfoLabel.Text = "Не выполнено ни одного запроса";
            this.queryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Location = new System.Drawing.Point(130, 443);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(206, 26);
            this.searchPatternTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(385, 438);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 36);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 496);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPatternTextBox);
            this.Controls.Add(this.queryInfoLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label queryInfoLabel;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem договораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem штрафыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem звонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}