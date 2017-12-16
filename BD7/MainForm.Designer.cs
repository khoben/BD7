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
            this.договораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штрафыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.queryInfoLabel = new System.Windows.Forms.Label();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.RawEditLabel = new System.Windows.Forms.Label();
            this.ToogleRawEditButton = new BD7.MyCheckBox();
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
            this.отчетыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // договораToolStripMenuItem
            // 
            this.договораToolStripMenuItem.Name = "договораToolStripMenuItem";
            this.договораToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.договораToolStripMenuItem.Text = "Договоры";
            this.договораToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.платежиToolStripMenuItem.Text = "Платежи";
            this.платежиToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // штрафыToolStripMenuItem
            // 
            this.штрафыToolStripMenuItem.Name = "штрафыToolStripMenuItem";
            this.штрафыToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.штрафыToolStripMenuItem.Text = "Штрафы";
            this.штрафыToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // звонкиToolStripMenuItem
            // 
            this.звонкиToolStripMenuItem.Name = "звонкиToolStripMenuItem";
            this.звонкиToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.звонкиToolStripMenuItem.Text = "Сигналы тревоги";
            this.звонкиToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.OnChangeUser);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 62);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(755, 200);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // queryInfoLabel
            // 
            this.queryInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryInfoLabel.Location = new System.Drawing.Point(8, 29);
            this.queryInfoLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.queryInfoLabel.Name = "queryInfoLabel";
            this.queryInfoLabel.Size = new System.Drawing.Size(755, 23);
            this.queryInfoLabel.TabIndex = 2;
            this.queryInfoLabel.Text = "Не выполнено ни одного запроса";
            this.queryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchPatternTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchPatternTextBox.Location = new System.Drawing.Point(8, 287);
            this.searchPatternTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(201, 20);
            this.searchPatternTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(233, 283);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 26);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Location = new System.Drawing.Point(660, 285);
            this.deleteRowButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(100, 23);
            this.deleteRowButton.TabIndex = 5;
            this.deleteRowButton.Text = "Удалить";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.DeleteClient);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(460, 287);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.callFormFromCurrentContext);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(566, 286);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(619, 5);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(35, 13);
            this.LabelUsername.TabIndex = 8;
            this.LabelUsername.Text = "label1";
            // 
            // RawEditLabel
            // 
            this.RawEditLabel.AutoSize = true;
            this.RawEditLabel.Location = new System.Drawing.Point(590, 35);
            this.RawEditLabel.Name = "RawEditLabel";
            this.RawEditLabel.Size = new System.Drawing.Size(133, 13);
            this.RawEditLabel.TabIndex = 10;
            this.RawEditLabel.Text = "Прямое редактирование";
            // 
            // ToogleRawEditButton
            // 
            this.ToogleRawEditButton.Location = new System.Drawing.Point(729, 34);
            this.ToogleRawEditButton.Name = "ToogleRawEditButton";
            this.ToogleRawEditButton.Padding = new System.Windows.Forms.Padding(6);
            this.ToogleRawEditButton.Size = new System.Drawing.Size(32, 14);
            this.ToogleRawEditButton.TabIndex = 9;
            this.ToogleRawEditButton.CheckedChanged += new System.EventHandler(this.ToogleRawEditSwitch);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 322);
            this.Controls.Add(this.RawEditLabel);
            this.Controls.Add(this.ToogleRawEditButton);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPatternTextBox);
            this.Controls.Add(this.queryInfoLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "ОВО по охране квартир";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label queryInfoLabel;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem договораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штрафыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.Label LabelUsername;
        private MyCheckBox ToogleRawEditButton;
        private System.Windows.Forms.Label RawEditLabel;
    }
}