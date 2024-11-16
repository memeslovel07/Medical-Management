namespace Medical_Management.Transaction_Forms
{
    partial class Purchase
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
            this.txtvounum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();

            this.cmbsupplierid = new System.Windows.Forms.ComboBox();

            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbmedcodesu = new System.Windows.Forms.ComboBox();
            this.cmbcomidsu = new System.Windows.Forms.ComboBox();
            this.txtsupid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtfinalamt = new System.Windows.Forms.TextBox();
            this.txttotalamt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnlsadd = new System.Windows.Forms.Button();
            this.lstamount = new System.Windows.Forms.ListBox();
            this.lstquantity = new System.Windows.Forms.ListBox();
            this.lstprice = new System.Windows.Forms.ListBox();
            this.lstmedcode = new System.Windows.Forms.ListBox();
            this.lstcompid = new System.Windows.Forms.ListBox();
            this.txtutprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
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
            this.btnexit = new System.Windows.Forms.Button();

            this.cmbsupplierid = new System.Windows.Forms.ComboBox();

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
            this.groupBox1.Controls.Add(this.txtvounum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbvounum
            // 
            this.cmbvounum.FormattingEnabled = true;
            this.cmbvounum.Location = new System.Drawing.Point(182, 17);
            this.cmbvounum.Name = "cmbvounum";
            this.cmbvounum.Size = new System.Drawing.Size(152, 24);
            this.cmbvounum.TabIndex = 5;
            this.cmbvounum.SelectedIndexChanged += new System.EventHandler(this.cmbvounum_SelectedIndexChanged);

            this.cmbvounum.Click += new System.EventHandler(this.cmbvounum_Click);

            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtvounum
            // 
            this.txtvounum.Location = new System.Drawing.Point(182, 18);
            this.txtvounum.Name = "txtvounum";
            this.txtvounum.Size = new System.Drawing.Size(152, 22);
            this.txtvounum.TabIndex = 2;
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
            this.groupBox2.Controls.Add(this.cmbsupplierid);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmbmedcodesu);
            this.groupBox2.Controls.Add(this.cmbcomidsu);
            this.groupBox2.Controls.Add(this.txtsupid);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 

            // cmbsupplierid
            // 
            this.cmbsupplierid.FormattingEnabled = true;
            this.cmbsupplierid.Location = new System.Drawing.Point(182, 63);
            this.cmbsupplierid.Name = "cmbsupplierid";
            this.cmbsupplierid.Size = new System.Drawing.Size(152, 24);
            this.cmbsupplierid.TabIndex = 18;
            this.cmbsupplierid.SelectedIndexChanged += new System.EventHandler(this.cmbsupplierid_SelectedIndexChanged);
            this.cmbsupplierid.Click += new System.EventHandler(this.cmbsupplierid_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(395, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "Company Id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(395, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 18);
            this.label16.TabIndex = 16;
            this.label16.Text = "Medicine Code";
            // 
            // cmbmedcodesu
            // 
            this.cmbmedcodesu.FormattingEnabled = true;
            this.cmbmedcodesu.Location = new System.Drawing.Point(554, 63);
            this.cmbmedcodesu.Name = "cmbmedcodesu";
            this.cmbmedcodesu.Size = new System.Drawing.Size(152, 24);
            this.cmbmedcodesu.TabIndex = 15;
            // 
            // cmbcomidsu
            // 
            this.cmbcomidsu.FormattingEnabled = true;
            this.cmbcomidsu.Location = new System.Drawing.Point(554, 21);
            this.cmbcomidsu.Name = "cmbcomidsu";
            this.cmbcomidsu.Size = new System.Drawing.Size(152, 24);
            this.cmbcomidsu.TabIndex = 14;
            this.cmbcomidsu.Click += new System.EventHandler(this.cmbcomidsu_Click);
            // 
            // txtsupid
            // 
            this.txtsupid.Location = new System.Drawing.Point(182, 63);
            this.txtsupid.Name = "txtsupid";
            this.txtsupid.Size = new System.Drawing.Size(152, 22);
            this.txtsupid.TabIndex = 11;
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

            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(395, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "Company Id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(395, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 18);
            this.label16.TabIndex = 16;
            this.label16.Text = "Medicine Code";
            // 
            // cmbmedcodesu
            // 
            this.cmbmedcodesu.FormattingEnabled = true;
            this.cmbmedcodesu.Location = new System.Drawing.Point(554, 63);
            this.cmbmedcodesu.Name = "cmbmedcodesu";
            this.cmbmedcodesu.Size = new System.Drawing.Size(152, 24);
            this.cmbmedcodesu.TabIndex = 15;
            // 
            // cmbcomidsu
            // 
            this.cmbcomidsu.FormattingEnabled = true;
            this.cmbcomidsu.Location = new System.Drawing.Point(554, 21);
            this.cmbcomidsu.Name = "cmbcomidsu";
            this.cmbcomidsu.Size = new System.Drawing.Size(152, 24);
            this.cmbcomidsu.TabIndex = 14;
            this.cmbcomidsu.Click += new System.EventHandler(this.cmbcomidsu_Click);
            // 
            // txtsupid
            // 
            this.txtsupid.Location = new System.Drawing.Point(182, 63);
            this.txtsupid.Name = "txtsupid";
            this.txtsupid.Size = new System.Drawing.Size(152, 22);
            this.txtsupid.TabIndex = 11;
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

            this.txtphone.Location = new System.Drawing.Point(554, 107);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(152, 22);
            this.txtphone.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(554, 150);
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
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Supplier Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 151);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.txtfinalamt);
            this.groupBox3.Controls.Add(this.txttotalamt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnremove);
            this.groupBox3.Controls.Add(this.btnlsadd);
            this.groupBox3.Controls.Add(this.lstamount);
            this.groupBox3.Controls.Add(this.lstquantity);
            this.groupBox3.Controls.Add(this.lstprice);
            this.groupBox3.Controls.Add(this.lstmedcode);
            this.groupBox3.Controls.Add(this.lstcompid);
            this.groupBox3.Controls.Add(this.txtutprice);
            this.groupBox3.Controls.Add(this.txtquantity);
            this.groupBox3.Controls.Add(this.txtamt);
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
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(599, 293);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(136, 22);
            this.txtdiscount.TabIndex = 33;

            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);

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
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(783, 166);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(95, 33);
            this.btnremove.TabIndex = 25;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;

            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);

            // 
            // btnlsadd
            // 
            this.btnlsadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlsadd.Location = new System.Drawing.Point(783, 112);
            this.btnlsadd.Name = "btnlsadd";
            this.btnlsadd.Size = new System.Drawing.Size(95, 33);
            this.btnlsadd.TabIndex = 24;
            this.btnlsadd.Text = "Add";
            this.btnlsadd.UseVisualStyleBackColor = true;

            this.btnlsadd.Click += new System.EventHandler(this.btnlsadd_Click);

            // 
            // lstamount
            // 
            this.lstamount.FormattingEnabled = true;
            this.lstamount.ItemHeight = 16;
            this.lstamount.Location = new System.Drawing.Point(628, 98);
            this.lstamount.Name = "lstamount";
            this.lstamount.Size = new System.Drawing.Size(149, 148);
            this.lstamount.TabIndex = 23;

            this.lstamount.SelectedIndexChanged += new System.EventHandler(this.lstamount_SelectedIndexChanged);

            // 
            // lstquantity
            // 
            this.lstquantity.FormattingEnabled = true;
            this.lstquantity.ItemHeight = 16;
            this.lstquantity.Location = new System.Drawing.Point(473, 98);
            this.lstquantity.Name = "lstquantity";
            this.lstquantity.Size = new System.Drawing.Size(149, 148);
            this.lstquantity.TabIndex = 22;

            this.lstquantity.SelectedIndexChanged += new System.EventHandler(this.lstquantity_SelectedIndexChanged);

            // 
            // lstprice
            // 
            this.lstprice.FormattingEnabled = true;
            this.lstprice.ItemHeight = 16;
            this.lstprice.Location = new System.Drawing.Point(318, 98);
            this.lstprice.Name = "lstprice";
            this.lstprice.Size = new System.Drawing.Size(149, 148);
            this.lstprice.TabIndex = 21;

            this.lstprice.SelectedIndexChanged += new System.EventHandler(this.lstprice_SelectedIndexChanged);

            // 
            // lstmedcode
            // 
            this.lstmedcode.FormattingEnabled = true;
            this.lstmedcode.ItemHeight = 16;
            this.lstmedcode.Location = new System.Drawing.Point(163, 98);
            this.lstmedcode.Name = "lstmedcode";
            this.lstmedcode.Size = new System.Drawing.Size(149, 148);
            this.lstmedcode.TabIndex = 20;

            this.lstmedcode.SelectedIndexChanged += new System.EventHandler(this.lstmedcode_SelectedIndexChanged);

            // 
            // lstcompid
            // 
            this.lstcompid.FormattingEnabled = true;
            this.lstcompid.ItemHeight = 16;
            this.lstcompid.Location = new System.Drawing.Point(6, 98);
            this.lstcompid.Name = "lstcompid";
            this.lstcompid.Size = new System.Drawing.Size(149, 148);
            this.lstcompid.TabIndex = 19;

            this.lstcompid.SelectedIndexChanged += new System.EventHandler(this.lstcompid_SelectedIndexChanged);

            // 
            // txtutprice
            // 
            this.txtutprice.Location = new System.Drawing.Point(318, 70);
            this.txtutprice.Name = "txtutprice";
            this.txtutprice.Size = new System.Drawing.Size(133, 22);
            this.txtutprice.TabIndex = 18;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(473, 70);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(133, 22);
            this.txtquantity.TabIndex = 17;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(628, 70);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(137, 22);
            this.txtamt.TabIndex = 16;
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
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Medicine code";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.btnadd);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.btnexit);
            this.groupBox4.Location = new System.Drawing.Point(12, 644);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(884, 67);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
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
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(383, 17);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 33);
            this.btnexit.TabIndex = 25;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);

            // 
            // cmbsupplierid
            // 
            this.cmbsupplierid.FormattingEnabled = true;
            this.cmbsupplierid.Location = new System.Drawing.Point(182, 63);
            this.cmbsupplierid.Name = "cmbsupplierid";
            this.cmbsupplierid.Size = new System.Drawing.Size(152, 24);
            this.cmbsupplierid.TabIndex = 18;

            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 719);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtvounum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsupid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtfinalamt;
        private System.Windows.Forms.TextBox txttotalamt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnlsadd;
        private System.Windows.Forms.ListBox lstamount;
        private System.Windows.Forms.ListBox lstquantity;
        private System.Windows.Forms.ListBox lstprice;
        private System.Windows.Forms.ListBox lstmedcode;
        private System.Windows.Forms.ListBox lstcompid;
        private System.Windows.Forms.TextBox txtutprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.ComboBox cmbmedicinecode;
        private System.Windows.Forms.ComboBox cmbcomid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cmbmedcodesu;
        private System.Windows.Forms.ComboBox cmbcomidsu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbvounum;
        private System.Windows.Forms.ComboBox cmbsupplierid;
    }
}