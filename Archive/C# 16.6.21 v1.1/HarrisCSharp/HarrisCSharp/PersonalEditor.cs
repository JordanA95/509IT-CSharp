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

        DbConn dbConn = new DbConn();

        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            personaldgv.DataSource = dbConn.GetAllPersonal();
        }

        private void RefreshPersonalbtn_Click(object sender, EventArgs e)
        {
            personaldgv.DataSource = dbConn.GetAllPersonal();
        }

        private void personaldgv_CellClick(object sender, EventArgs e)
        {
            int index = Int32.Parse(personaldgv.SelectedCells[0].Value.ToString());
            personalfnametxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personallnametxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personalphonetxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personalemailtxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personaladdrline1txb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personaladdrline2txb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personalcitytxb.Text = personaldgv.SelectedCells[1].Value.ToString();
            personalpostcodetxb.Text = personaldgv.SelectedCells[1].Value.ToString();
        }
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
            personaldgv.DataSource = dbConn.GetAllPersonal();

            personalfnametxb.Text = string.Empty;
            personallnametxb.Text = string.Empty;
            personalphonetxb.Text = string.Empty;
            personalemailtxb.Text = string.Empty;
            personaladdrline1txb.Text = string.Empty;
            personaladdrline2txb.Text = string.Empty;
            personalcitytxb.Text = string.Empty;
            personalpostcodetxb.Text = string.Empty;
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
            dbConn.InsertPersonal(personalContact);
            personaldgv.DataSource = dbConn.GetAllPersonal();

            int index = Int32.Parse(personaldgv.SelectedCells[0].Value.ToString());
            BusinessContact BusinessContact = new BusinessContact();
            personalContact.ContactID = index;
            personalContact.ContactFName = personalfnametxb.Text;
            personalContact.ContactLName = personallnametxb.Text;
            personalContact.ContactPersonalTel = personalphonetxb.Text;
            personalContact.ContactEmail = personalemailtxb.Text;
            personalContact.ContactAddr1 = personaladdrline1txb.Text;
            personalContact.ContactAddr2 = personaladdrline2txb.Text;
            personalContact.ContactCity = personalcitytxb.Text;
            personalContact.ContactPostcode = personalpostcodetxb.Text;
            dbConn.UpdatePersonal(PersonalContact);
            personaldgv.DataSource = dbConn.GetAllPersonal();
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

                personaldgv.DataSource = dbConn.GetAllPersonal();
            }
        }
    }
}
