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
        //Initialise DbConn Class for database connection
        DbConn dbConn = new DbConn();

        public BusinessEditor()
        {
            InitializeComponent();
        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            //Upon load, initiate the selectAllBusiness stored procedure to get all records in the Business table of the database.
            businessdgv.DataSource = dbConn.selectAllBusiness();
        }

        private void RefreshBusinessbtn_Click(object sender, EventArgs e)
        {
            //When Refresh button presed, initialise selectAllBusiness stored procedure to get all records in the Business table of the database.
            businessdgv.DataSource = dbConn.selectAllBusiness();
            updateselectedbusinessbtn.Enabled = true;
            addnewbusinessbtn.Enabled = true;
            deleteselectedbusinessbtn.Enabled = true;
            refreshbusinessbtn.Enabled = true;
        }

        private void businessdgv_CellClick(object sender, EventArgs e)
        {
            //When a record in DataGridView is clicked on, each data field value populates the corresponding textbox.
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
            //When a record in DataGridView is clicked on, each data field value populates the corresponding textbox.
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
            //When addbusinessbtn button clicked, set the values of BusinessContact class variables to the value of the corresponding textbox. Then run the InsertBusiness stored procedure.
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

            //Disable all textboxes and buttons except for refreshbusinessbtn button.
            businessfnametxb.Enabled = false;
            businesslnametxb.Enabled = false;
            businessphonetxb.Enabled = false;
            businessemailtxb.Enabled = false;
            businessaddrline1txb.Enabled = false;
            businessaddrline2txb.Enabled = false;
            businesscitytxb.Enabled = false;
            businesspostcodetxb.Enabled = false;

            savenewbusinessbtn.Enabled = false;
            updateselectedbusinessbtn.Enabled = false;
            saveselectedbusinessbtn.Enabled = false;
            deleteselectedbusinessbtn.Enabled = false;
            addnewbusinessbtn.Enabled = false;
            savenewbusinessbtn.Enabled = false;
            refreshbusinessbtn.Enabled = true;
            cancelbtn.Enabled = false;

            //Empty the value of all textboxes.
            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;
            
            //Code to auto-refresh table.
            businessdgv.DataSource = dbConn.selectAllBusiness();

            //Set the value of the statuslbl to -
            statuslbl.Text = "-";
        }

        private void updatebusinessbtn_Click(object sender, EventArgs e)
        {
            //When updatebusinessbtn button clicked, set the value of the BusinessContact class variables to the values of the corresponding textboxes.
            //Then run UpdateBusiness stored procedure. Then repopulate the DataGridiew by using the selectAllBusiness stored procedure.
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

            //Enable all textboxes and relevant buttons.
            businessfnametxb.Enabled = true;
            businesslnametxb.Enabled = true;
            businessphonetxb.Enabled = true;
            businessemailtxb.Enabled = true;
            businessaddrline1txb.Enabled = true;
            businessaddrline2txb.Enabled = true;
            businesscitytxb.Enabled = true;
            businesspostcodetxb.Enabled = true;

            updateselectedbusinessbtn.Enabled = false;
            saveselectedbusinessbtn.Enabled = true;
            deleteselectedbusinessbtn.Enabled = false;
            addnewbusinessbtn.Enabled = false;
            savenewbusinessbtn.Enabled = false;
            refreshbusinessbtn.Enabled = false;
            cancelbtn.Enabled = true;
            //Set statuslbl label value to inform the user that they are updating a contact.
            statuslbl.Text = "You are updating an existing contact";
        }

        private void deletebusinessbtn_Click(object sender, EventArgs e)
        {
            //Run the DeleteBusiness stored procedure after a confirmation message is displayed and yes is selected.
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
            //Clear and enable the textboxes and relevant buttons ready for adding a new contact.
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
            refreshbusinessbtn.Enabled = false;
            cancelbtn.Enabled = true;

            businessfnametxb.Text = string.Empty;
            businesslnametxb.Text = string.Empty;
            businessphonetxb.Text = string.Empty;
            businessemailtxb.Text = string.Empty;
            businessaddrline1txb.Text = string.Empty;
            businessaddrline2txb.Text = string.Empty;
            businesscitytxb.Text = string.Empty;
            businesspostcodetxb.Text = string.Empty;
            //Set the value of statuslbl label to inform the user that they are adding a new contact.
            statuslbl.Text = "You are adding a new contact";
        }

        private void saveselectedbusinessbtn_Click(object sender, EventArgs e)
        {
            //Prepare for saving a contact to the database by setting the values of businessContact class to the values of the textboxes. Disable all buttons except for Update and AddNew. Then clear the textboxes.
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
            //Run the UpdateBusiness stored procedure.
            dbConn.UpdateBusiness(businessContact);
            //Repopulate the values in businessdgv data grid view using the selectAllBusiness stored procedure.
            businessdgv.DataSource = dbConn.selectAllBusiness();

            //Disable all textboxes.
            businessfnametxb.Enabled = false;
            businesslnametxb.Enabled = false;
            businessphonetxb.Enabled = false;
            businessemailtxb.Enabled = false;
            businessaddrline1txb.Enabled = false;
            businessaddrline2txb.Enabled = false;
            businesscitytxb.Enabled = false;
            businesspostcodetxb.Enabled = false;

            //Disable all buttons except for refresh button to prompt the user to click refresh.
            savenewbusinessbtn.Enabled = false;
            updateselectedbusinessbtn.Enabled = false;
            saveselectedbusinessbtn.Enabled = false;
            deleteselectedbusinessbtn.Enabled = false;
            addnewbusinessbtn.Enabled = false;
            savenewbusinessbtn.Enabled = false;
            refreshbusinessbtn.Enabled = true;
            cancelbtn.Enabled = false;

            //Empty the value of all textboxes and set the statuslbl label value to -.
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
            //When businessdgv DataGridView is clicked, the seleted record values are converted to String.
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
            //Cancel the adding or updating of a contact by clearing the value of the textboxes and resetting the buttons enabled.
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
            refreshbusinessbtn.Enabled = true;
            statuslbl.Text = "-";
        }
    }
}
