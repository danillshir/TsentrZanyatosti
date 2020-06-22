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
    public partial class FormBank : Form
    {
        public FormBank()
        {
            InitializeComponent();
            ShowBank();
            ShowEmployer();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployer.SelectedItem != null && textBoxJob.Text != "" && textBoxIncome.Text != "" && textBoxNeed.Text != "" && textBoxArranged.Text!="")
            {
                BankSet bankSet = new BankSet();
                bankSet.Job = textBoxJob.Text;
                bankSet.Income = textBoxIncome.Text;
                bankSet.Need = textBoxNeed.Text;
                bankSet.Arranged = textBoxArranged.Text;
                bankSet.idEmployer = Convert.ToInt32(comboBoxEmployer.SelectedItem.ToString().Split('.')[0]);
                Program.znt.BankSet.Add(bankSet);
                Program.znt.SaveChanges();
                ShowBank();
            }
        }
        void ShowEmployer()
        {
            comboBoxEmployer.Items.Clear();
            foreach (EmployerSet employerSet in Program.znt.EmployerSet)
            {
                string[] item = { employerSet.id.ToString() + ".", employerSet.Email };
                comboBoxEmployer.Items.Add(string.Join(" ", item));
            }
        }
        void ShowBank()
        {
            listViewBank.Items.Clear();
            foreach (BankSet bankSet in Program.znt.BankSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    bankSet.id.ToString(), bankSet.Job, bankSet.Income,bankSet.Need,
                    bankSet.Arranged, bankSet.EmployerSet.Email
                    }
                    );
                item.Tag = bankSet;
                listViewBank.Items.Add(item);

            }
            listViewBank.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBank.SelectedItems.Count == 1)
            {
                BankSet bankSet = listViewBank.SelectedItems[0].Tag as BankSet;
                bankSet.Job = textBoxJob.Text;
                bankSet.Income = textBoxIncome.Text;
                bankSet.Need = textBoxNeed.Text;
                bankSet.Arranged = textBoxArranged.Text;
                bankSet.idEmployer= Convert.ToInt32(comboBoxEmployer.SelectedItem.ToString().Split('.')[0]);
                Program.znt.SaveChanges();
                ShowBank();
            }
        }

        private void listViewBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBank.SelectedItems.Count == 1)
            {
                BankSet bankSet = listViewBank.SelectedItems[0].Tag as BankSet;
                comboBoxEmployer.SelectedIndex = comboBoxEmployer.FindString(bankSet.idEmployer.ToString());
                textBoxJob.Text = bankSet.Job;
                textBoxIncome.Text = bankSet.Income;
                textBoxNeed.Text = bankSet.Need;
                textBoxArranged.Text = bankSet.Arranged;
            }
            else
            {
                comboBoxEmployer.SelectedItem = null;
                textBoxJob.Text = "";
                textBoxIncome.Text = "";
                textBoxNeed.Text = "";
                textBoxArranged.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBank.SelectedItems.Count == 1)
                {
                    BankSet bankSet = listViewBank.SelectedItems[0].Tag as BankSet;
                    Program.znt.BankSet.Remove(bankSet);
                    Program.znt.SaveChanges();
                    ShowBank();
                }
                comboBoxEmployer.SelectedItem = null;
                textBoxJob.Text = "";
                textBoxIncome.Text = "";
                textBoxNeed.Text = "";
                textBoxArranged.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
