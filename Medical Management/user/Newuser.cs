using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Management.user
{
    public partial class Newuser : Form
    {
        public Newuser()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcom;
        private void Newuser_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=.;Initial Catalog=Medicalmanagement;Integrated security=SSPI";
            objcon = new SqlConnection(constr);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            objcom = new SqlCommand("insert into Login (username,Password) values('"+txtusername.Text+"','"+txtpassword.Text+"')",objcon);
            objcon.Open();
            objcom.ExecuteNonQuery();
            objcon.Close();
            MessageBox.Show("New User Added");
            this.Close();
        }
    }
}
