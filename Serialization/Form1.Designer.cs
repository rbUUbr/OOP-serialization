namespace Serialization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogSerialization = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СериализоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десериализоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxOfElements = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxQuality = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxYearOfCreate = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelQuality = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelYearOfCreate = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerPublishDate = new System.Windows.Forms.DateTimePicker();
            this.labelЗPublishDate = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelCkass = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogSerialization
            // 
            this.openFileDialogSerialization.DefaultExt = "*.xml";
            this.openFileDialogSerialization.FileName = "openFileDialog1";
            this.openFileDialogSerialization.Filter = "Файлы XML| *.xml";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СериализоватьToolStripMenuItem,
            this.десериализоватьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // СериализоватьToolStripMenuItem
            // 
            this.СериализоватьToolStripMenuItem.Name = "СериализоватьToolStripMenuItem";
            this.СериализоватьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.СериализоватьToolStripMenuItem.Text = "Сериализовать";
            this.СериализоватьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // десериализоватьToolStripMenuItem
            // 
            this.десериализоватьToolStripMenuItem.Name = "десериализоватьToolStripMenuItem";
            this.десериализоватьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.десериализоватьToolStripMenuItem.Text = "Десериализовать";
            this.десериализоватьToolStripMenuItem.Click += new System.EventHandler(this.десериализоватьToolStripMenuItem_Click);
            // 
            // listBoxOfElements
            // 
            this.listBoxOfElements.FormattingEnabled = true;
            this.listBoxOfElements.Location = new System.Drawing.Point(655, 36);
            this.listBoxOfElements.Name = "listBoxOfElements";
            this.listBoxOfElements.Size = new System.Drawing.Size(154, 355);
            this.listBoxOfElements.TabIndex = 1;
            this.listBoxOfElements.SelectedIndexChanged += new System.EventHandler(this.listBoxOfElements_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxQuality
            // 
            this.textBoxQuality.Location = new System.Drawing.Point(12, 149);
            this.textBoxQuality.Name = "textBoxQuality";
            this.textBoxQuality.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuality.TabIndex = 3;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(12, 102);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 5;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(12, 205);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 6;
            // 
            // textBoxYearOfCreate
            // 
            this.textBoxYearOfCreate.Location = new System.Drawing.Point(12, 259);
            this.textBoxYearOfCreate.Name = "textBoxYearOfCreate";
            this.textBoxYearOfCreate.Size = new System.Drawing.Size(100, 20);
            this.textBoxYearOfCreate.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Имя";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 86);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(62, 13);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Стоимость";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(12, 133);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(54, 13);
            this.labelQuality.TabIndex = 10;
            this.labelQuality.Text = "Качество";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 188);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Количество";
            // 
            // labelYearOfCreate
            // 
            this.labelYearOfCreate.AutoSize = true;
            this.labelYearOfCreate.Location = new System.Drawing.Point(12, 243);
            this.labelYearOfCreate.Name = "labelYearOfCreate";
            this.labelYearOfCreate.Size = new System.Drawing.Size(76, 13);
            this.labelYearOfCreate.TabIndex = 13;
            this.labelYearOfCreate.Text = "Год создания";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(574, 339);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(574, 368);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerPublishDate
            // 
            this.dateTimePickerPublishDate.Location = new System.Drawing.Point(184, 52);
            this.dateTimePickerPublishDate.Name = "dateTimePickerPublishDate";
            this.dateTimePickerPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPublishDate.TabIndex = 17;
            // 
            // labelЗPublishDate
            // 
            this.labelЗPublishDate.AutoSize = true;
            this.labelЗPublishDate.Location = new System.Drawing.Point(181, 36);
            this.labelЗPublishDate.Name = "labelЗPublishDate";
            this.labelЗPublishDate.Size = new System.Drawing.Size(95, 13);
            this.labelЗPublishDate.TabIndex = 18;
            this.labelЗPublishDate.Text = "Дата публикации";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 300);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 20;
            this.labelGenre.Text = "Жанр";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(184, 86);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(46, 13);
            this.labelSize.TabIndex = 22;
            this.labelSize.Text = "Размер";
            this.labelSize.Visible = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(507, 51);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(100, 21);
            this.comboBoxClass.TabIndex = 25;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // labelCkass
            // 
            this.labelCkass.AutoSize = true;
            this.labelCkass.Location = new System.Drawing.Point(507, 35);
            this.labelCkass.Name = "labelCkass";
            this.labelCkass.Size = new System.Drawing.Size(38, 13);
            this.labelCkass.TabIndex = 24;
            this.labelCkass.Text = "Класс";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(574, 310);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(12, 316);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 27;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(184, 102);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 28;
            this.textBoxSize.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 393);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelCkass);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelЗPublishDate);
            this.Controls.Add(this.dateTimePickerPublishDate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelYearOfCreate);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxYearOfCreate);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxQuality);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxOfElements);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogSerialization;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СериализоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десериализоватьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxOfElements;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxQuality;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxYearOfCreate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelYearOfCreate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublishDate;
        private System.Windows.Forms.Label labelЗPublishDate;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelCkass;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxSize;
    }
}

