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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objapt;
        DataTable objdt;
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            string constr =@"data source=.; Initial catalog=Medicalmanagement;integrated security=sspi";
            objcon = new SqlConnection(constr);
            txtoldpass.Enabled = false;
        }

        private void cmbusername_Click(object sender, EventArgs e)
        {
            cmbusername.Items.Clear();
            objapt =new SqlDataAdapter("select * from Login",objcon);
            objdt = new DataTable();
            objapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows) 
            {
                cmbusername.Items.Add(dr["Username"].ToString());
            }
        }

        private void cmbusername_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtoldpass.Text =objdt.Rows[cmbusername.SelectedIndex]["password"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbusername.SelectedIndex == -1)
            {
                MessageBox.Show("Choose username to change password");
            }
            else
            {
                if (txtnewpass.Text != txtconfirmpass.Text)
                {
                    MessageBox.Show("Confirm password does't match new password");
                    txtconfirmpass.Text = "";
                    txtconfirmpass.Focus();
                }
                else
                {
                    if (txtnewpass.Text == txtconfirmpass.Text)
                    {
                        objcon.Open();
                        objcomm = new SqlCommand("update Login set Password='"+txtnewpass.Text+"' where Username='"+cmbusername.Text+"'",objcon);
                        objcomm.ExecuteNonQuery();
                        objcon.Close();
                        MessageBox.Show("Password Changed");
                        txtconfirmpass.Text = "";
                        txtnewpass.Text = "";
                        txtoldpass.Text = "";
                        txtpasshint.Text = "";
                        cmbusername.Text="";
                        cmbusername.Focus();
                    }
                }
            }
        }
    }
}
