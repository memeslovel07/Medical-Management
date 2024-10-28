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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadpt;
        DataTable objdt;
        SqlCommand objcomm;

        private void Salary_Load(object sender, EventArgs e)
        {
            string constr = @"data source=.;initial catalog=Medicalmanagement;integrated security=sspi";
            objcon = new SqlConnection(constr);
        }

        private void cmbempid_Click(object sender, EventArgs e)
        {
            cmbempid.Items.Clear();
            objadpt = new SqlDataAdapter("select * from Employee", objcon);
            objdt = new DataTable();
            objadpt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbempid.Items.Add(dr["Employeeid"].ToString());
            }
        }

        private void cmbempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbempid.SelectedIndex]["Name"].ToString();
            txtsalary.Text = objdt.Rows[cmbempid.SelectedIndex]["Salary"].ToString();
        }

        private void txtded_TextChanged(object sender, EventArgs e)
        {
            int leaveamnt;
            leaveamnt= Convert.ToInt32(txtsalary.Text)/30*Convert.ToInt32(txtnoofleave.Text);
            txtpay.Text = Convert.ToString(Convert.ToInt32(txtsalary.Text)+Convert.ToInt32(txtallow.Text)-Convert.ToInt32(txtded.Text)-leaveamnt);
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            objcomm = new SqlCommand("insert into Salary(Employeeid,Leave,Dateofsalray,Deduction,Allowance,Netpay) values('" + cmbempid.Text + "','" + txtnoofleave.Text + "','" + dateTimePicker1.Text + "','" + txtded.Text + "','" + txtallow.Text + "','" + txtpay.Text + "')", objcon);
            objcon.Open();
            objcomm.ExecuteNonQuery();
            objcon.Close();
            MessageBox.Show("Salary Inserted");
            cmbempid.Text = "";
            txtallow.Text ="0";
            txtname.Text ="";
            txtnoofleave.Text = "0";
            txtpay.Text = "";
            txtsalary.Text = "0";
            txtded.Text = "0";
            

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
