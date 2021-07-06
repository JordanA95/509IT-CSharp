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
            personaldgv.DataSource = dbConn.selectAllPersonal();
        }

        private void RefreshPersonalbtn_Click(object sender, EventArgs e)
        {
            personaldgv.DataSource = dbConn.selectAllPersonal();
        }

        private void personaldgv_CellClick(object sender, EventArgs e)
        {
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
        // code to tell button to take take text from respective fields and add data to database
        private void addpersonalbtn_Click(object sender, EventArgs e)
        {
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

            // Code to Enable/Disable the textboxes once button has been clicked
            personalfnametxb.Enabled = false;
            personallnametxb.Enabled = false;
            personalphonetxb.Enabled = false;
            personalemailtxb.Enabled = false;
            personaladdrline1txb.Enabled = false;
            personaladdrline2txb.Enabled = false;
            personalcitytxb.Enabled = false;
            personalpostcodetxb.Enabled = false;
            //Code to Enable/Disable buttons
            savenewpersonalbtn.Enabled = false;
            updateselectedpersonalbtn.Enabled = true;
            saveselectedpersonaldbtn.Enabled = false;
            deleteselectedpersonalbtn.Enabled = true;
            addnewpersonalbtn.Enabled = true;
            savenewpersonalbtn.Enabled = false;
            //Code to Empty the text boxes once the fields have been added
            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;

            // Code to auto-refresh table
            personaldgv.DataSource = dbConn.selectAllPersonal();

            statuslbl.Text = "-";
        }

        private void updatepersonalbtn_Click(object sender, EventArgs e)
        {
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
            statuslbl.Text = "You are updating an existing contact";
        }

        private void deletepersonalbtn_Click(object sender, EventArgs e)
        {
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
            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;
            statuslbl.Text = "You are adding a new contact";
        }

        private void saveselectedpersonaldbtn_Click(object sender, EventArgs e)
        {
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
            dbConn.UpdatePersonal(personalContact);
            personaldgv.DataSource = dbConn.selectAllPersonal();
            personalfnametxb.Enabled = false;
            personallnametxb.Enabled = false;
            personalphonetxb.Enabled = false;
            personalemailtxb.Enabled = false;
            personaladdrline1txb.Enabled = false;
            personaladdrline2txb.Enabled = false;
            personalcitytxb.Enabled = false;
            personalpostcodetxb.Enabled = false;
            savenewpersonalbtn.Enabled = false;
            updateselectedpersonalbtn.Enabled = true;
            saveselectedpersonaldbtn.Enabled = false;
            deleteselectedpersonalbtn.Enabled = true;
            addnewpersonalbtn.Enabled = true;
            savenewpersonalbtn.Enabled = false;
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
            statuslbl.Text = "-";
        }
    }
}
