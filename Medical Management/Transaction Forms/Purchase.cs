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

namespace Medical_Management.Transaction_Forms
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadpt;
        DataTable objdt;
        SqlCommand objcomm;
        private void Purchase_Load(object sender, EventArgs e)
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

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objcon.Open();
               // objcomm = new SqlCommand("insert into supplier(Supplierid,Suppliername,Companyid,Medichinecode,Address,Phone,Email) values('" + .Text + "','" + txtname.Text + "','" + cmbcomid.Text + "','" + cmbmedcodesu.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "')", objcon);
               
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Inserted");
                txtsupid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";

                 objcomm = new SqlCommand("insert into purchase(Vouchernumber,Voucherdate,Supplierid,Totalamount,Discount,Finalamount) values('" + txtvounum.Text + "','" + dateTimePicker1.Text + "','" + txtsupid.Text + "','" + txttotalamt.Text + "','" + txtdiscount.Text + "','" + txtfinalamt.Text + "')", objcon);
                  objcomm.ExecuteNonQuery();
                  objcon.Close();
                  MessageBox.Show("Purchase Record Inserted");

            }
        }

        private void cmbcomidsu_Click(object sender, EventArgs e)
        {
            cmbcomidsu.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Company", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcomidsu.Items.Add(dr["Companyid"].ToString());
            }
        }

        private void cmbmedicinecode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtutprice.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["Price"].ToString();
        }

        private void cmbcomid_SelectedIndexChanged(object sender, EventArgs e)
        {
            objadpt = new SqlDataAdapter("select * from Medichine where Companyid='" + cmbcomid.Text + "'", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmedicinecode.Items.Add(dr["Medichinecode"].ToString());
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

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            txtamt.Text = Convert.ToString(Convert.ToDouble(txtutprice.Text) * Convert.ToDouble(txtquantity.Text));
        }

        private void cmbvounum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

