namespace TsentrZanyatosti
{
    partial class Menu
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
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonBank = new System.Windows.Forms.Button();
            this.buttonReception = new System.Windows.Forms.Button();
            this.buttonEmployer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.SystemColors.Info;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStaff.Location = new System.Drawing.Point(14, 212);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(265, 48);
            this.buttonStaff.TabIndex = 1;
            this.buttonStaff.Text = "Сотрудники";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonBank
            // 
            this.buttonBank.BackColor = System.Drawing.SystemColors.Info;
            this.buttonBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBank.Location = new System.Drawing.Point(14, 266);
            this.buttonBank.Name = "buttonBank";
            this.buttonBank.Size = new System.Drawing.Size(265, 48);
            this.buttonBank.TabIndex = 2;
            this.buttonBank.Text = "Банк вакансий";
            this.buttonBank.UseVisualStyleBackColor = false;
            this.buttonBank.Click += new System.EventHandler(this.buttonBank_Click);
            // 
            // buttonReception
            // 
            this.buttonReception.BackColor = System.Drawing.SystemColors.Info;
            this.buttonReception.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReception.Location = new System.Drawing.Point(14, 374);
            this.buttonReception.Name = "buttonReception";
            this.buttonReception.Size = new System.Drawing.Size(265, 48);
            this.buttonReception.TabIndex = 3;
            this.buttonReception.Text = "Запись на прием";
            this.buttonReception.UseVisualStyleBackColor = false;
            this.buttonReception.Click += new System.EventHandler(this.buttonReception_Click);
            // 
            // buttonEmployer
            // 
            this.buttonEmployer.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployer.Location = new System.Drawing.Point(12, 158);
            this.buttonEmployer.Name = "buttonEmployer";
            this.buttonEmployer.Size = new System.Drawing.Size(265, 48);
            this.buttonEmployer.TabIndex = 4;
            this.buttonEmployer.Text = "Работодатели";
            this.buttonEmployer.UseVisualStyleBackColor = false;
            this.buttonEmployer.Click += new System.EventHandler(this.buttonEmployer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(14, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Гражданин";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.Info;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPay.Location = new System.Drawing.Point(14, 428);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(265, 48);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Журнал выплат";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TsentrZanyatosti.Properties.Resources.Без_имени_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.ForeColor = System.Drawing.Color.Black;
            this.labelHello.Location = new System.Drawing.Point(12, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(29, 13);
            this.labelHello.TabIndex = 8;
            this.labelHello.Text = "label";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(291, 498);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEmployer);
            this.Controls.Add(this.buttonReception);
            this.Controls.Add(this.buttonBank);
            this.Controls.Add(this.buttonStaff);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonBank;
        private System.Windows.Forms.Button buttonReception;
        private System.Windows.Forms.Button buttonEmployer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
    }
}

