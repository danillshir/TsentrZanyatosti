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
    public partial class FormCitizen : Form
    {
        public FormCitizen()
        {
            InitializeComponent();
            ShowCitizen();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CitizenSet citizenSet = new CitizenSet();
            citizenSet.FirstName = textBoxFirstname.Text;
            citizenSet.LastName = textBoxLastname.Text;
            citizenSet.MiddleName = textBoxMiddlename.Text;
            citizenSet.Phone = textBoxPhone.Text;
            citizenSet.Status = comboBoxStatus.Text;
            Program.znt.CitizenSet.Add(citizenSet);
            Program.znt.SaveChanges();
            ShowCitizen();
        }
        void ShowCitizen()
        {
            listViewCitizen.Items.Clear();
            foreach (CitizenSet citizenSet in Program.znt.CitizenSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    citizenSet.id.ToString(), citizenSet.FirstName, citizenSet.LastName,citizenSet.MiddleName,
                    citizenSet.Phone, citizenSet.Status
                    }
                    );
                item.Tag = citizenSet;
                listViewCitizen.Items.Add(item);

            }
            listViewCitizen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCitizen.SelectedItems.Count == 1)
            {
                CitizenSet citizenSet = listViewCitizen.SelectedItems[0].Tag as CitizenSet;
                citizenSet.FirstName = textBoxFirstname.Text;
                citizenSet.LastName = textBoxLastname.Text;
                citizenSet.MiddleName = textBoxMiddlename.Text;
                citizenSet.Phone = textBoxPhone.Text;
                citizenSet.Status = comboBoxStatus.Text;
                Program.znt.SaveChanges();
                ShowCitizen();
            }
        }

        private void listViewCitizen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCitizen.SelectedItems.Count == 1)
            {
                CitizenSet citizenSet = listViewCitizen.SelectedItems[0].Tag as CitizenSet;
                textBoxFirstname.Text = citizenSet.FirstName;
                textBoxLastname.Text = citizenSet.LastName;
                textBoxMiddlename.Text = citizenSet.MiddleName;
                textBoxPhone.Text = citizenSet.Phone;
                comboBoxStatus.Text = citizenSet.Status;
            }
            else
            {
                textBoxFirstname.Text = "";
                textBoxLastname.Text = "";
                textBoxMiddlename.Text = "";
                textBoxPhone.Text = "";
                comboBoxStatus.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCitizen.SelectedItems.Count == 1)
                {
                    CitizenSet citizenSet = listViewCitizen.SelectedItems[0].Tag as CitizenSet;
                    Program.znt.CitizenSet.Remove(citizenSet);
                    Program.znt.SaveChanges();
                    ShowCitizen();
                }
                textBoxFirstname.Text = "";
                textBoxLastname.Text = "";
                textBoxMiddlename.Text = "";
                textBoxPhone.Text = "";
                comboBoxStatus.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
