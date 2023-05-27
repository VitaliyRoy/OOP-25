namespace lr25
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
            this.components = new System.ComponentModel.Container();
            this.btn_browse = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваГриDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.розробникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВиходуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зображенняDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new lr25.AppData();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_developer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btb_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gamesTableAdapter = new lr25.AppDataTableAdapters.GamesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(3, 150);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(138, 23);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Обрати зображення";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.назваГриDataGridViewTextBoxColumn,
            this.розробникDataGridViewTextBoxColumn,
            this.датаВиходуDataGridViewTextBoxColumn,
            this.зображенняDataGridViewImageColumn});
            this.dataGridView.DataSource = this.gamesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(11, 228);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(597, 210);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // назваГриDataGridViewTextBoxColumn
            // 
            this.назваГриDataGridViewTextBoxColumn.DataPropertyName = "Назва гри";
            this.назваГриDataGridViewTextBoxColumn.HeaderText = "Назва гри";
            this.назваГриDataGridViewTextBoxColumn.Name = "назваГриDataGridViewTextBoxColumn";
            // 
            // розробникDataGridViewTextBoxColumn
            // 
            this.розробникDataGridViewTextBoxColumn.DataPropertyName = "Розробник";
            this.розробникDataGridViewTextBoxColumn.HeaderText = "Розробник";
            this.розробникDataGridViewTextBoxColumn.Name = "розробникDataGridViewTextBoxColumn";
            // 
            // датаВиходуDataGridViewTextBoxColumn
            // 
            this.датаВиходуDataGridViewTextBoxColumn.DataPropertyName = "Дата виходу";
            this.датаВиходуDataGridViewTextBoxColumn.HeaderText = "Дата виходу";
            this.датаВиходуDataGridViewTextBoxColumn.Name = "датаВиходуDataGridViewTextBoxColumn";
            // 
            // зображенняDataGridViewImageColumn
            // 
            this.зображенняDataGridViewImageColumn.DataPropertyName = "Зображення";
            this.зображенняDataGridViewImageColumn.HeaderText = "Зображення";
            this.зображенняDataGridViewImageColumn.Name = "зображенняDataGridViewImageColumn";
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва гри";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txt_year);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txt_developer);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txt_name);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.btn_browse);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(596, 184);
            this.panel.TabIndex = 3;
            // 
            // txt_year
            // 
            this.txt_year.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "Дата виходу", true));
            this.txt_year.Location = new System.Drawing.Point(236, 85);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(357, 20);
            this.txt_year.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата виходу";
            // 
            // txt_developer
            // 
            this.txt_developer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "Розробник", true));
            this.txt_developer.Location = new System.Drawing.Point(236, 59);
            this.txt_developer.Name = "txt_developer";
            this.txt_developer.Size = new System.Drawing.Size(357, 20);
            this.txt_developer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Розробник";
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "Назва гри", true));
            this.txt_name.Location = new System.Drawing.Point(236, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(357, 20);
            this.txt_name.TabIndex = 5;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gamesBindingSource, "Зображення", true));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(138, 141);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(59, 202);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(549, 20);
            this.txt_search.TabIndex = 11;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пошук";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(359, 444);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Редагувати";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btb_cancel
            // 
            this.btb_cancel.Location = new System.Drawing.Point(440, 444);
            this.btb_cancel.Name = "btb_cancel";
            this.btb_cancel.Size = new System.Drawing.Size(75, 23);
            this.btb_cancel.TabIndex = 11;
            this.btb_cancel.Text = "Відмінити";
            this.btb_cancel.UseVisualStyleBackColor = true;
            this.btb_cancel.Click += new System.EventHandler(this.btb_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(521, 444);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Зберегти";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(278, 444);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 13;
            this.btn_new.Text = "Новий";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 485);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btb_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 25";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_developer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btb_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private AppData appData;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private AppDataTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваГриDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn розробникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВиходуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn зображенняDataGridViewImageColumn;
    }
}

