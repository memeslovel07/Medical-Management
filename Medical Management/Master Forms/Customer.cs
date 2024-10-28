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
using System.Reflection.Emit;

namespace Medical_Management
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadpt;
        DataTable objdt;
        private void Customer_Load(object sender, EventArgs e)
        {
            string constr= @"data source=.; initial catalog=Medicalmanagement; integrated security= sspi";
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            objcon= new SqlConnection(constr);
            cmbcusid.Visible = false;
        }
        string mode;
        private void btnadd_Click(object sender, EventArgs e)
        {
             mode="Add";
            groupBox2.Enabled=true;
            groupBox3.Enabled=true;
            btnsave.Text = "ADD";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                cmbcusid.Items.Clear();
                objadpt = new SqlDataAdapter("select * from Customer where Customerid='" + txtcustid.Text + "'", objcon);
                objdt = new DataTable();
                objadpt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Customer Already Exist...");
                    txtcustid.Text = "";
                    txtcustid.Focus();
                }
                if (txtcustid.Text == "")
                {
                    MessageBox.Show("Enter the CustomerId..");
                    txtcustid.Focus();
                }
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Enter the Customer Address..");
                    txtaddress.Focus();
                }
                if (txtcontact.Text == "")
                {
                    MessageBox.Show("Enter the Customer Phone..");
                    txtcontact.Focus();
                }
                if (txtemail.Text == "")
                {
                    MessageBox.Show("Enter the Customer Mail..");
                    txtemail.Focus();
                }
                if (txtname.Text == "")
                {
                    MessageBox.Show("Enter the Customer Name..");
                    txtname.Focus();
                }
                else
                {
                    objcomm = new SqlCommand("insert into Customer(Customerid,Name,Address,Phonenumber,email) values('" + txtcustid.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One Record Inserted");
                    txtcustid.Text = "";
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txtcontact.Text = "";
                    txtemail.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    btnsave.Text = "SAVE";
                }
            }
            if(mode =="Update")
            {
                objcomm = new SqlCommand("update Customer set Address='" + txtaddress.Text + "',Phonenumber='"+txtcontact.Text+"',Email='"+txtemail.Text+"' where Customerid='"+cmbcusid.Text+"'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery ();
                MessageBox.Show("One Record Updated");
                objcon.Close();
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcusid.Text = "";
                cmbcusid.Visible = false;
                txtcustid.Visible = true;
                btnsave.Text = "SAVE";
            }
            if (mode == "Delete")
            {
                objcomm = new SqlCommand("delete Customer  where Customerid='" + cmbcusid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Delete");
                objcon.Close();
                txtname.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcusid.Text = "";
                cmbcusid.Visible = false;
                txtcustid.Visible = true;
                txtcustid.Visible = true;
                txtaddress.Visible = true;
                txtcontact.Visible = true;
                txtemail.Visible = true;
                txtname.Enabled = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                btnsave.Text = "SAVE";
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
            groupBox3.Enabled=true;
            cmbcusid.Visible = true;
            txtcustid.Visible = false;
            btnsave.Text = "UPDATE";
        }

        private void cmbcusid_Click(object sender, EventArgs e)
        {
            cmbcusid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Customer",objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach(DataRow dr in objdt.Rows)
            {
                cmbcusid.Items.Add(dr["Customerid"].ToString());
            }
        }

        private void cmbcusid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbcusid.SelectedIndex]["Name"].ToString();
            txtaddress.Text = objdt.Rows[cmbcusid.SelectedIndex]["Address"].ToString();
            txtcontact.Text = objdt.Rows[cmbcusid.SelectedIndex]["Phonenumber"].ToString();
            txtemail.Text = objdt.Rows[cmbcusid.SelectedIndex]["Email"].ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcusid.Visible = true;
            txtcustid.Visible = false;
            txtaddress.Visible = false;
            txtcontact.Visible = false;
            txtemail.Visible = false;
            txtname.Enabled = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnsave.Text = "DELETE";

        }
    }
}
