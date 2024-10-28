namespace Medical_Management.Transaction_Forms
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbvounum = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtVouchernum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnexisting = new System.Windows.Forms.RadioButton();
            this.rbtnnew = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtfinalamt = new System.Windows.Forms.TextBox();
            this.txttotalamt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtamountls = new System.Windows.Forms.TextBox();
            this.cmbmedicinecode = new System.Windows.Forms.ComboBox();
            this.cmbcomid = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cmbvounum);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtVouchernum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbvounum
            // 
            this.cmbvounum.FormattingEnabled = true;
            this.cmbvounum.Location = new System.Drawing.Point(182, 16);
            this.cmbvounum.Name = "cmbvounum";
            this.cmbvounum.Size = new System.Drawing.Size(152, 24);
            this.cmbvounum.TabIndex = 4;
            this.cmbvounum.SelectedIndexChanged += new System.EventHandler(this.cmbvounum_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtVouchernum
            // 
            this.txtVouchernum.Location = new System.Drawing.Point(182, 18);
            this.txtVouchernum.Name = "txtVouchernum";
            this.txtVouchernum.Size = new System.Drawing.Size(152, 22);
            this.txtVouchernum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voucher Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voucher Number";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.cmbcustid);
            this.groupBox2.Controls.Add(this.txtcustid);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbtnexisting);
            this.groupBox2.Controls.Add(this.rbtnnew);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbcustid
            // 
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(182, 61);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(152, 24);
            this.cmbcustid.TabIndex = 5;
            this.cmbcustid.SelectedIndexChanged += new System.EventHandler(this.cmbcustid_SelectedIndexChanged);
            this.cmbcustid.Click += new System.EventHandler(this.cmbcustid_Click);
            // 
            // txtcustid
            // 
            this.txtcustid.Location = new System.Drawing.Point(182, 63);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(152, 22);
            this.txtcustid.TabIndex = 11;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(182, 104);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(152, 22);
            this.txtname.TabIndex = 10;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(182, 147);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(152, 22);
            this.txtaddress.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(554, 60);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(152, 22);
            this.txtphone.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(554, 101);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(152, 22);
            this.txtemail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // rbtnexisting
            // 
            this.rbtnexisting.AutoSize = true;
            this.rbtnexisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnexisting.Location = new System.Drawing.Point(414, 21);
            this.rbtnexisting.Name = "rbtnexisting";
            this.rbtnexisting.Size = new System.Drawing.Size(88, 22);
            this.rbtnexisting.TabIndex = 1;
            this.rbtnexisting.TabStop = true;
            this.rbtnexisting.Text = "Existing";
            this.rbtnexisting.UseVisualStyleBackColor = true;
            this.rbtnexisting.CheckedChanged += new System.EventHandler(this.rbtnexisting_CheckedChanged);
            // 
            // rbtnnew
            // 
            this.rbtnnew.AutoSize = true;
            this.rbtnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnnew.Location = new System.Drawing.Point(24, 21);
            this.rbtnnew.Name = "rbtnnew";
            this.rbtnnew.Size = new System.Drawing.Size(62, 22);
            this.rbtnnew.TabIndex = 0;
            this.rbtnnew.TabStop = true;
            this.rbtnnew.Text = "New";
            this.rbtnnew.UseVisualStyleBackColor = true;
            this.rbtnnew.CheckedChanged += new System.EventHandler(this.rbtnnew_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.txtfinalamt);
            this.groupBox3.Controls.Add(this.txttotalamt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox5);
            this.groupBox3.Controls.Add(this.listBox4);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.txtquantity);
            this.groupBox3.Controls.Add(this.txtamountls);
            this.groupBox3.Controls.Add(this.cmbmedicinecode);
            this.groupBox3.Controls.Add(this.cmbcomid);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(884, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(599, 293);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(136, 22);
            this.txtdiscount.TabIndex = 33;
            // 
            // txtfinalamt
            // 
            this.txtfinalamt.Location = new System.Drawing.Point(599, 324);
            this.txtfinalamt.Name = "txtfinalamt";
            this.txtfinalamt.Size = new System.Drawing.Size(136, 22);
            this.txtfinalamt.TabIndex = 32;
            // 
            // txttotalamt
            // 
            this.txttotalamt.Location = new System.Drawing.Point(599, 261);
            this.txttotalamt.Name = "txttotalamt";
            this.txttotalamt.Size = new System.Drawing.Size(136, 22);
            this.txttotalamt.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(480, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Total Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(480, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Discount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(480, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Final Amount";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(783, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(783, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(628, 98);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(149, 148);
            this.listBox5.TabIndex = 23;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(473, 98);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(149, 148);
            this.listBox4.TabIndex = 22;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(318, 98);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(149, 148);
            this.listBox3.TabIndex = 21;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(163, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(149, 148);
            this.listBox2.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 148);
            this.listBox1.TabIndex = 19;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(318, 70);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(107, 22);
            this.txtprice.TabIndex = 18;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(473, 70);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(107, 22);
            this.txtquantity.TabIndex = 17;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // txtamountls
            // 
            this.txtamountls.Location = new System.Drawing.Point(628, 70);
            this.txtamountls.Name = "txtamountls";
            this.txtamountls.Size = new System.Drawing.Size(107, 22);
            this.txtamountls.TabIndex = 16;
            // 
            // cmbmedicinecode
            // 
            this.cmbmedicinecode.FormattingEnabled = true;
            this.cmbmedicinecode.Location = new System.Drawing.Point(163, 68);
            this.cmbmedicinecode.Name = "cmbmedicinecode";
            this.cmbmedicinecode.Size = new System.Drawing.Size(128, 24);
            this.cmbmedicinecode.TabIndex = 13;
            this.cmbmedicinecode.SelectedIndexChanged += new System.EventHandler(this.cmbmedicinecode_SelectedIndexChanged);
            // 
            // cmbcomid
            // 
            this.cmbcomid.FormattingEnabled = true;
            this.cmbcomid.Location = new System.Drawing.Point(6, 70);
            this.cmbcomid.Name = "cmbcomid";
            this.cmbcomid.Size = new System.Drawing.Size(128, 24);
            this.cmbcomid.TabIndex = 12;
            this.cmbcomid.SelectedIndexChanged += new System.EventHandler(this.cmbcomid_SelectedIndexChanged);
            this.cmbcomid.Click += new System.EventHandler(this.cmbcomid_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Company Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(506, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(665, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Medicine Code";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.btnadd);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 644);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(884, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(60, 17);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 33);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(163, 17);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 33);
            this.btnupdate.TabIndex = 27;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(273, 17);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 33);
            this.btnsave.TabIndex = 26;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(383, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 33);
            this.button3.TabIndex = 25;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 723);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtVouchernum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnexisting;
        private System.Windows.Forms.RadioButton rbtnnew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbmedicinecode;
        private System.Windows.Forms.ComboBox cmbcomid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamountls;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtfinalamt;
        private System.Windows.Forms.TextBox txttotalamt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbvounum;
        private System.Windows.Forms.ComboBox cmbcustid;
    }
}