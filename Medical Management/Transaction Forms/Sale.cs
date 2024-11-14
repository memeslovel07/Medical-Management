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
        DataTable objdt,objdt1;
        SqlCommand objcomm;
        private void Sale_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.;initial catalog=Medicalmanagement;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cmbvounum.Visible = false;
            txttotalamt.Text = "0";
            txtdiscount.Text = "0";
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
            rbtnexisting.Visible = false;
            rbtnnew.Visible = false;
            cmbcustid.Visible = false;
            txtcustid.Visible = true;
            groupBox2.Enabled = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                string customerid;
                if (rbtnnew.Checked == true)
                {
                    customerid = txtcustid.Text;
                }
                else
                {
                    customerid = cmbcustid.Text;
                }
                objcon.Open();
                objcomm = new SqlCommand("insert into Sale(Vouchernumber,Voucherdate,Customerid,Totalamount,Discount,Finalamount) values('" + txtVouchernum.Text + "','" + dateTimePicker1.Text + "','" +customerid + "','" + txttotalamt.Text + "','" + txtdiscount.Text + "','" + txtfinalamt.Text + "')", objcon);
                objcomm.ExecuteNonQuery();

                  if(rbtnnew.Checked==true)
                  {
                      objcomm = new SqlCommand("insert into Customer(Customerid,Name,Address,Phonenumber,email) values('" + customerid + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "')", objcon);
                      
                      objcomm.ExecuteNonQuery(); 
                  }
                int i;
                for(i=0;i<lstcompid.Items.Count;i++)
                {
                    objcomm = new SqlCommand("insert into tempsale(voucherno,companyid,medicinecode,quantity,amount) values ('" + txtVouchernum.Text + "','" + lstcompid.Items[i].ToString() + "','" + lstmedcode.Items[i].ToString() + "','" + lstquantity.Items[i].ToString() + "','" + lstamt.Items[i].ToString() +"')",objcon);
                    objcomm.ExecuteNonQuery();
                }
                MessageBox.Show("Sale Record Inserted");

            }
            if(mode =="Update")
            {
                objcon.Open();
                objcomm = new SqlCommand("update Sale set Voucherdate='" + dateTimePicker1.Text + "',Totalamount='" + txttotalamt.Text + "',Discount='" + txtdiscount.Text + "',Finalamount='" + txtfinalamt.Text + "' where Vouchernumber ='" + cmbvounum.Text + "'", objcon);

              //  objcomm = new SqlCommand("update tempsale set companyid='" + cmbcomid.Text + "'medicinecode,='" + cmbmedicinecode.Text + "',quantity='" + txtquantity.Text + "',amount='" + txtamountls.Text + "' where Vouchernumber ='" + cmbvounum.Text + "'", objcon);
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("Record Updated");
            }
            cmbcustid.Text = "";
            cmbvounum.Text = "";
            cmbmedicinecode.Text = "";
            cmbcomid.Text = "";
            txtamountls.Text = "0";
            txtdiscount.Text = "0";
            txtfinalamt.Text = "";
            txtprice.Text = "0";
            txtquantity.Text = "0";
            txttotalamt.Text = "0";
            lstcompid.Items.Clear();
            lstmedcode.Items.Clear();
            lstprice.Items.Clear();
            lstquantity.Items.Clear();
            lstamt.Items.Clear();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            txtcustid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            txtVouchernum.Text = "";
            cmbcustid.Text = "";

        }

        private void cmbvounum_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = objdt.Rows[cmbvounum.SelectedIndex]["Voucherdate"].ToString();
            txtcustid.Text= objdt.Rows[cmbvounum.SelectedIndex]["customerid"].ToString();
            txttotalamt.Text = objdt.Rows[cmbvounum.SelectedIndex]["Totalamount"].ToString();
            txtdiscount.Text = objdt.Rows[cmbvounum.SelectedIndex]["Discount"].ToString();
            txtfinalamt.Text = objdt.Rows[cmbvounum.SelectedIndex]["Finalamount"].ToString();
          
          objadpt = new SqlDataAdapter("select * from customer where customerid='"+ txtcustid.Text +"'", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            txtname.Text = objdt.Rows[0]["name"].ToString();
            txtaddress.Text = objdt.Rows[0]["address"].ToString();
            txtphone.Text = objdt.Rows[0]["Phonenumber"].ToString();
            txtemail.Text = objdt.Rows[0]["email"].ToString();

            objadpt = new SqlDataAdapter("select * from tempsale where voucherno='" + cmbvounum.Text + "'", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                lstcompid.Items.Add(dr["companyid"].ToString());
                lstmedcode.Items.Add(dr["medicinecode"].ToString());
                objadpt = new SqlDataAdapter("select * from medichine where medichinecode='" + dr["medicinecode"].ToString() + "'", objcon);
                objdt1 = new DataTable();
                objadpt.Fill(objdt1);
                lstprice.Items.Add(objdt1.Rows[0]["Price"].ToString());

                lstquantity.Items.Add(dr["quantity"].ToString());
                lstamt.Items.Add(dr["amount"].ToString());
            }

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
          cmbmedicinecode.Items.Clear ();
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

        private void btnlsadd_Click(object sender, EventArgs e)
        {
            lstcompid.Items.Add(cmbcomid.Text);
            lstmedcode.Items.Add(cmbmedicinecode.Text); 
            lstprice.Items.Add(txtprice.Text);
            lstquantity.Items.Add(txtquantity.Text);
            lstamt.Items.Add(txtamountls.Text);
            txttotalamt.Text = Convert.ToString(Convert.ToInt32(txtamountls.Text)+Convert.ToInt32(txttotalamt.Text));
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
          txtfinalamt.Text = Convert.ToString(Convert.ToInt32(txttotalamt.Text)- (Convert.ToInt32(txttotalamt.Text)* Convert.ToInt32(txtdiscount.Text)/100));
        }

        private void lstcompid_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstmedcode.SelectedIndex = lstcompid.SelectedIndex;
            lstprice.SelectedIndex = lstcompid.SelectedIndex;
            lstquantity.SelectedIndex = lstcompid.SelectedIndex;
            lstamt.SelectedIndex = lstcompid.SelectedIndex;
        }

        private void lstmedcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstmedcode.SelectedIndex;
            lstprice.SelectedIndex = lstmedcode.SelectedIndex;
            lstquantity.SelectedIndex = lstmedcode.SelectedIndex;
            lstamt.SelectedIndex = lstmedcode.SelectedIndex;
        }

        private void lstprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstprice.SelectedIndex;
            lstmedcode.SelectedIndex = lstprice.SelectedIndex;
            lstquantity.SelectedIndex = lstprice.SelectedIndex;
            lstamt.SelectedIndex = lstprice.SelectedIndex;
        }

        private void lstquantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstquantity.SelectedIndex;
            lstmedcode.SelectedIndex = lstquantity.SelectedIndex;
            lstprice.SelectedIndex = lstquantity.SelectedIndex;
            lstamt.SelectedIndex= lstquantity.SelectedIndex;
        }

        private void lstamt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstamt.SelectedIndex;
            lstmedcode.SelectedIndex = lstamt.SelectedIndex;
            lstprice.SelectedIndex = lstamt.SelectedIndex;
            lstquantity.SelectedIndex= lstamt.SelectedIndex;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int i;
            i=lstamt.SelectedIndex;
            lstcompid.Items.RemoveAt(lstamt.SelectedIndex);
            lstmedcode.Items.RemoveAt(i);
            lstprice.Items.RemoveAt(i);
            lstquantity.Items.RemoveAt(i);
           
            txttotalamt.Text = Convert.ToString(Convert.ToInt32(txttotalamt.Text) - Convert.ToInt32(lstamt.Items[i].ToString()));

            lstamt.Items.RemoveAt(i);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbvounum_Click(object sender, EventArgs e)
        {
            cmbvounum.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Sale", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbvounum.Items.Add(dr["Vouchernumber"].ToString());
            }
        }
    }
}
