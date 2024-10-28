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
using System.Xml.Linq;
using System.Reflection.Emit;

namespace Medical_Management
{
    public partial class Supplier : Form
    {
        public Supplier()
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
        private void Supplier_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.; initial catalog=Medicalmanagement; integrated security= sspi";
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            objcon = new SqlConnection(constr);
            cmbsupid.Visible = false;
        }
        string mode;
        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            btnsave.Text = "ADD";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objadpt = new SqlDataAdapter("select * from Supplier where Supplierid='" + txtSupplierid.Text + "'", objcon);
                objdt = new DataTable();
                objadpt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Supplierid Already Exist...");
                    txtSupplierid.Text = "";
                    txtSupplierid.Focus();
                }
                if (txtSupplierid.Text == "")
                {
                    MessageBox.Show("Enter the SupplierId..");
                    txtSupplierid.Focus();
                }
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Enter the Supplier Address..");
                    txtaddress.Focus();
                }
                if (txtcontact.Text == "")
                {
                    MessageBox.Show("Enter the Supplier Phone..");
                    txtcontact.Focus();
                }
                if (txtemail.Text == "")
                {
                    MessageBox.Show("Enter the Supplier Mail..");
                    txtemail.Focus();
                }
                if (txtsupplier.Text == "")
                {
                    MessageBox.Show("Enter the Supplier Name..");
                    txtsupplier.Focus();
                }
                if (cmbcompid.Text == "")
                {
                    MessageBox.Show("Enter the Companyid..");
                    cmbcompid.Focus();
                }
                if (cmbmedcode.Text == "")
                {
                    MessageBox.Show("Enter the Medichinecode..");
                    cmbmedcode.Focus();
                }
                else
                {
                    objcomm = new SqlCommand("insert into supplier(Supplierid,Suppliername,Companyid,Medichinecode,Address,Phone,Email) values('" + txtSupplierid.Text + "','" + txtsupplier.Text + "','" + cmbcompid.Text + "','" + cmbmedcode.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One Record Inserted");
                    txtSupplierid.Text = "";
                    txtsupplier.Text = "";
                    txtaddress.Text = "";
                    txtcontact.Text = "";
                    txtemail.Text = "";
                    cmbcompid.Text = "";
                    cmbmedcode.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    btnsave.Text = "SAVE";
                }

            }
            if(mode =="Update")
            {
                objcomm = new SqlCommand("update Supplier set Address='"+txtaddress.Text+"',Phone='"+txtcontact.Text+"',Email='"+txtemail.Text+"',Medichinecode='"+cmbmedcode.Text+"'",objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Updated");
                objcon.Close();
                txtSupplierid.Text = "";
                txtsupplier.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                cmbcompid.Text = "";
                cmbmedcode.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                btnsave.Text = "SAVE";
                cmbsupid.Visible = false;
                txtSupplierid.Visible = true;


            }
            if(mode =="Delete")
            {
                objcomm = new SqlCommand("delete Supplier  where Supplierid='" + cmbsupid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Recorded Delete");
                objcon.Close();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbsupid.Text = "";
                cmbsupid.Visible = false;
                btnsave.Text = "SAVE";
                txtSupplierid.Visible = true;
                txtaddress.Visible = true;
                txtcontact.Visible = true;
                txtemail.Visible = true;
                cmbmedcode.Visible = true;
                txtSupplierid.Enabled = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label2.Visible = true;
                label13.Visible = true;
               cmbcompid.Visible = true;
                txtsupplier.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                cmbcompid.Text = "";
                cmbmedcode.Text = "";
                txtSupplierid.Text = "";
                
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbsupid.Visible = true;
            btnsave.Text = "UPDATE";
            txtSupplierid.Visible = false;
        }

        private void cmbsupid_Click(object sender, EventArgs e)
        {
            cmbsupid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Supplier",objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows) { 
            cmbsupid.Items.Add(dr["Supplierid"].ToString());
            }
        }

        private void cmbsupid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtaddress.Text = objdt.Rows[cmbsupid.SelectedIndex]["Address"].ToString();
            cmbcompid.Text = objdt.Rows[cmbsupid.SelectedIndex]["Companyid"].ToString();
            txtcontact.Text = objdt.Rows[cmbsupid.SelectedIndex]["Phone"].ToString();
            txtemail.Text = objdt.Rows[cmbsupid.SelectedIndex]["Email"].ToString();
            cmbmedcode.Text = objdt.Rows[cmbsupid.SelectedIndex]["Medichinecode"].ToString();
            txtsupplier.Text = objdt.Rows[cmbsupid.SelectedIndex]["Suppliername"].ToString();
            txtSupplierid.Text = objdt.Rows[cmbsupid.SelectedIndex]["Supplierid"].ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbsupid.Visible = true;
            btnsave.Text = "DELETE";
            txtSupplierid.Visible = false;
            txtaddress.Visible = false;
            txtcontact.Visible = false;
            txtemail.Visible = false;
            cmbmedcode.Visible = false;
            txtSupplierid.Enabled = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label2.Visible = false;
            label13.Visible = false;
            cmbcompid.Visible= false;
        }

        private void cmbcompid_Click(object sender, EventArgs e)
        {
            cmbcompid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Company", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcompid.Items.Add(dr["Companyid"].ToString());
            }
        }

        private void cmbmedcode_Click(object sender, EventArgs e)
        {
            cmbmedcode.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Medichine", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmedcode.Items.Add(dr["Medichinecode"].ToString());
            }
        }
    }
}
