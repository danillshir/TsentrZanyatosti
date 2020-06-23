namespace TsentrZanyatosti
{
    partial class FormReception
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
            this.comboBoxCitizen = new System.Windows.Forms.ComboBox();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.labelStaff = new System.Windows.Forms.Label();
            this.listViewReception = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxEmployer = new System.Windows.Forms.ComboBox();
            this.labelEmployer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCitizen
            // 
            this.comboBoxCitizen.FormattingEnabled = true;
            this.comboBoxCitizen.Location = new System.Drawing.Point(24, 138);
            this.comboBoxCitizen.Name = "comboBoxCitizen";
            this.comboBoxCitizen.Size = new System.Drawing.Size(123, 21);
            this.comboBoxCitizen.TabIndex = 0;
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(24, 178);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(123, 20);
            this.textBoxService.TabIndex = 1;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(25, 217);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(122, 20);
            this.textBoxDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор гражданина";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(21, 162);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(62, 13);
            this.labelService.TabIndex = 4;
            this.labelService.Text = "Вид услуги";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(21, 201);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(93, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата обращения";
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(26, 256);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStaff.TabIndex = 6;
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Location = new System.Drawing.Point(23, 240);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(60, 13);
            this.labelStaff.TabIndex = 7;
            this.labelStaff.Text = "Сотрудник";
            // 
            // listViewReception
            // 
            this.listViewReception.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewReception.FullRowSelect = true;
            this.listViewReception.GridLines = true;
            this.listViewReception.HideSelection = false;
            this.listViewReception.Location = new System.Drawing.Point(164, 122);
            this.listViewReception.MultiSelect = false;
            this.listViewReception.Name = "listViewReception";
            this.listViewReception.Size = new System.Drawing.Size(699, 195);
            this.listViewReception.TabIndex = 8;
            this.listViewReception.UseCompatibleStateImageBehavior = false;
            this.listViewReception.View = System.Windows.Forms.View.Details;
            this.listViewReception.SelectedIndexChanged += new System.EventHandler(this.listViewReception_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id гражданина";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО гражданина";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Вид услуги";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата обращения";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id сотрудника";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ФИО сотрудника";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Работодатель";
            this.columnHeader7.Width = 111;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(164, 331);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(437, 331);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 36);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(703, 331);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 36);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxEmployer
            // 
            this.comboBoxEmployer.FormattingEnabled = true;
            this.comboBoxEmployer.Location = new System.Drawing.Point(26, 296);
            this.comboBoxEmployer.Name = "comboBoxEmployer";
            this.comboBoxEmployer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployer.TabIndex = 12;
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Location = new System.Drawing.Point(23, 280);
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(78, 13);
            this.labelEmployer.TabIndex = 13;
            this.labelEmployer.Text = "Работодатель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TsentrZanyatosti.Properties.Resources.Без_имени_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FormReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(886, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEmployer);
            this.Controls.Add(this.comboBoxEmployer);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewReception);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.comboBoxCitizen);
            this.Name = "FormReception";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReception";
            this.Load += new System.EventHandler(this.FormReception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCitizen;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.ListView listViewReception;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox comboBoxEmployer;
        private System.Windows.Forms.Label labelEmployer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}