﻿using System;
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
    public partial class NamewiseSupplier : Form
    {
        public NamewiseSupplier()
        {
            InitializeComponent();
        }
        DataTable objdt;
        SqlDataAdapter objadt;
        SqlConnection objcon;
        private void NamewiseSupplier_Load(object sender, EventArgs e)
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
            objadt = new SqlDataAdapter("select * from Supplier", objcon);
            objdt = new DataTable();
            objadt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcnw.Items.Add(dr["Suppliername"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked)
            {
                objadt = new SqlDataAdapter("select * from Supplier", objcon);
            }
            else
            {
                if (rbtnNamewise.Checked)
                {
                    objadt = new SqlDataAdapter("select * from Supplier where Suppliername='" + cmbcnw.Text + "'", objcon);
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