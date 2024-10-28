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
    public partial class VoucherwiseSalecs : Form
    {
        public VoucherwiseSalecs()
        {
            InitializeComponent();
        }
        SqlDataAdapter objadt;
        DataTable objdt;
        SqlConnection objcon;
        private void VoucherwiseSalecs_Load(object sender, EventArgs e)
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
                objadt = new SqlDataAdapter("select * from Sale", objcon);
            }
            else
            {
                if (rbtnNamewise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from Sale where Vouchernumber='" + cmbvnw.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }
    }
}
