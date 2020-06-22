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
    public partial class FormPay : Form
    {
        public FormPay()
        {
            InitializeComponent();
            ShowPay();
            ShowCitizen();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPay.SelectedItems.Count == 1)
            {
                PaySet pay = listViewPay.SelectedItems[0].Tag as PaySet;
                pay.idCitizen = Convert.ToInt32(comboBoxCitizen.SelectedItem.ToString().Split('.')[0]);
                pay.Type = comboBoxType.Text;
                pay.Date = textBoxDate.Text;
                Program.znt.SaveChanges();
                ShowPay();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCitizen.SelectedItem != null && comboBoxType.SelectedItem != null && textBoxDate.Text != "")
            {
                PaySet pay = new PaySet();
                pay.idCitizen = Convert.ToInt32(comboBoxCitizen.SelectedItem.ToString().Split('.')[0]);
                pay.Type = comboBoxType.Text;
                pay.Date = textBoxDate.Text;
                Program.znt.PaySet.Add(pay);
                Program.znt.SaveChanges();
                ShowPay();
            }
            else MessageBox.Show("Выберите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowPay()
        {
            listViewPay.Items.Clear();
            foreach (PaySet pay in Program.znt.PaySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        pay.idCitizen.ToString(), pay.CitizenSet.LastName+" "+pay.CitizenSet.FirstName+" "+pay.CitizenSet.MiddleName,pay.CitizenSet.Status,
                        pay.Type,pay.Date
                    });
                item.Tag = pay;
                listViewPay.Items.Add(item);
            }
        }

        private void listViewPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPay.SelectedItems.Count == 1)
            {
                PaySet pay = listViewPay.SelectedItems[0].Tag as PaySet;
                comboBoxCitizen.SelectedIndex = comboBoxCitizen.FindString(pay.idCitizen.ToString());
                comboBoxType.Text = pay.Type;
                textBoxDate.Text = pay.Date;
            }
            else
            {
                comboBoxCitizen.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                textBoxDate.Text = "";
            }
        }
        void ShowCitizen()
        {
            comboBoxCitizen.Items.Clear();
            foreach (CitizenSet citizenSet in Program.znt.CitizenSet)
            {
                string[] item = { citizenSet.id.ToString() + ".", citizenSet.FirstName, citizenSet.MiddleName, citizenSet.LastName, citizenSet.Status };
                comboBoxCitizen.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPay.SelectedItems.Count == 1)
                {
                    PaySet pay = listViewPay.SelectedItems[0].Tag as PaySet;
                    Program.znt.PaySet.Remove(pay);
                    Program.znt.SaveChanges();
                    ShowPay();
                }
                comboBoxCitizen.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
