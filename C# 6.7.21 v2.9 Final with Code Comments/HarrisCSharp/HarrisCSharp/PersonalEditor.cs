using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HarrisCSharp
{
    public partial class PersonalEditor : Form
    {

        //Initialise DbConn for database connection
        DbConn dbConn = new DbConn();

        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            //Upon load, initiate the selectAllPersonal stored procedure to get all records in the Personal table of the database.
            personaldgv.DataSource = dbConn.selectAllPersonal();
        }

        private void RefreshPersonalbtn_Click(object sender, EventArgs e)
        {
            personaldgv.DataSource = dbConn.selectAllPersonal();
            updateselectedpersonalbtn.Enabled = true;
            addnewpersonalbtn.Enabled = true;
            deleteselectedpersonalbtn.Enabled = true;
            refreshpersonalbtn.Enabled = true;
            //When Refresh button presed, initialise selectAllPersonal stored procedure to get all records in the Personal table of the database.
        }

        private void personaldgv_CellClick(object sender, EventArgs e)
        {
            //When a record in DataGridView is clicked on, each data field value populates the corresponding textbox.
            int index = Int32.Parse(personaldgv.SelectedCells[0].Value.ToString());
            personalfnametxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personallnametxb.Text = personaldgv.SelectedCells[2].Value.ToString();
            personalphonetxb.Text = personaldgv.SelectedCells[3].Value.ToString();
            personalemailtxb.Text = personaldgv.SelectedCells[4].Value.ToString();
            personaladdrline1txb.Text = personaldgv.SelectedCells[5].Value.ToString();
            personaladdrline2txb.Text = personaldgv.SelectedCells[6].Value.ToString();
            personalcitytxb.Text = personaldgv.SelectedCells[7].Value.ToString();
            personalpostcodetxb.Text = personaldgv.SelectedCells[8].Value.ToString();
        }

        private void personaldgv_SelectionChanged(object sender, EventArgs e)
        {
            //When a record in DataGridView is clicked on, each data field value populates the corresponding textbox.
            int index = Int32.Parse(personaldgv.SelectedCells[0].Value.ToString());
            personalfnametxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personallnametxb.Text = personaldgv.SelectedCells[2].Value.ToString();
            personalphonetxb.Text = personaldgv.SelectedCells[3].Value.ToString();
            personalemailtxb.Text = personaldgv.SelectedCells[4].Value.ToString();
            personaladdrline1txb.Text = personaldgv.SelectedCells[5].Value.ToString();
            personaladdrline2txb.Text = personaldgv.SelectedCells[6].Value.ToString();
            personalcitytxb.Text = personaldgv.SelectedCells[7].Value.ToString();
            personalpostcodetxb.Text = personaldgv.SelectedCells[8].Value.ToString();
        }
        private void addpersonalbtn_Click(object sender, EventArgs e)
        {
            //When addpersonalbtn button clicked, set the values of PersonalContact class variables to the value of the corresponding textbox. Then run the InsertPersonal stored procedure.
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactFName = personalfnametxb.Text;
            personalContact.ContactLName = personallnametxb.Text;
            personalContact.ContactPersonalTel = personalphonetxb.Text;
            personalContact.ContactEmail = personalemailtxb.Text;
            personalContact.ContactAddr1 = personaladdrline1txb.Text;
            personalContact.ContactAddr2 = personaladdrline2txb.Text;
            personalContact.ContactCity = personalcitytxb.Text;
            personalContact.ContactPostcode = personalpostcodetxb.Text;
            dbConn.InsertPersonal(personalContact);

            ///Disable all textboxes and buttons except for refreshpersonalbtn button.
            personalfnametxb.Enabled = false;
            personallnametxb.Enabled = false;
            personalphonetxb.Enabled = false;
            personalemailtxb.Enabled = false;
            personaladdrline1txb.Enabled = false;
            personaladdrline2txb.Enabled = false;
            personalcitytxb.Enabled = false;
            personalpostcodetxb.Enabled = false;

            savenewpersonalbtn.Enabled = false;
            updateselectedpersonalbtn.Enabled = false;
            saveselectedpersonaldbtn.Enabled = false;
            deleteselectedpersonalbtn.Enabled = false;
            addnewpersonalbtn.Enabled = false;
            savenewpersonalbtn.Enabled = false;
            refreshpersonalbtn.Enabled = true;
            cancelbtn.Enabled = false;

            //Enpty the value of all textboxes.
            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;

            // Code to auto-refresh table.
            personaldgv.DataSource = dbConn.selectAllPersonal();

            //Set the value of the statuslbl to -
            statuslbl.Text = "-";
        }

        private void updatepersonalbtn_Click(object sender, EventArgs e)
        {
            //When updatepersonalbtn button clicked, set the value of the PersonalContact class variables to the values of the corresponding textboxes.
            //Then run UpdatePersonal stored procedure. Then repopulate the DataGridiew by using the selectAllPersonal stored procedure.
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactFName = personalfnametxb.Text;
            personalContact.ContactLName = personallnametxb.Text;
            personalContact.ContactPersonalTel = personalphonetxb.Text;
            personalContact.ContactEmail = personalemailtxb.Text;
            personalContact.ContactAddr1 = personaladdrline1txb.Text;
            personalContact.ContactAddr2 = personaladdrline2txb.Text;
            personalContact.ContactCity = personalcitytxb.Text;
            personalContact.ContactPostcode = personalpostcodetxb.Text;
            dbConn.UpdatePersonal(personalContact);
            personaldgv.DataSource = dbConn.selectAllPersonal();
            int index = Int32.Parse(personaldgv.SelectedCells[0].Value.ToString());

            //Enable all textboxes and relevant buttons.
            personalfnametxb.Enabled = true;
            personallnametxb.Enabled = true;
            personalphonetxb.Enabled = true;
            personalemailtxb.Enabled = true;
            personaladdrline1txb.Enabled = true;
            personaladdrline2txb.Enabled = true;
            personalcitytxb.Enabled = true;
            personalpostcodetxb.Enabled = true;

            updateselectedpersonalbtn.Enabled = false;
            saveselectedpersonaldbtn.Enabled = true;
            deleteselectedpersonalbtn.Enabled = false;
            addnewpersonalbtn.Enabled = false;
            savenewpersonalbtn.Enabled = false;
            refreshpersonalbtn.Enabled = false;
            cancelbtn.Enabled = true;
            //Set statuslbl label value to inform the user that they are updating a contact.
            statuslbl.Text = "You are updating an existing contact";
        }

        private void deletepersonalbtn_Click(object sender, EventArgs e)
        {
            //Run the DeletePersonal stored procedure after a confirmation message is displayed and yes is selected.
            string message = "Are you sure?";
            string caption = "Are you sure you want to delete the selected contact?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbConn.DeletePersonal(Int32.Parse(personaldgv.SelectedCells[0].Value.ToString()));

                personaldgv.DataSource = dbConn.selectAllPersonal();
            }
            statuslbl.Text = "-";
        }

        private void addnewpersonalbtn_Click(object sender, EventArgs e)
        {
            //Clear and enable the textboxes and relevant buttons ready for adding a new contact.
            personalfnametxb.Enabled = true;
            personallnametxb.Enabled = true;
            personalphonetxb.Enabled = true;
            personalemailtxb.Enabled = true;
            personaladdrline1txb.Enabled = true;
            personaladdrline2txb.Enabled = true;
            personalcitytxb.Enabled = true;
            personalpostcodetxb.Enabled = true;

            savenewpersonalbtn.Enabled = true;
            updateselectedpersonalbtn.Enabled = false;
            saveselectedpersonaldbtn.Enabled = false;
            deleteselectedpersonalbtn.Enabled = false;
            addnewpersonalbtn.Enabled = false;
            savenewpersonalbtn.Enabled = true;
            refreshpersonalbtn.Enabled = false;
            cancelbtn.Enabled = true;

            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;
            //Set the value of statuslbl label to inform the user that they are adding a new contact.
            statuslbl.Text = "You are adding a new contact";
        }

        private void saveselectedpersonaldbtn_Click(object sender, EventArgs e)
        {
            //Preare for saving a contact to the database by setting the values of personalContact class to the values of the textboxes. Disable all buttons except for Update and AddNew. Then clear the textboxes.
            int index = Int32.Parse(personaldgv.SelectedCells[0].Value.ToString());
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactID = index;
            personalContact.ContactFName = personalfnametxb.Text;
            personalContact.ContactLName = personallnametxb.Text;
            personalContact.ContactPersonalTel = personalphonetxb.Text;
            personalContact.ContactEmail = personalemailtxb.Text;
            personalContact.ContactAddr1 = personaladdrline1txb.Text;
            personalContact.ContactAddr2 = personaladdrline2txb.Text;
            personalContact.ContactCity = personalcitytxb.Text;
            personalContact.ContactPostcode = personalpostcodetxb.Text;
            //Run the UpdatePersonal stored procedure.
            dbConn.UpdatePersonal(personalContact);
            //Repopulate the values in personaldgv data grid view using the selectAllPersonal stored procedure.
            personaldgv.DataSource = dbConn.selectAllPersonal();

            //Disable all textboxes.
            personalfnametxb.Enabled = false;
            personallnametxb.Enabled = false;
            personalphonetxb.Enabled = false;
            personalemailtxb.Enabled = false;
            personaladdrline1txb.Enabled = false;
            personaladdrline2txb.Enabled = false;
            personalcitytxb.Enabled = false;
            personalpostcodetxb.Enabled = false;

            //Disable all buttons except for refresh button to prompt the user to click refresh.
            savenewpersonalbtn.Enabled = false;
            updateselectedpersonalbtn.Enabled = false;
            saveselectedpersonaldbtn.Enabled = false;
            deleteselectedpersonalbtn.Enabled = false;
            addnewpersonalbtn.Enabled = false;
            savenewpersonalbtn.Enabled = false;
            refreshpersonalbtn.Enabled = true;
            cancelbtn.Enabled = false;

            //Empty the value of all textboxes and set the statuslbl label value to -.
            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;
            statuslbl.Text = "-";
        }

        private void personaldgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //When personaldgv DataGridView is clicked, the seleted record values are converted to String.
            DataGridViewRow row = this.personaldgv.Rows[e.RowIndex];

            personalfnametxb.Text = row.Cells[1].Value.ToString();
            personallnametxb.Text = row.Cells[2].Value.ToString();
            personalemailtxb.Text = row.Cells[3].Value.ToString();
            personaladdrline1txb.Text = row.Cells[4].Value.ToString();
            personaladdrline2txb.Text = row.Cells[5].Value.ToString();
            personalcitytxb.Text = row.Cells[6].Value.ToString();
            personalpostcodetxb.Text = row.Cells[7].Value.ToString();
            personalphonetxb.Text = row.Cells[8].Value.ToString();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            //Cancel the adding or updating of a contact by clearing the value of the textboxes and resetting the buttons enabled.
            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;

            savenewpersonalbtn.Enabled = true;
            updateselectedpersonalbtn.Enabled = true;
            saveselectedpersonaldbtn.Enabled = false;
            deleteselectedpersonalbtn.Enabled = true;
            addnewpersonalbtn.Enabled = true;
            savenewpersonalbtn.Enabled = false;
            refreshpersonalbtn.Enabled = true;
            statuslbl.Text = "-";
        }
    }
}
