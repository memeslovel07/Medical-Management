using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Medical_Management.Transaction_Forms
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadpt;
        DataTable objdt;
        SqlCommand objcomm;
        private void Sale_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.;initial catalog=Medicalmanagement;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cmbvounum.Visible = false;
            
        }
        string mode;
        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbvounum.Visible = true;
            txtVouchernum.Visible = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                if(rbtnnew.Checked)
                {
                    objcomm = new SqlCommand("insert into Customer(Customerid,Name,Address,Phonenumber,email) values('" + txtcustid.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One Record Inserted");
                    txtcustid.Text = "";
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txtphone.Text = "";
                    txtemail.Text = "";
                }
                /*  objcomm = new SqlCommand("insert into Sale(Vouchernumber,Voucherdate,Customerid,Totalamount,Discount,Finalamount) values('" + txtVouchernum.Text + "','" + dateTimePicker1.Text + "','" + txtcustid.Text + "','" + txttotalamt.Text + "','" + txtdiscount.Text + "','" + txtfinalamt.Text + "')", objcon);
                  objcon.Open();
                  objcomm.ExecuteNonQuery();
                  objcon.Close();
                  MessageBox.Show("Sale Record Inserted");*/

            }
        }

        private void cmbvounum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnnew_CheckedChanged(object sender, EventArgs e)
        {
            cmbcustid.Visible = false;
            txtcustid.Visible = true;
        }

        private void rbtnexisting_CheckedChanged(object sender, EventArgs e)
        {
            cmbcustid.Visible = true;
            txtcustid.Visible = false;
        }

        private void cmbcustid_Click(object sender, EventArgs e)
        {
            cmbcustid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Customer", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcustid.Items.Add(dr["Customerid"].ToString());
            }
        }

       

        private void cmbcomid_Click(object sender, EventArgs e)
        {
            cmbcomid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Company", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcomid.Items.Add(dr["Companyid"].ToString());
            }
        }

        

        private void cmbmedicinecode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprice.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["Price"].ToString();
        }

        private void cmbcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbcustid.SelectedIndex]["Name"].ToString();
            txtaddress.Text = objdt.Rows[cmbcustid.SelectedIndex]["Address"].ToString();
            txtphone.Text = objdt.Rows[cmbcustid.SelectedIndex]["Phonenumber"].ToString();
            txtemail.Text = objdt.Rows[cmbcustid.SelectedIndex]["Email"].ToString();
        }

        private void cmbcomid_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            objadpt = new SqlDataAdapter("select * from Medichine where Companyid='"+cmbcomid.Text+"'", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmedicinecode.Items.Add(dr["Medichinecode"].ToString());
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
       
            txtamountls.Text = Convert.ToString(Convert.ToDouble(txtprice.Text) * Convert.ToDouble(txtquantity.Text));
        }
    }
}
