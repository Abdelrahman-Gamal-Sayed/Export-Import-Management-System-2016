namespace WindowsFormsApp2
{
    partial class frmBuy
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
            this.label6 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbnSearch = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdite = new System.Windows.Forms.PictureBox();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.PictureBox();
            this.btnLast = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnBrev = new System.Windows.Forms.PictureBox();
            this.txtActionno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlsearch = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPrice = new System.Windows.Forms.RadioButton();
            this.rbtnQTY = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnCustNo = new System.Windows.Forms.RadioButton();
            this.btnshowsearch = new System.Windows.Forms.Button();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            this.btnshowsearch1 = new System.Windows.Forms.PictureBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.rbtnItemName = new System.Windows.Forms.RadioButton();
            this.rbtnItemNo = new System.Windows.Forms.RadioButton();
            this.rbtnCustStartDate = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrev)).BeginInit();
            this.pnlsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshowsearch1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 55);
            this.label6.TabIndex = 35;
            this.label6.Text = "Buy";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(165, 309);
            this.nudQty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(120, 20);
            this.nudQty.TabIndex = 37;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Quantaty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cutomer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbnSearch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnEdite);
            this.panel1.Location = new System.Drawing.Point(16, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 104);
            this.panel1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::WindowsFormsApp2.Properties.Resources.if_plus_sign_173078__1_;
            this.btnAdd.Location = new System.Drawing.Point(9, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 64);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAdd.TabIndex = 23;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Edite";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::WindowsFormsApp2.Properties.Resources.if_login_173049;
            this.btnExit.Location = new System.Drawing.Point(501, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 64);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 18;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Delete";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::WindowsFormsApp2.Properties.Resources.if_simpline_32_2305627;
            this.btnClear.Location = new System.Drawing.Point(404, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 64);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClear.TabIndex = 19;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Search";
            // 
            // tbnSearch
            // 
            this.tbnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnSearch.Image = global::WindowsFormsApp2.Properties.Resources.if_search_173095;
            this.tbnSearch.Location = new System.Drawing.Point(310, 10);
            this.tbnSearch.Name = "tbnSearch";
            this.tbnSearch.Size = new System.Drawing.Size(64, 64);
            this.tbnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tbnSearch.TabIndex = 20;
            this.tbnSearch.TabStop = false;
            this.tbnSearch.Click += new System.EventHandler(this.tbnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Clear";
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Enabled = false;
            this.btnDel.Image = global::WindowsFormsApp2.Properties.Resources.if_trash_173120;
            this.btnDel.Location = new System.Drawing.Point(211, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(64, 64);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDel.TabIndex = 21;
            this.btnDel.TabStop = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Exit";
            // 
            // btnEdite
            // 
            this.btnEdite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdite.Enabled = false;
            this.btnEdite.Image = global::WindowsFormsApp2.Properties.Resources.if_icon_32_clipboard_edit_315153;
            this.btnEdite.Location = new System.Drawing.Point(113, 10);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(64, 64);
            this.btnEdite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEdite.TabIndex = 22;
            this.btnEdite.TabStop = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // cbxCust
            // 
            this.cbxCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(165, 113);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(183, 21);
            this.cbxCust.TabIndex = 39;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(165, 162);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(183, 21);
            this.cbxItem.TabIndex = 40;
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbxDay.Location = new System.Drawing.Point(165, 214);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(183, 21);
            this.cbxDay.TabIndex = 41;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(165, 262);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(96, 20);
            this.dtpDate.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Date";
            // 
            // NudPrice
            // 
            this.NudPrice.Location = new System.Drawing.Point(165, 356);
            this.NudPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NudPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(120, 20);
            this.NudPrice.TabIndex = 45;
            this.NudPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudPrice.ValueChanged += new System.EventHandler(this.NudPrice_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 24);
            this.label13.TabIndex = 44;
            this.label13.Text = "Salary";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 441);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(351, 60);
            this.textBox4.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 461);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 46;
            this.label14.Text = "Details";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(165, 400);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(183, 20);
            this.txttotal.TabIndex = 116;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 399);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 24);
            this.label15.TabIndex = 115;
            this.label15.Text = "Total";
            // 
            // btnFirst
            // 
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.Image = global::WindowsFormsApp2.Properties.Resources.if_resultset_last_36378___Copy;
            this.btnFirst.Location = new System.Drawing.Point(246, 66);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 36);
            this.btnFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFirst.TabIndex = 41;
            this.btnFirst.TabStop = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.Image = global::WindowsFormsApp2.Properties.Resources.if_resultset_last_36378;
            this.btnLast.Location = new System.Drawing.Point(410, 66);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 36);
            this.btnLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLast.TabIndex = 38;
            this.btnLast.TabStop = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = global::WindowsFormsApp2.Properties.Resources.if_next_18847;
            this.btnNext.Location = new System.Drawing.Point(355, 66);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 36);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNext.TabIndex = 39;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBrev
            // 
            this.btnBrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrev.Image = global::WindowsFormsApp2.Properties.Resources.if_next_18847___Copy;
            this.btnBrev.Location = new System.Drawing.Point(299, 66);
            this.btnBrev.Name = "btnBrev";
            this.btnBrev.Size = new System.Drawing.Size(36, 36);
            this.btnBrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBrev.TabIndex = 40;
            this.btnBrev.TabStop = false;
            this.btnBrev.Click += new System.EventHandler(this.btnBrev_Click);
            // 
            // txtActionno
            // 
            this.txtActionno.Location = new System.Drawing.Point(164, 73);
            this.txtActionno.Name = "txtActionno";
            this.txtActionno.ReadOnly = true;
            this.txtActionno.Size = new System.Drawing.Size(65, 20);
            this.txtActionno.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 24);
            this.label16.TabIndex = 30;
            this.label16.Text = "Number";
            // 
            // pnlsearch
            // 
            this.pnlsearch.Controls.Add(this.pictureBox1);
            this.pnlsearch.Controls.Add(this.groupBox1);
            this.pnlsearch.Controls.Add(this.label18);
            this.pnlsearch.Location = new System.Drawing.Point(12, 66);
            this.pnlsearch.Name = "pnlsearch";
            this.pnlsearch.Size = new System.Drawing.Size(957, 565);
            this.pnlsearch.TabIndex = 117;
            this.pnlsearch.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::WindowsFormsApp2.Properties.Resources.if_close2_1814078;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.if_close2_1814078;
            this.pictureBox1.Location = new System.Drawing.Point(901, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPrice);
            this.groupBox1.Controls.Add(this.rbtnQTY);
            this.groupBox1.Controls.Add(this.rbtnDate);
            this.groupBox1.Controls.Add(this.rbtnCustNo);
            this.groupBox1.Controls.Add(this.btnshowsearch);
            this.groupBox1.Controls.Add(this.dgvsearch);
            this.groupBox1.Controls.Add(this.btnshowsearch1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.rbtnDay);
            this.groupBox1.Controls.Add(this.rbtnItemName);
            this.groupBox1.Controls.Add(this.rbtnItemNo);
            this.groupBox1.Controls.Add(this.rbtnCustStartDate);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 490);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // rbtnPrice
            // 
            this.rbtnPrice.AutoSize = true;
            this.rbtnPrice.Location = new System.Drawing.Point(838, 24);
            this.rbtnPrice.Name = "rbtnPrice";
            this.rbtnPrice.Size = new System.Drawing.Size(93, 23);
            this.rbtnPrice.TabIndex = 43;
            this.rbtnPrice.Text = "Quantity";
            this.rbtnPrice.UseVisualStyleBackColor = true;
            // 
            // rbtnQTY
            // 
            this.rbtnQTY.AutoSize = true;
            this.rbtnQTY.Location = new System.Drawing.Point(716, 24);
            this.rbtnQTY.Name = "rbtnQTY";
            this.rbtnQTY.Size = new System.Drawing.Size(93, 23);
            this.rbtnQTY.TabIndex = 42;
            this.rbtnQTY.Text = "Quantity";
            this.rbtnQTY.UseVisualStyleBackColor = true;
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(650, 24);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(60, 23);
            this.rbtnDate.TabIndex = 41;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            // 
            // rbtnCustNo
            // 
            this.rbtnCustNo.AutoSize = true;
            this.rbtnCustNo.Checked = true;
            this.rbtnCustNo.Location = new System.Drawing.Point(15, 25);
            this.rbtnCustNo.Name = "rbtnCustNo";
            this.rbtnCustNo.Size = new System.Drawing.Size(160, 23);
            this.rbtnCustNo.TabIndex = 40;
            this.rbtnCustNo.TabStop = true;
            this.rbtnCustNo.Text = "Customer Number";
            this.rbtnCustNo.UseVisualStyleBackColor = true;
            // 
            // btnshowsearch
            // 
            this.btnshowsearch.AutoEllipsis = true;
            this.btnshowsearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowsearch.Location = new System.Drawing.Point(373, 60);
            this.btnshowsearch.Name = "btnshowsearch";
            this.btnshowsearch.Size = new System.Drawing.Size(97, 27);
            this.btnshowsearch.TabIndex = 39;
            this.btnshowsearch.Text = "search";
            this.btnshowsearch.UseVisualStyleBackColor = true;
            this.btnshowsearch.Click += new System.EventHandler(this.btnshowsearch_Click);
            // 
            // dgvsearch
            // 
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearch.Location = new System.Drawing.Point(2, 93);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.Size = new System.Drawing.Size(929, 393);
            this.dgvsearch.TabIndex = 38;
            // 
            // btnshowsearch1
            // 
            this.btnshowsearch1.BackColor = System.Drawing.Color.White;
            this.btnshowsearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowsearch1.Image = global::WindowsFormsApp2.Properties.Resources.if_search_173095__1_;
            this.btnshowsearch1.Location = new System.Drawing.Point(326, 62);
            this.btnshowsearch1.Name = "btnshowsearch1";
            this.btnshowsearch1.Size = new System.Drawing.Size(22, 22);
            this.btnshowsearch1.TabIndex = 37;
            this.btnshowsearch1.TabStop = false;
            this.btnshowsearch1.Click += new System.EventHandler(this.btnshowsearch1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(82, 60);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(268, 27);
            this.txtsearch.TabIndex = 36;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 24);
            this.label19.TabIndex = 35;
            this.label19.Text = "Search";
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Location = new System.Drawing.Point(589, 24);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(55, 23);
            this.rbtnDay.TabIndex = 4;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // rbtnItemName
            // 
            this.rbtnItemName.AutoSize = true;
            this.rbtnItemName.Location = new System.Drawing.Point(475, 24);
            this.rbtnItemName.Name = "rbtnItemName";
            this.rbtnItemName.Size = new System.Drawing.Size(108, 23);
            this.rbtnItemName.TabIndex = 3;
            this.rbtnItemName.Text = "Item Name";
            this.rbtnItemName.UseVisualStyleBackColor = true;
            // 
            // rbtnItemNo
            // 
            this.rbtnItemNo.AutoSize = true;
            this.rbtnItemNo.Location = new System.Drawing.Point(345, 24);
            this.rbtnItemNo.Name = "rbtnItemNo";
            this.rbtnItemNo.Size = new System.Drawing.Size(124, 23);
            this.rbtnItemNo.TabIndex = 2;
            this.rbtnItemNo.Text = "item Number";
            this.rbtnItemNo.UseVisualStyleBackColor = true;
            // 
            // rbtnCustStartDate
            // 
            this.rbtnCustStartDate.AutoSize = true;
            this.rbtnCustStartDate.Location = new System.Drawing.Point(195, 24);
            this.rbtnCustStartDate.Name = "rbtnCustStartDate";
            this.rbtnCustStartDate.Size = new System.Drawing.Size(144, 23);
            this.rbtnCustStartDate.TabIndex = 1;
            this.rbtnCustStartDate.Text = "Customer Name";
            this.rbtnCustStartDate.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(368, 39);
            this.label18.TabIndex = 35;
            this.label18.Text = "Search For Customer";
            // 
            // frmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 670);
            this.Controls.Add(this.pnlsearch);
            this.Controls.Add(this.txtActionno);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBrev);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NudPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.cbxCust);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBuy";
            this.Text = "Buy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrev)).EndInit();
            this.pnlsearch.ResumeLayout(false);
            this.pnlsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshowsearch1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox tbnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnDel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnEdite;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox btnFirst;
        private System.Windows.Forms.PictureBox btnLast;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnBrev;
        private System.Windows.Forms.TextBox txtActionno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnPrice;
        private System.Windows.Forms.RadioButton rbtnQTY;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnCustNo;
        private System.Windows.Forms.Button btnshowsearch;
        private System.Windows.Forms.DataGridView dgvsearch;
        private System.Windows.Forms.PictureBox btnshowsearch1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.RadioButton rbtnItemName;
        private System.Windows.Forms.RadioButton rbtnItemNo;
        private System.Windows.Forms.RadioButton rbtnCustStartDate;
        private System.Windows.Forms.Label label18;
    }
}