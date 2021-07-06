﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HarrisCSharp
{
    public partial class BusinessEditor : Form
    {

        DbConn dbConn = new DbConn();

        public BusinessEditor()
        {
            InitializeComponent();
        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            businessdgv.DataSource = dbConn.selectAllBusiness();
        }

        private void RefreshBusinessbtn_Click(object sender, EventArgs e)
        {
            businessdgv.DataSource = dbConn.selectAllBusiness();
        }

        private void businessdgv_CellClick(object sender, EventArgs e)
        {
            int index = Int32.Parse(businessdgv.SelectedCells[0].Value.ToString());
            businessfnametxb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businesslnametxb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businessphonetxb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businessemailtxb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businessaddrline1txb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businessaddrline2txb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businesscitytxb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businesspostcodetxb.Text = businessdgv.SelectedCells[1].Value.ToString();
        }

        private void businessdgv_SelectionChanged(object sender, EventArgs e)
        {
            int index = Int32.Parse(businessdgv.SelectedCells[0].Value.ToString());
            businessfnametxb.Text = businessdgv.SelectedCells[1].Value.ToString();
            businesslnametxb.Text = businessdgv.SelectedCells[2].Value.ToString();
            businessphonetxb.Text = businessdgv.SelectedCells[3].Value.ToString();
            businessemailtxb.Text = businessdgv.SelectedCells[4].Value.ToString();
            businessaddrline1txb.Text = businessdgv.SelectedCells[5].Value.ToString();
            businessaddrline2txb.Text = businessdgv.SelectedCells[6].Value.ToString();
            businesscitytxb.Text = businessdgv.SelectedCells[7].Value.ToString();
            businesspostcodetxb.Text = businessdgv.SelectedCells[8].Value.ToString();
        }

        private void addbusinessbtn_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactFName = businessfnametxb.Text;
            businessContact.ContactLName = businesslnametxb.Text;
            businessContact.ContactBusinessTel = businessphonetxb.Text;
            businessContact.ContactEmail = businessemailtxb.Text;
            businessContact.ContactAddr1 = businessaddrline1txb.Text;
            businessContact.ContactAddr2 = businessaddrline2txb.Text;
            businessContact.ContactCity = businesscitytxb.Text;
            businessContact.ContactPostcode = businesspostcodetxb.Text;
            dbConn.InsertBusiness(businessContact);

            businessfnametxb.Enabled = false;
            businesslnametxb.Enabled = false;
            businessphonetxb.Enabled = false;
            businessemailtxb.Enabled = false;
            businessaddrline1txb.Enabled = false;
            businessaddrline2txb.Enabled = false;
            businesscitytxb.Enabled = false;
            businesspostcodetxb.Enabled = false;
            savenewbusinessbtn.Enabled = false;
            updateselectedbusinessbtn.Enabled = true;
            saveselectedbusinessbtn.Enabled = false;
            deleteselectedbusinessbtn.Enabled = true;
            addnewbusinessbtn.Enabled = true;
            savenewbusinessbtn.Enabled = false;

            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;
            businessdgv.DataSource = dbConn.selectAllBusiness();
            statuslbl.Text = "-";
        }

        private void updatebusinessbtn_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactFName = businessfnametxb.Text;
            businessContact.ContactLName = businesslnametxb.Text;
            businessContact.ContactBusinessTel = businessphonetxb.Text;
            businessContact.ContactEmail = businessemailtxb.Text;
            businessContact.ContactAddr1 = businessaddrline1txb.Text;
            businessContact.ContactAddr2 = businessaddrline2txb.Text;
            businessContact.ContactCity = businesscitytxb.Text;
            businessContact.ContactPostcode = businesspostcodetxb.Text;
            dbConn.UpdateBusiness(businessContact);
            businessdgv.DataSource = dbConn.selectAllBusiness();
            int index = Int32.Parse(businessdgv.SelectedCells[0].Value.ToString());

            businessfnametxb.Enabled = true;
            businesslnametxb.Enabled = true;
            businessphonetxb.Enabled = true;
            businessemailtxb.Enabled = true;
            businessaddrline1txb.Enabled = true;
            businessaddrline2txb.Enabled = true;
            businesscitytxb.Enabled = true;
            businesspostcodetxb.Enabled = true;
            savenewbusinessbtn.Enabled = false;
            updateselectedbusinessbtn.Enabled = false;
            saveselectedbusinessbtn.Enabled = true;
            deleteselectedbusinessbtn.Enabled = false;
            addnewbusinessbtn.Enabled = false;
            savenewbusinessbtn.Enabled = false;
            cancelbtn.Enabled = true;
            statuslbl.Text = "You are updating an existing contact";
        }

        private void deletebusinessbtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Are you sure you want to delete the selected contact?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbConn.DeleteBusiness(Int32.Parse(businessdgv.SelectedCells[0].Value.ToString()));

                businessdgv.DataSource = dbConn.selectAllBusiness();
            }
            statuslbl.Text = "-";
        }

        private void addnewbusinessbtn_Click(object sender, EventArgs e)
        {
            businessfnametxb.Enabled = true;
            businesslnametxb.Enabled = true;
            businessphonetxb.Enabled = true;
            businessemailtxb.Enabled = true;
            businessaddrline1txb.Enabled = true;
            businessaddrline2txb.Enabled = true;
            businesscitytxb.Enabled = true;
            businesspostcodetxb.Enabled = true;
            savenewbusinessbtn.Enabled = true;
            updateselectedbusinessbtn.Enabled = false;
            saveselectedbusinessbtn.Enabled = false;
            deleteselectedbusinessbtn.Enabled = false;
            addnewbusinessbtn.Enabled = false;
            savenewbusinessbtn.Enabled = true;
            cancelbtn.Enabled = true;
            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;
            statuslbl.Text = "You are adding a new contact";
        }

        private void saveselectedbusinessbtn_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(businessdgv.SelectedCells[0].Value.ToString());
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactID = index;
            businessContact.ContactFName = businessfnametxb.Text;
            businessContact.ContactLName = businesslnametxb.Text;
            businessContact.ContactBusinessTel = businessphonetxb.Text;
            businessContact.ContactEmail = businessemailtxb.Text;
            businessContact.ContactAddr1 = businessaddrline1txb.Text;
            businessContact.ContactAddr2 = businessaddrline2txb.Text;
            businessContact.ContactCity = businesscitytxb.Text;
            businessContact.ContactPostcode = businesspostcodetxb.Text;
            dbConn.UpdateBusiness(businessContact);
            businessdgv.DataSource = dbConn.selectAllBusiness();
            businessfnametxb.Enabled = false;
            businesslnametxb.Enabled = false;
            businessphonetxb.Enabled = false;
            businessemailtxb.Enabled = false;
            businessaddrline1txb.Enabled = false;
            businessaddrline2txb.Enabled = false;
            businesscitytxb.Enabled = false;
            businesspostcodetxb.Enabled = false;
            savenewbusinessbtn.Enabled = false;
            updateselectedbusinessbtn.Enabled = true;
            saveselectedbusinessbtn.Enabled = false;
            deleteselectedbusinessbtn.Enabled = true;
            addnewbusinessbtn.Enabled = true;
            savenewbusinessbtn.Enabled = false;
            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;
            statuslbl.Text = "-";
        }

        private void businessdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.businessdgv.Rows[e.RowIndex];

            businessfnametxb.Text = row.Cells[1].Value.ToString();
            businesslnametxb.Text = row.Cells[2].Value.ToString();
            businessemailtxb.Text = row.Cells[3].Value.ToString();
            businessaddrline1txb.Text = row.Cells[4].Value.ToString();
            businessaddrline2txb.Text = row.Cells[5].Value.ToString();
            businesscitytxb.Text = row.Cells[6].Value.ToString();
            businesspostcodetxb.Text = row.Cells[7].Value.ToString();
            businessphonetxb.Text = row.Cells[8].Value.ToString();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;

            savenewbusinessbtn.Enabled = true;
            updateselectedbusinessbtn.Enabled = true;
            saveselectedbusinessbtn.Enabled = false;
            deleteselectedbusinessbtn.Enabled = true;
            addnewbusinessbtn.Enabled = true;
            savenewbusinessbtn.Enabled = false;
            statuslbl.Text = "-";
        }
    }
}
