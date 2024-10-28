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

namespace Medical_Management.Reports.VoucherNumberWise
{
    public partial class VoucherwisePurchase : Form
    {
        public VoucherwisePurchase()
        {
            InitializeComponent();
        }
        SqlDataAdapter objadt;
        DataTable objdt;
        SqlConnection objcon;
        private void VoucherwisePurchase_Load(object sender, EventArgs e)
        {
            String constr = @"data source=.; initial catalog=Medicalmanagement;integrated security=sspi";

            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbvnw.Visible = false;
        }

        private void rbtnNamewise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbvnw.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked)
            {
                objadt = new SqlDataAdapter("select * from Purchase", objcon);
            }
            else 
            {
                if (rbtnNamewise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from Purchase where Vouchernumber='"+cmbvnw.Text+"'",objcon);
                }
            }
            objdt= new DataTable();
            objadt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void cmbvnw_Click(object sender, EventArgs e)
        {
            cmbvnw.Items.Clear();
            objadt = new SqlDataAdapter("select * from Purchase", objcon);
            objdt = new DataTable();
            objadt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbvnw.Items.Add(dr["VoucherNumber"].ToString());
            }
        }
    }
}
