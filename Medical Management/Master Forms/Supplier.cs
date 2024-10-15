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
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objcomm = new SqlCommand("insert into supplier(Supplierid,Suppliername,Companyid,Medichinecode,Address,Phone,Email) values('" + txtSupplierid.Text + "','" + txtsupplier.Text + "','" + txtcompanyid.Text + "','" + txtmedicinecode.Text + "','" +txtaddress.Text + "','" +txtcontact.Text + "','" +txtemail.Text + "')", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One Record Inserted");
                txtSupplierid.Text = "";
                txtsupplier.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtcompanyid.Text = "";
                txtmedicinecode.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;

            }
            if(mode =="Update")
            {
                objcomm = new SqlCommand("update Supplier set Address='"+txtaddress.Text+"',Phone='"+txtcontact.Text+"',Email='"+txtemail.Text+"',Medichinecode='"+txtmedicinecode.Text+"'",objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Updated");
                objcon.Close();
                txtSupplierid.Text = "";
                txtsupplier.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtcompanyid.Text = "";
                txtmedicinecode.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
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
                txtSupplierid.Visible = true;
                txtaddress.Visible = true;
                txtcontact.Visible = true;
                txtemail.Visible = true;
                txtmedicinecode.Visible = true;
                txtSupplierid.Enabled = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label2.Visible = true;
                label13.Visible = true;
                txtcompanyid.Visible = true;
                txtsupplier.Text = "";
                txtaddress.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtcompanyid.Text = "";
                txtmedicinecode.Text = "";
                txtSupplierid.Text = "";
                
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbsupid.Visible = true;
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
            txtcompanyid.Text = objdt.Rows[cmbsupid.SelectedIndex]["Companyid"].ToString();
            txtcontact.Text = objdt.Rows[cmbsupid.SelectedIndex]["Phone"].ToString();
            txtemail.Text = objdt.Rows[cmbsupid.SelectedIndex]["Email"].ToString();
            txtmedicinecode.Text = objdt.Rows[cmbsupid.SelectedIndex]["Medichinecode"].ToString();
            txtsupplier.Text = objdt.Rows[cmbsupid.SelectedIndex]["Suppliername"].ToString();
            txtSupplierid.Text = objdt.Rows[cmbsupid.SelectedIndex]["Supplierid"].ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbsupid.Visible = true;
            txtSupplierid.Visible = false;
            txtaddress.Visible = false;
            txtcontact.Visible = false;
            txtemail.Visible = false;
            txtmedicinecode.Visible = false;
            txtSupplierid.Enabled = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label2.Visible = false;
            label13.Visible = false;
            txtcompanyid.Visible= false;
        }
    }
}
