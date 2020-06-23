namespace TsentrZanyatosti
{
    partial class FormBank
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelArranged = new System.Windows.Forms.Label();
            this.labelNeed = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.textBoxArranged = new System.Windows.Forms.TextBox();
            this.textBoxNeed = new System.Windows.Forms.TextBox();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.listViewBank = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxEmployer = new System.Windows.Forms.ComboBox();
            this.labelEmployer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(570, 348);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 36);
            this.buttonDel.TabIndex = 36;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelArranged
            // 
            this.labelArranged.AutoSize = true;
            this.labelArranged.Location = new System.Drawing.Point(30, 292);
            this.labelArranged.Name = "labelArranged";
            this.labelArranged.Size = new System.Drawing.Size(56, 13);
            this.labelArranged.TabIndex = 33;
            this.labelArranged.Text = "Устроено";
            // 
            // labelNeed
            // 
            this.labelNeed.AutoSize = true;
            this.labelNeed.Location = new System.Drawing.Point(30, 253);
            this.labelNeed.Name = "labelNeed";
            this.labelNeed.Size = new System.Drawing.Size(60, 13);
            this.labelNeed.TabIndex = 32;
            this.labelNeed.Text = "Требуется";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(30, 214);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(75, 13);
            this.labelIncome.TabIndex = 31;
            this.labelIncome.Text = "Заработок от";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(30, 175);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(65, 13);
            this.labelJob.TabIndex = 30;
            this.labelJob.Text = "Профессия";
            // 
            // textBoxArranged
            // 
            this.textBoxArranged.Location = new System.Drawing.Point(33, 308);
            this.textBoxArranged.Name = "textBoxArranged";
            this.textBoxArranged.Size = new System.Drawing.Size(121, 20);
            this.textBoxArranged.TabIndex = 29;
            // 
            // textBoxNeed
            // 
            this.textBoxNeed.Location = new System.Drawing.Point(33, 269);
            this.textBoxNeed.Name = "textBoxNeed";
            this.textBoxNeed.Size = new System.Drawing.Size(121, 20);
            this.textBoxNeed.TabIndex = 28;
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(33, 230);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(121, 20);
            this.textBoxIncome.TabIndex = 27;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(33, 191);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(100, 20);
            this.textBoxJob.TabIndex = 26;
            // 
            // listViewBank
            // 
            this.listViewBank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1});
            this.listViewBank.FullRowSelect = true;
            this.listViewBank.GridLines = true;
            this.listViewBank.HideSelection = false;
            this.listViewBank.Location = new System.Drawing.Point(195, 135);
            this.listViewBank.MultiSelect = false;
            this.listViewBank.Name = "listViewBank";
            this.listViewBank.Size = new System.Drawing.Size(495, 207);
            this.listViewBank.TabIndex = 37;
            this.listViewBank.UseCompatibleStateImageBehavior = false;
            this.listViewBank.View = System.Windows.Forms.View.Details;
            this.listViewBank.SelectedIndexChanged += new System.EventHandler(this.listViewBank_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Профессия";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Заработок от";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Требуется";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Устроено";
            this.columnHeader5.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Компания";
            this.columnHeader1.Width = 79;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(374, 348);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 36);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(195, 348);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 36);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxEmployer
            // 
            this.comboBoxEmployer.FormattingEnabled = true;
            this.comboBoxEmployer.Location = new System.Drawing.Point(33, 151);
            this.comboBoxEmployer.Name = "comboBoxEmployer";
            this.comboBoxEmployer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployer.TabIndex = 41;
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Location = new System.Drawing.Point(30, 135);
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(78, 13);
            this.labelEmployer.TabIndex = 42;
            this.labelEmployer.Text = "Работодатели";
            // 
            // FormBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(738, 415);
            this.Controls.Add(this.labelEmployer);
            this.Controls.Add(this.comboBoxEmployer);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewBank);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelArranged);
            this.Controls.Add(this.labelNeed);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.textBoxArranged);
            this.Controls.Add(this.textBoxNeed);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.textBoxJob);
            this.Name = "FormBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelArranged;
        private System.Windows.Forms.Label labelNeed;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox textBoxArranged;
        private System.Windows.Forms.TextBox textBoxNeed;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.ListView listViewBank;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxEmployer;
        private System.Windows.Forms.Label labelEmployer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}