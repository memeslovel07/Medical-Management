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

namespace Medical_Management.Reports.IdWiseReports
{
    public partial class idwiseMedicine : Form
    {
        public idwiseMedicine()
        {
            InitializeComponent();
        }
        SqlDataAdapter objadt;
        DataTable objdt;
        SqlConnection objcon;
        private void idwiseMedicine_Load(object sender, EventArgs e)
        {
            String constr = @"data source=.; initial catalog=Medicalmanagement;integrated security=sspi";

            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbmiw.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbmiw.Visible = true;
        }

        private void cmbmiw_Click(object sender, EventArgs e)
        {
            cmbmiw.Items.Clear();
            objadt = new SqlDataAdapter("select * from Medichine", objcon);
            objdt = new DataTable();
            objadt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmiw.Items.Add(dr["Medichinecode"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked)
            {
                objadt = new SqlDataAdapter("select * from Medichine", objcon);
            }
            else
            {
                if (rbtnidwise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from Medichine where Medichinecode='" + cmbmiw.Text + "'", objcon);
                }
            }


            objdt = new DataTable();
            objadt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }
    }
}
