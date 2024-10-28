using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Management
{
    public partial class Medicine : Form
    {
        public Medicine()
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
        private void Medicine_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.; initial catalog=Medicalmanagement; integrated security= sspi";
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            objcon = new SqlConnection(constr);
            cmbmedcode.Visible=false;
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
                objadpt = new SqlDataAdapter("select * from Medichine where Medichinecode='" +txtmedicinecode.Text + "'", objcon);
                objdt = new DataTable();
                objadpt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Medicinecode Already Exist...");
                    txtmedicinecode.Text = "";
                    txtmedicinecode.Focus();
                }
                if (txtmedicinecode.Text == "")
                {
                    MessageBox.Show("Enter the Medicinecode..");
                    txtmedicinecode.Focus();
                }
                if (txtname.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Name..");
                    txtname.Focus();
                }
                if (txtpower.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Power..");
                    txtpower.Focus();
                }
                if (cmbcompid.Text == "")
                {
                    MessageBox.Show("Enter the CompanyId ..");
                    cmbcompid.Focus();
                }
                if (txtprice.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Price..");
                    txtprice.Focus();
                }
                else
                {
                    objcomm = new SqlCommand("insert into Medichine(Medichinecode,Name,Companyid,[dateofmanu.],dateofexp,Price,power) values('" + txtmedicinecode.Text + "','" + txtname.Text + "','" + cmbcompid.Text + "','" + txtdtmanu.Value + "','" + txtdtexp.Value + "','" + txtprice.Text + "','" + txtpower.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One Record Inserted");
                    txtmedicinecode.Text = "";
                    txtname.Text = "";
                    cmbcompid.Text = "";
                    txtprice.Text = "";
                    txtpower.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    btnsave.Text = "SAVE";
                }
            }
            if(mode == "Update")
            {
                objcomm = new SqlCommand("Update Medichine set Name='"+txtname.Text+"',Price ='"+txtprice.Text+"', Power ='"+txtpower.Text+ "',[dateofmanu.]='"+txtdtmanu.Value+"',dateofexp='"+txtdtexp.Value+"' where Medichinecode='"+cmbmedcode.Text+"'", objcon);
                objcon.Open() ;
                objcomm.ExecuteNonQuery() ;
                MessageBox.Show("One Record Updated");
                objcon.Close();
                txtname.Text = "";
                cmbcompid.Text = "";
                txtmedicinecode.Text = "";
                txtpower.Text = "";
                txtprice.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbmedcode.Text = "";
                cmbmedcode.Visible = false;
                txtmedicinecode.Visible = true;
                btnsave.Text = "SAVE";

            }
            if (mode == "Delete") 
            {
                objcomm = new SqlCommand("delete Medichine  where Medichinecode='" + cmbmedcode.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Recorded Delete");
                objcon.Close();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbmedcode.Visible = false;
                txtmedicinecode.Visible = true;
                cmbcompid.Visible = true;
                txtdtexp.Visible = true;
                txtdtmanu.Visible = true;
                txtprice.Visible = true;
                txtpower.Visible = true;
                txtname.Enabled = true;
                label5.Visible = true;
                label4.Visible = true; 
                label3.Visible = true;
                label7.Visible = true;
                label2.Visible = true;
                txtname.Text = "";
                cmbcompid.Text = "";
                txtmedicinecode.Text = "";
                txtpower.Text = "";
                txtprice.Text = "";
                cmbmedcode.Text = "";
                btnsave.Text = "SAVE";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbmedcode.Visible = true;
            txtmedicinecode.Visible = false;
            btnsave.Text = "UPDATE";
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

        private void cmbmedcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbmedcode.SelectedIndex]["Name"].ToString(); 
           cmbcompid.Text = objdt.Rows[cmbmedcode.SelectedIndex]["Companyid"].ToString();
            txtprice.Text = objdt.Rows[cmbmedcode.SelectedIndex]["Price"].ToString();
            txtpower.Text = objdt.Rows[cmbmedcode.SelectedIndex]["Power"].ToString();
            txtdtmanu.Value= Convert.ToDateTime(objdt.Rows[cmbmedcode.SelectedIndex]["dateofmanu."].ToString());
            txtdtexp.Value = Convert.ToDateTime(objdt.Rows[cmbmedcode.SelectedIndex]["dateofexp"].ToString());

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbmedcode.Visible = true;
            txtmedicinecode.Visible = false;
            cmbcompid.Visible = false;
            txtdtexp.Visible = false;
            txtdtmanu.Visible = false;
            txtprice.Visible = false;
            txtpower.Visible = false;
            txtname.Enabled = false;
            label5.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            btnsave.Text = "DELETE";
            label2.Visible = false;
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
    }
}
