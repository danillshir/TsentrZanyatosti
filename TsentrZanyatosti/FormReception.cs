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
    public partial class FormReception : Form
    {
        public FormReception()
        {
            InitializeComponent();
            ShowCitizen();
            ShowStaff();
            ShowReception();
            ShowEmployer();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCitizen.SelectedItem != null && comboBoxStaff.SelectedItem != null && textBoxDate.Text != "" && textBoxService.Text != "")
            {
                ReceptionSet reception = new ReceptionSet();
                reception.idCitizen = Convert.ToInt32(comboBoxCitizen.SelectedItem.ToString().Split('.')[0]);
                reception.idStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                reception.service = textBoxService.Text;
                reception.date = textBoxDate.Text;
                reception.idEmployer = Convert.ToInt32(comboBoxEmployer.SelectedItem.ToString().Split('.')[0]);
                Program.znt.ReceptionSet.Add(reception);
                Program.znt.SaveChanges();
                ShowReception();
            }
            else MessageBox.Show("Выберите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowEmployer()
        {
            comboBoxEmployer.Items.Clear();
            foreach (EmployerSet employerSet in Program.znt.EmployerSet)
            {
                string[] item = { employerSet.id.ToString() + ".", employerSet.Email};
                comboBoxEmployer.Items.Add(string.Join(" ", item));
            }
        }
        void ShowCitizen()
        {
            comboBoxCitizen.Items.Clear();
            foreach (CitizenSet citizenSet in Program.znt.CitizenSet)
            {
                string[] item = { citizenSet.id.ToString() + ".", citizenSet.FirstName, citizenSet.MiddleName, citizenSet.LastName };
                comboBoxCitizen.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStaff()
        {
            comboBoxStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.znt.StaffSet)
            {
                string[] item = { staffSet.id.ToString() + ".", staffSet.FirstName, staffSet.MiddleName, staffSet.LastName };
                comboBoxStaff.Items.Add(string.Join(" ", item));
            }

        }
        void ShowReception()
        {
            listViewReception.Items.Clear();
            foreach (ReceptionSet reception in Program.znt.ReceptionSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        reception.idCitizen.ToString(), reception.CitizenSet.LastName+" "+reception.CitizenSet.FirstName+" "+reception.CitizenSet.MiddleName,
                        reception.service,reception.date,
                        reception.idStaff.ToString(), reception.StaffSet.LastName+" "+reception.StaffSet.FirstName+" "+reception.StaffSet.MiddleName, reception.EmployerSet.Email
                    });
                item.Tag = reception;
                listViewReception.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewReception.SelectedItems.Count==1)
            {
                ReceptionSet reception = listViewReception.SelectedItems[0].Tag as ReceptionSet;
                reception.idCitizen = Convert.ToInt32(comboBoxCitizen.SelectedItem.ToString().Split('.')[0]);
                reception.idStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                reception.service = textBoxService.Text;
                reception.date = textBoxDate.Text;
                reception.idEmployer = Convert.ToInt32(comboBoxEmployer.SelectedItem.ToString().Split('.')[0]);
                Program.znt.SaveChanges();
                ShowReception();
            }
        }

        private void listViewReception_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReception.SelectedItems.Count==1)
            {
                ReceptionSet reception = listViewReception.SelectedItems[0].Tag as ReceptionSet;
                comboBoxCitizen.SelectedIndex = comboBoxCitizen.FindString(reception.idCitizen.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(reception.idStaff.ToString());
                textBoxService.Text = reception.service;
                textBoxDate.Text = reception.date;
                comboBoxEmployer.SelectedIndex = comboBoxEmployer.FindString(reception.idEmployer.ToString());
            }
            else
            {
                comboBoxCitizen.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxService.Text = "";
                textBoxDate.Text = "";
                comboBoxEmployer.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReception.SelectedItems.Count==1)
                {
                    ReceptionSet reception = listViewReception.SelectedItems[0].Tag as ReceptionSet;
                    Program.znt.ReceptionSet.Remove(reception);
                    Program.znt.SaveChanges();
                    ShowReception();
                }
                comboBoxCitizen.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxService.Text = "";
                textBoxDate.Text = "";
                comboBoxEmployer.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReception_Load(object sender, EventArgs e)
        {

        }
    }
}
