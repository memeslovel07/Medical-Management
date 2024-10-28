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

namespace Medical_Management.Reports.DatewiseReports
{
    public partial class DatewiseMedicine : Form
    {
        public DatewiseMedicine()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadt;
        DataTable objdt;
        private void DatewiseMedicine_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.;initial catalog=Medicalmanagement;integrated security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtndatewise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked) 
            {
                objadt = new SqlDataAdapter("select * from medichine",objcon);
            }
            else
            {
                if (rbtndatewise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from medichine where [dateofmanu.]>='"+dateTimePicker1.Text+ "' and dateofexp<='" + dateTimePicker2.Text+"'",objcon);
                }
            }
            objdt = new DataTable();
            objadt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }
    }
}
