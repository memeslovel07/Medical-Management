using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
             SqlDataAdapter objadt = new SqlDataAdapter("select * from login where username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", objcon);
            DataTable objdt = new DataTable();
            objadt.Fill(objdt);
            if(txtusername.Text=="")
            {
                MessageBox.Show(" Enter  Username");
                txtusername.Focus();
            }
           else if (objdt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome");
                Mainpage homemenu = new Mainpage();
                homemenu.Show();
               
            }
            
            else
            {
                MessageBox.Show("Invalid User");
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection objcon;
        private void Login_Load(object sender, EventArgs e)
        {
            String constr = @"Data Source=.;Initial Catalog=Medicalmanagement;Integrated security=SSPI";
            objcon = new SqlConnection(constr);
        }
    }
}
