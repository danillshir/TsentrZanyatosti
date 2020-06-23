namespace TsentrZanyatosti
{
    partial class FormPay
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.listViewPay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCitizen = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCitizen
            // 
            this.comboBoxCitizen.FormattingEnabled = true;
            this.comboBoxCitizen.Location = new System.Drawing.Point(33, 127);
            this.comboBoxCitizen.Name = "comboBoxCitizen";
            this.comboBoxCitizen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCitizen.TabIndex = 0;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Материальная поддержка",
            "Пособие",
            "Стипендия"});
            this.comboBoxType.Location = new System.Drawing.Point(33, 192);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 1;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(33, 265);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxDate.TabIndex = 2;
            // 
            // listViewPay
            // 
            this.listViewPay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewPay.FullRowSelect = true;
            this.listViewPay.GridLines = true;
            this.listViewPay.HideSelection = false;
            this.listViewPay.Location = new System.Drawing.Point(198, 111);
            this.listViewPay.MultiSelect = false;
            this.listViewPay.Name = "listViewPay";
            this.listViewPay.Size = new System.Drawing.Size(493, 174);
            this.listViewPay.TabIndex = 3;
            this.listViewPay.UseCompatibleStateImageBehavior = false;
            this.listViewPay.View = System.Windows.Forms.View.Details;
            this.listViewPay.SelectedIndexChanged += new System.EventHandler(this.listViewPay_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО Гражданина";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Статус";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Тип выплаты";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Период выплаты";
            this.columnHeader5.Width = 106;
            // 
            // labelCitizen
            // 
            this.labelCitizen.AutoSize = true;
            this.labelCitizen.Location = new System.Drawing.Point(30, 111);
            this.labelCitizen.Name = "labelCitizen";
            this.labelCitizen.Size = new System.Drawing.Size(63, 13);
            this.labelCitizen.TabIndex = 4;
            this.labelCitizen.Text = "Гражданин";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(30, 176);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(74, 13);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "Тип выплаты";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(30, 249);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(93, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Период выплаты";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(198, 303);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 36);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(382, 303);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 36);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(571, 303);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 36);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(736, 380);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCitizen);
            this.Controls.Add(this.listViewPay);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxCitizen);
            this.Name = "FormPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCitizen;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ListView listViewPay;
        private System.Windows.Forms.Label labelCitizen;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}