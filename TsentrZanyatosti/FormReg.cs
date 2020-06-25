using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsentrZanyatosti
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void buttonCanscel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text != "" && textBoxPass.Text != "")
            {
                Users user  = new Users();
                user.Login = textBoxLog.Text;
                user.Password = textBoxPass.Text;
                Program.znt.Users.Add(user);
                Program.znt.SaveChanges();
                Close();
                MessageBox.Show("Регистрация успешно завершена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Впишите логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
