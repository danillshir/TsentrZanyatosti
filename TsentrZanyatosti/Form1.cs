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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == null) buttonPay.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Form formStaff = new FormStaff();
            formStaff.Show();
        }

        private void buttonBank_Click(object sender, EventArgs e)
        {
            Form formBank = new FormBank();
            formBank.Show();
        }

        private void buttonReception_Click(object sender, EventArgs e)
        {
            Form formReception = new FormReception();
            formReception.Show();
        }

        private void buttonEmployer_Click(object sender, EventArgs e)
        {
            Form formEmployer = new FormEmployer();
            formEmployer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formCitizen = new FormCitizen();
            formCitizen.Show();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            Form formPay = new FormPay();
            formPay.Show();
        }
    }
}
