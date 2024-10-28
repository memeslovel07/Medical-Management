using Medical_Management.Reports.DatewiseReports;
using Medical_Management.Reports.IdWiseReports;
using Medical_Management.Reports.NamewiseReports;
using Medical_Management.Reports.VoucherNumberWise;
using Medical_Management.Starting_Page;
using Medical_Management.Transaction_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Management
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee1 emp = new employee1();
            NewMethod(emp);
        }

        private static void NewMethod(employee1 emp)
        {
            emp.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {
          
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            idwiseMedicine idwiseMedicine = new idwiseMedicine();
            idwiseMedicine.Show();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            idwiseComapny idwiseComapny = new idwiseComapny();
            idwiseComapny.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            idwiseSupplier idwiseSupplier = new idwiseSupplier();
            idwiseSupplier.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            idwiseCustomer idwiseCustomer = new idwiseCustomer();
            idwiseCustomer.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            idwiseEmployee idwiseEmployee = new idwiseEmployee();
            idwiseEmployee.Show();
        }

        private void namewiseMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NamewiseMedicine namewiseMedicine= new NamewiseMedicine();
            namewiseMedicine.Show();
        }

        private void namewiseCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NamewiseCompany namewiseCompany= new NamewiseCompany();
            namewiseCompany.Show();
        }

        private void namewiseSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NamewiseSupplier namewiseSupplier= new NamewiseSupplier();
            namewiseSupplier.Show();
        }

        private void namewiseCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NamewiseCustomer namewiseCustomer= new NamewiseCustomer();
            namewiseCustomer.Show();
        }

        private void namewiseEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NamewiseEmployee namewiseEmployee= new NamewiseEmployee();
            namewiseEmployee.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary salary= new Salary();
            salary.Show();
        }

        private void medichineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatewiseMedicine datewiseMedicine = new DatewiseMedicine();
            datewiseMedicine.Show();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Datewisepurchase datewisepurchase = new Datewisepurchase();
            datewisepurchase.Show();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatewiseSale datewiseSale = new DatewiseSale();
            datewiseSale.Show();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatewiseSalary datewiseSalary = new DatewiseSalary();
            datewiseSalary.Show();
        }

        private void purchaseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VoucherwisePurchase voucherwisePurchase = new VoucherwisePurchase();
            voucherwisePurchase.Show();
        }

        private void saleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VoucherwiseSalecs voucherwiseSalecs = new VoucherwiseSalecs();
            voucherwiseSalecs.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }
    }
}
