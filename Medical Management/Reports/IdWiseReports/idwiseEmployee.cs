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
    public partial class idwiseEmployee : Form
    {
        public idwiseEmployee()
        {
            InitializeComponent();
        }
        SqlDataAdapter objadt;
        DataTable objdt;
        SqlConnection objcon;
        private void idwiseEmployee_Load(object sender, EventArgs e)
        {
            String constr = @"data source=.; initial catalog=Medicalmanagement;integrated security=sspi";

            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbmiw.Visible = false;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbmiw.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbmiw_Click(object sender, EventArgs e)
        {
            cmbmiw.Items.Clear();
            objadt = new SqlDataAdapter("select * from Employee", objcon);
            objdt = new DataTable();
            objadt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmiw.Items.Add(dr["Employeeid"].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked)
            {
                objadt = new SqlDataAdapter("select * from Employee", objcon);
            }
            else
            {
                if (rbtnidwise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from Employee where Employeeid='" + cmbmiw.Text + "'", objcon);
                }
            }


            objdt = new DataTable();
            objadt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }
    }
}
