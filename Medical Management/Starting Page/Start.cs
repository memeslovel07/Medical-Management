using Medical_Management.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Management.Starting_Page
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void linkextist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            
        }
        
        private void linkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Newuser newuser = new Newuser();
            newuser.Show();
        }

    
    }
}
