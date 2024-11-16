using Medical_Management.Starting_Page;
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

        DataTable objdt,objdt1;

       // DataTable objdt;

        SqlCommand objcomm;
        private void Purchase_Load(object sender, EventArgs e)
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

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objcon.Open();

                objcomm = new SqlCommand("insert into purchase(Vouchernumber,Voucherdate,Supplierid,Totalamount,Discount,Finalamount) values('" + txtvounum.Text + "','" + dateTimePicker1.Text + "','" + txtsupid.Text + "','" + txttotalamt.Text + "','" + txtdiscount.Text + "','" + txtfinalamt.Text + "')", objcon);
                int i;
                for (i = 0; i < lstcompid.Items.Count; i++)
                {
                    objcomm = new SqlCommand("insert into temppurchase(voucherno,companyid,medicinecode,quantity,amount) values ('" + txtvounum.Text + "','" + lstcompid.Items[i].ToString() + "','" + lstmedcode.Items[i].ToString() + "','" + lstquantity.Items[i].ToString() + "','" + lstamount.Items[i].ToString() + "')", objcon);
                    objcomm.ExecuteNonQuery();
                }
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("Purchase Record Inserted");


             /*   objcomm = new SqlCommand("insert into supplier(Supplierid,Suppliername,Companyid,Medichinecode,Address,Phone,Email) values('" + txtsupid.Text + "','" + txtname.Text + "','" + cmbcomid.Text + "','" + cmbmedcodesu.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "')", objcon);
               

                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Inserted");*/
                txtsupid.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";




              /*   objcomm = new SqlCommand("insert into purchase(Vouchernumber,Voucherdate,Supplierid,Totalamount,Discount,Finalamount) values('" + txtvounum.Text + "','" + dateTimePicker1.Text + "','" + txtsupid.Text + "','" + txttotalamt.Text + "','" + txtdiscount.Text + "','" + txtfinalamt.Text + "')", objcon);
                  objcomm.ExecuteNonQuery();
                  objcon.Close();
                  MessageBox.Show("Purchase Record Inserted");*/


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

            if (txtquantity.Text == "")
            {
                txtquantity.Text = "0";
            }
            else
            {
                txtamt.Text = Convert.ToString(Convert.ToDouble(txtutprice.Text) * Convert.ToDouble(txtquantity.Text));
            }

            txtamt.Text = Convert.ToString(Convert.ToDouble(txtutprice.Text) * Convert.ToDouble(txtquantity.Text));

        }

        private void cmbvounum_SelectedIndexChanged(object sender, EventArgs e)
        {

            dateTimePicker1.Text = objdt.Rows[cmbvounum.SelectedIndex]["Voucherdate"].ToString();
            txtsupid.Text = objdt.Rows[cmbvounum.SelectedIndex]["supplierid"].ToString();
            txttotalamt.Text = objdt.Rows[cmbvounum.SelectedIndex]["Totalamount"].ToString();
            txtdiscount.Text = objdt.Rows[cmbvounum.SelectedIndex]["Discount"].ToString();
            txtfinalamt.Text = objdt.Rows[cmbvounum.SelectedIndex]["Finalamount"].ToString();

            objadpt = new SqlDataAdapter("select * from supplier where supplierid='" + txtsupid.Text + "'", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            txtname.Text = objdt.Rows[0]["name"].ToString();
            txtaddress.Text = objdt.Rows[0]["address"].ToString();
            txtphone.Text = objdt.Rows[0]["Phone"].ToString();
            txtemail.Text = objdt.Rows[0]["email"].ToString();
            cmbmedcodesu.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Medichinecode"].ToString();
            txtname.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Suppliername"].ToString();
            txtsupid.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Supplierid"].ToString();
            cmbcomidsu.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Companyid"].ToString();

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
                lstamount.Items.Add(dr["amount"].ToString());
            }


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmbsupplierid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtaddress.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Address"].ToString();
            cmbcomidsu.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Companyid"].ToString();
            txtphone.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Phone"].ToString();
            txtemail.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Email"].ToString();
            cmbmedcodesu.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Medichinecode"].ToString();
            txtname.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Suppliername"].ToString();
            txtsupid.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Supplierid"].ToString();
        }

        private void btnlsadd_Click(object sender, EventArgs e)
        {
            lstcompid.Items.Add(cmbcomid.Text);
            lstmedcode.Items.Add(cmbmedicinecode.Text);
            lstprice.Items.Add(txtutprice.Text);
            lstquantity.Items.Add(txtquantity.Text);
            lstamount.Items.Add(txtamt.Text);
            txttotalamt.Text = Convert.ToString(Convert.ToInt32(txtamt.Text) + Convert.ToInt32(txttotalamt.Text));
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            txtfinalamt.Text = Convert.ToString(Convert.ToInt32(txttotalamt.Text) - (Convert.ToInt32(txttotalamt.Text) * Convert.ToInt32(txtdiscount.Text) / 100));
        }

        private void lstcompid_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstmedcode.SelectedIndex = lstcompid.SelectedIndex;
            lstprice.SelectedIndex = lstcompid.SelectedIndex;
            lstquantity.SelectedIndex = lstcompid.SelectedIndex;
            lstamount.SelectedIndex = lstcompid.SelectedIndex;
        }

        private void lstmedcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstmedcode.SelectedIndex;
            lstprice.SelectedIndex = lstmedcode.SelectedIndex;
            lstquantity.SelectedIndex = lstmedcode.SelectedIndex;
            lstamount.SelectedIndex = lstmedcode.SelectedIndex;
        }

        private void lstprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstprice.SelectedIndex;
            lstmedcode.SelectedIndex = lstprice.SelectedIndex;
            lstquantity.SelectedIndex = lstprice.SelectedIndex;
            lstamount.SelectedIndex = lstprice.SelectedIndex;
        }

        private void lstquantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstquantity.SelectedIndex;
            lstmedcode.SelectedIndex = lstquantity.SelectedIndex;
            lstprice.SelectedIndex = lstquantity.SelectedIndex;
            lstamount.SelectedIndex = lstquantity.SelectedIndex;
        }

        private void lstamount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcompid.SelectedIndex = lstamount.SelectedIndex;
            lstmedcode.SelectedIndex = lstamount.SelectedIndex;
            lstprice.SelectedIndex = lstamount.SelectedIndex;
            lstquantity.SelectedIndex = lstamount.SelectedIndex;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int i;
            i = lstamount.SelectedIndex;
            lstcompid.Items.RemoveAt(lstamount.SelectedIndex);
            lstmedcode.Items.RemoveAt(i);
            lstprice.Items.RemoveAt(i);
            lstquantity.Items.RemoveAt(i);

            txttotalamt.Text = Convert.ToString(Convert.ToInt32(txttotalamt.Text) - Convert.ToInt32(lstamount.Items[i].ToString()));

            lstamount.Items.RemoveAt(i);
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

        private void cmbsupplierid_Click(object sender, EventArgs e)
        {
            cmbsupplierid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Supplier", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbsupplierid.Items.Add(dr["Supplierid"].ToString());
            }
        }

    }
}

