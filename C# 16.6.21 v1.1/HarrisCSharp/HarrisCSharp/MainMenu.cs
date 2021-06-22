//Version 1.1. Date Created: 16.6.21. Changes: User Interface created, Button functionality added to perform CRUD.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisCSharp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void personalbtn_Click(object sender, EventArgs e)
        {
            PersonalEditor personal = new PersonalEditor();
            personal.Show();
        }

        private void businessbtn_Click(object sender, EventArgs e)
        {
            BusinessEditor business = new BusinessEditor();
            business.Show();
        }
    }
}
