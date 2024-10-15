using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Management
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadt;
        DataTable objdt;
        private void Company_Load(object sender, EventArgs e)
        {
             String constr = @"data source=.; initial catalog=Medicalmanagement;integrated security=sspi";
            groupBox2.Enabled = false;
            groupBox3.Enabled = false; 
            objcon = new SqlConnection(constr); 
            cmbcomid.Visible= false;
            
           
        }
        string mode;

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode== "Add")
            {
objcomm = new SqlCommand("insert into Company(Companyid,Companyname,Address,Phonenumber,Email,Website) values('" + txtcomid.Text+"','"+txtname.Text+ "','"+txtaddress.Text+"','"+txtcontact.Text+"','"+txtemail.Text+"','"+txtwebsite.Text+"')", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One Record Inserted. ");
                txtcomid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtwebsite.Text = "";
                groupBox2.Enabled=false;
                groupBox3.Enabled=false;
            }
            if(mode=="Update")
            {
                objcomm = new SqlCommand("update Company set Address='" + txtaddress.Text + "',Phonenumber='"+txtcontact.Text+"',Email='"+txtemail.Text+"',Website='"+txtwebsite.Text+"' where Companyid='"+cmbcomid.Text+"'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Updated");
                objcon.Close();
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtwebsite.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcomid.Text = "";
                cmbcomid.Visible= false;
                txtcomid.Visible = true;

            }
            if(mode=="Delete")
            {
                objcomm = new SqlCommand("delete Company  where Companyid='" + cmbcomid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Recorded Delete");
                objcon.Close();
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtwebsite.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcomid.Text = "";
                cmbcomid.Visible = false;
                txtcomid.Visible = true;
                txtcomid.Visible = true;
                txtaddress.Visible = true;
                txtcontact.Visible = true;
                txtemail.Visible = true;
                txtwebsite.Visible = true;
                txtname.Enabled = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcomid.Visible = true;
            txtcomid.Visible = false;
        }

        private void cmbcomid_Click(object sender, EventArgs e)
        {
            cmbcomid.Items.Clear();
            objadt = new SqlDataAdapter("select * from Company", objcon);
            objdt = new DataTable();
            objadt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcomid.Items.Add(dr["Companyid"].ToString());
            }
        }

        private void cmbcomid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbcomid.SelectedIndex]["Companyname"].ToString();
            txtaddress.Text = objdt.Rows[cmbcomid.SelectedIndex]["Address"].ToString();
            txtcontact.Text = objdt.Rows[cmbcomid.SelectedIndex]["Phonenumber"].ToString();
            txtemail.Text = objdt.Rows[cmbcomid.SelectedIndex]["Email"].ToString();
            txtwebsite.Text = objdt.Rows[cmbcomid.SelectedIndex]["Website"].ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcomid.Visible = true;
            txtcomid.Visible = false;
            txtaddress.Visible = false;
            txtcontact.Visible = false;
            txtemail.Visible= false;
            txtwebsite.Visible= false;
            txtname.Enabled = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;

        }
    }
}
