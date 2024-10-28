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

namespace Medical_Management.Reports.NamewiseReports
{
    public partial class NamewiseCustomer : Form
    {
        public NamewiseCustomer()
        {
            InitializeComponent();
        }
        DataTable objdt;
        SqlDataAdapter objadt;
        SqlConnection objcon;
        private void NamewiseCustomer_Load(object sender, EventArgs e)
        {
            String constr = @"data source=.; initial catalog=Medicalmanagement;integrated security=sspi";

            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbcnw.Visible = false;
        }

        private void rbtnNamewise_CheckedChanged(object sender, EventArgs e)
        {
            cmbcnw.Visible = true;
            label1.Visible = true;
        }

        private void cmbcnw_Click(object sender, EventArgs e)
        {
            cmbcnw.Items.Clear();
            objadt = new SqlDataAdapter("select * from Customer", objcon);
            objdt = new DataTable();
            objadt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcnw.Items.Add(dr["name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked)
            {
                objadt = new SqlDataAdapter("select * from Customer", objcon);
            }
            else
            {
                if (rbtnNamewise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from Customer where name='" + cmbcnw.Text + "'", objcon);
                }
            }


            objdt = new DataTable();
            objadt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
