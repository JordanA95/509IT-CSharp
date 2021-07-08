//Version 1.2. Date Created: 16.6.21. Changes: Added Asynchronous programming functionality with async and await commands in DbConn.
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

        //Button to open the PersonalEditor form.
        private void personalbtn_Click(object sender, EventArgs e)
        {
            PersonalEditor personal = new PersonalEditor();
            personal.Show();
        }

        //Button to open the BusinessEditor form.
        private void businessbtn_Click(object sender, EventArgs e)
        {
            BusinessEditor business = new BusinessEditor();
            business.Show();
        }
    }
}
