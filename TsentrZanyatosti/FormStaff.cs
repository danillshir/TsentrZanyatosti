﻿using System;
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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            ShowStaff();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StaffSet staffSet = new StaffSet();
            staffSet.FirstName = textBoxFirstName.Text;
            staffSet.LastName = textBoxLastName.Text;
            staffSet.MiddleName = textBoxMiddleName.Text;
            staffSet.Phone = textBoxPhone.Text;
            staffSet.Otdel = comboBoxOtdel.Text;
            Program.znt.StaffSet.Add(staffSet);
            Program.znt.SaveChanges();
            ShowStaff();
        }
        void ShowStaff()
        {
            listViewStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.znt.StaffSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    staffSet.id.ToString(), staffSet.FirstName, staffSet.LastName,staffSet.MiddleName,
                    staffSet.Phone, staffSet.Otdel
                    }
                    );
                item.Tag = staffSet;
                listViewStaff.Items.Add(item);

            }
            listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count == 1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                staffSet.FirstName = textBoxFirstName.Text;
                staffSet.LastName = textBoxLastName.Text;
                staffSet.MiddleName = textBoxMiddleName.Text;
                staffSet.Phone = textBoxPhone.Text;
                staffSet.Otdel = comboBoxOtdel.Text;
                Program.znt.SaveChanges();
                ShowStaff();
            }
        }

        private void listViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count == 1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                textBoxFirstName.Text = staffSet.FirstName;
                textBoxLastName.Text = staffSet.LastName;
                textBoxMiddleName.Text = staffSet.MiddleName;
                textBoxPhone.Text = staffSet.Phone;
                comboBoxOtdel.Text = staffSet.Otdel;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                comboBoxOtdel.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                    Program.znt.StaffSet.Remove(staffSet);
                    Program.znt.SaveChanges();
                    ShowStaff();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                comboBoxOtdel.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
