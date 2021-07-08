using System;
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
            businessdgv.DataSource = dbConn.GetAllBusiness();
        }

        private void RefreshBusinessbtn_Click(object sender, EventArgs e)
        {
            businessdgv.DataSource = dbConn.GetAllBusiness();
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
            businessdgv.DataSource = dbConn.GetAllPersonal();

            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;
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
            dbConn.InsertBusiness(businessContact);
            businessdgv.DataSource = dbConn.GetAllPersonal();

            int index = Int32.Parse(businessdgv.SelectedCells[0].Value.ToString());
            BusinessContact BusinessContact = new BusinessContact();
            businessContact.ContactID = index;
            businessContact.ContactFName = businessfnametxb.Text;
            businessContact.ContactLName = businesslnametxb.Text;
            businessContact.ContactBusinessTel = businessphonetxb.Text;
            businessContact.ContactEmail = businessemailtxb.Text;
            businessContact.ContactAddr1 = businessaddrline1txb.Text;
            businessContact.ContactAddr2 = businessaddrline2txb.Text;
            businessContact.ContactCity = businesscitytxb.Text;
            businessContact.ContactPostcode = businesspostcodetxb.Text;
            //dbConn.UpdatePersonal(BusinessContact);
            businessdgv.DataSource = dbConn.GetAllPersonal();
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

                businessdgv.DataSource = dbConn.GetAllPersonal();
            }
        }
    }
}
