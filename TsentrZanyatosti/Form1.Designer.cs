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
            this.SuspendLayout();
            // 
            // buttonStaff
            // 
            this.buttonStaff.Location = new System.Drawing.Point(113, 136);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(125, 56);
            this.buttonStaff.TabIndex = 1;
            this.buttonStaff.Text = "Сотрудники";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonBank
            // 
            this.buttonBank.Location = new System.Drawing.Point(113, 198);
            this.buttonBank.Name = "buttonBank";
            this.buttonBank.Size = new System.Drawing.Size(125, 58);
            this.buttonBank.TabIndex = 2;
            this.buttonBank.Text = "Банк вакансий";
            this.buttonBank.UseVisualStyleBackColor = true;
            this.buttonBank.Click += new System.EventHandler(this.buttonBank_Click);
            // 
            // buttonReception
            // 
            this.buttonReception.Location = new System.Drawing.Point(113, 326);
            this.buttonReception.Name = "buttonReception";
            this.buttonReception.Size = new System.Drawing.Size(125, 61);
            this.buttonReception.TabIndex = 3;
            this.buttonReception.Text = "Запись на прием";
            this.buttonReception.UseVisualStyleBackColor = true;
            this.buttonReception.Click += new System.EventHandler(this.buttonReception_Click);
            // 
            // buttonEmployer
            // 
            this.buttonEmployer.Location = new System.Drawing.Point(113, 76);
            this.buttonEmployer.Name = "buttonEmployer";
            this.buttonEmployer.Size = new System.Drawing.Size(125, 54);
            this.buttonEmployer.TabIndex = 4;
            this.buttonEmployer.Text = "Работодатели";
            this.buttonEmployer.UseVisualStyleBackColor = true;
            this.buttonEmployer.Click += new System.EventHandler(this.buttonEmployer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Гражданин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(113, 393);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(125, 57);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Журнал выплат";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 594);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEmployer);
            this.Controls.Add(this.buttonReception);
            this.Controls.Add(this.buttonBank);
            this.Controls.Add(this.buttonStaff);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonBank;
        private System.Windows.Forms.Button buttonReception;
        private System.Windows.Forms.Button buttonEmployer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPay;
    }
}

