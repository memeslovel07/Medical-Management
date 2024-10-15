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
using System.Runtime;
using System.Reflection.Emit;

namespace Medical_Management
{
    public partial class employee1 : Form
    {
        public employee1()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlDataAdapter objadpt;
        DataTable objdt;
        SqlConnection objcon;
        SqlCommand objcomm;
        private void employee1_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.; initial catalog=Medicalmanagement; integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cmbempid.Visible=false;
        }
        String mode;
        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox3.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(mode =="Add")
            {
                objcomm = new SqlCommand("insert into Employee(Employeeid,Name,Address,Phonenumber,Email,Designation,Salary) values('"+txtempid.Text+"','"+txtname.Text+"','"+txtaddress.Text+"','"+txtcontact.Text+"','"+txtemail.Text+"','"+txtdesig.Text+"','"+txtsalary.Text+"')", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One Record Inserted");
                txtempid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text ="";
                txtemail.Text = "";
                txtdesig.Text = "";
                txtsalary.Text = "";
                groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            }
            if (mode == "Update")
            {
                objcomm = new SqlCommand("update Employee set Address='"+txtaddress.Text+"',Phonenumber='"+txtcontact.Text+"',Email='"+txtemail.Text+"',Designation='"+txtdesig.Text+"',Salary='"+txtsalary.Text+"'",objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One Record Updated");
                txtempid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtdesig.Text = "";
                txtsalary.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbempid.Visible = false;
                txtempid.Visible = true;
            }
            if(mode =="Delete")
            {
                objcomm = new SqlCommand("delete Employee  where Employeeid='" + cmbempid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Recorded Delete");
                objcon.Close();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbempid.Visible = false;
                txtempid.Visible = true;
                txtaddress.Visible = true;
                txtcontact.Visible = true;
                txtemail.Visible = true;
                txtsalary.Visible = true;
                txtdesig.Visible = true;
                txtname.Enabled = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label13.Visible = true;
                label2.Visible = true;
                txtempid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtdesig.Text = "";
                txtsalary.Text = "";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled=true;
            groupBox3.Enabled=true;
            cmbempid.Visible = true;
            txtempid.Visible = false;
        }

        private void cmbempid_Click(object sender, EventArgs e)
        {
            cmbempid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Employee",objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach(DataRow dr in objdt.Rows)
            {
                cmbempid.Items.Add(dr["Employeeid"].ToString());   
            }
        }

        private void cmbempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtaddress.Text = objdt.Rows[cmbempid.SelectedIndex]["Address"].ToString();
            txtcontact.Text = objdt.Rows[cmbempid.SelectedIndex]["Phonenumber"].ToString();
            txtdesig.Text = objdt.Rows[cmbempid.SelectedIndex]["Designation"].ToString();
            txtemail.Text = objdt.Rows[cmbempid.SelectedIndex]["Email"].ToString();
            txtempid.Text = objdt.Rows[cmbempid.SelectedIndex]["Employeeid"].ToString();
            txtname.Text = objdt.Rows[cmbempid.SelectedIndex]["Name"].ToString();
            txtsalary.Text = objdt.Rows[cmbempid.SelectedIndex]["Salary"].ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbempid.Visible = true;
            txtempid.Visible = false;
            txtaddress.Visible = false;
            txtcontact.Visible = false;
            txtemail.Visible = false;
            txtsalary.Visible = false;
            txtdesig.Visible = false;
            txtname.Enabled = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label2.Visible = false; 
        }
    }
}
