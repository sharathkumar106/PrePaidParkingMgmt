namespace PrePaidParkingMgmt.Forms
{
    partial class frmPrePaid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.cbOutSession = new System.Windows.Forms.ComboBox();
            this.cbOutMin = new System.Windows.Forms.ComboBox();
            this.cbInSession = new System.Windows.Forms.ComboBox();
            this.cbOutHr = new System.Windows.Forms.ComboBox();
            this.cbInMin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbInHr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSlots = new System.Windows.Forms.Panel();
            this.slt15 = new System.Windows.Forms.Button();
            this.slt10 = new System.Windows.Forms.Button();
            this.slt5 = new System.Windows.Forms.Button();
            this.slt9 = new System.Windows.Forms.Button();
            this.slt14 = new System.Windows.Forms.Button();
            this.slt4 = new System.Windows.Forms.Button();
            this.slt8 = new System.Windows.Forms.Button();
            this.slt13 = new System.Windows.Forms.Button();
            this.slt3 = new System.Windows.Forms.Button();
            this.slt12 = new System.Windows.Forms.Button();
            this.slt7 = new System.Windows.Forms.Button();
            this.slt11 = new System.Windows.Forms.Button();
            this.slt6 = new System.Windows.Forms.Button();
            this.slt2 = new System.Windows.Forms.Button();
            this.slt1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSlots.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 593);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Controls.Add(this.cbOutSession);
            this.panel2.Controls.Add(this.cbOutMin);
            this.panel2.Controls.Add(this.cbInSession);
            this.panel2.Controls.Add(this.cbOutHr);
            this.panel2.Controls.Add(this.cbInMin);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbInHr);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pnlSlots);
            this.panel2.Location = new System.Drawing.Point(146, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 551);
            this.panel2.TabIndex = 8;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Verdana", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnContinue.Location = new System.Drawing.Point(217, 492);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(387, 53);
            this.btnContinue.TabIndex = 40;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // cbOutSession
            // 
            this.cbOutSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOutSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOutSession.FormattingEnabled = true;
            this.cbOutSession.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbOutSession.Location = new System.Drawing.Point(547, 161);
            this.cbOutSession.Name = "cbOutSession";
            this.cbOutSession.Size = new System.Drawing.Size(53, 24);
            this.cbOutSession.TabIndex = 34;
            this.cbOutSession.Text = "AM";
            // 
            // cbOutMin
            // 
            this.cbOutMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOutMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOutMin.FormattingEnabled = true;
            this.cbOutMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbOutMin.Location = new System.Drawing.Point(466, 161);
            this.cbOutMin.Name = "cbOutMin";
            this.cbOutMin.Size = new System.Drawing.Size(53, 24);
            this.cbOutMin.TabIndex = 35;
            this.cbOutMin.Text = "MM";
            // 
            // cbInSession
            // 
            this.cbInSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInSession.FormattingEnabled = true;
            this.cbInSession.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbInSession.Location = new System.Drawing.Point(547, 128);
            this.cbInSession.Name = "cbInSession";
            this.cbInSession.Size = new System.Drawing.Size(53, 24);
            this.cbInSession.TabIndex = 36;
            this.cbInSession.Text = "AM";
            // 
            // cbOutHr
            // 
            this.cbOutHr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOutHr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOutHr.FormattingEnabled = true;
            this.cbOutHr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbOutHr.Location = new System.Drawing.Point(385, 161);
            this.cbOutHr.Name = "cbOutHr";
            this.cbOutHr.Size = new System.Drawing.Size(53, 24);
            this.cbOutHr.TabIndex = 37;
            this.cbOutHr.Text = "HH";
            // 
            // cbInMin
            // 
            this.cbInMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInMin.FormattingEnabled = true;
            this.cbInMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbInMin.Location = new System.Drawing.Point(466, 128);
            this.cbInMin.Name = "cbInMin";
            this.cbInMin.Size = new System.Drawing.Size(53, 24);
            this.cbInMin.TabIndex = 38;
            this.cbInMin.Text = "MM";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = ":";
            // 
            // cbInHr
            // 
            this.cbInHr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInHr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInHr.FormattingEnabled = true;
            this.cbInHr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbInHr.Location = new System.Drawing.Point(385, 128);
            this.cbInHr.Name = "cbInHr";
            this.cbInHr.Size = new System.Drawing.Size(53, 24);
            this.cbInHr.TabIndex = 39;
            this.cbInHr.Text = "HH";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = ":";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Roboto", 18.14173F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 38);
            this.label9.TabIndex = 27;
            this.label9.Text = "Pre-Paid Booking";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Rate/Hr : Rs. 20";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Out-Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "In-Time";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date";
            // 
            // pnlSlots
            // 
            this.pnlSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSlots.Controls.Add(this.slt15);
            this.pnlSlots.Controls.Add(this.slt10);
            this.pnlSlots.Controls.Add(this.slt5);
            this.pnlSlots.Controls.Add(this.slt9);
            this.pnlSlots.Controls.Add(this.slt14);
            this.pnlSlots.Controls.Add(this.slt4);
            this.pnlSlots.Controls.Add(this.slt8);
            this.pnlSlots.Controls.Add(this.slt13);
            this.pnlSlots.Controls.Add(this.slt3);
            this.pnlSlots.Controls.Add(this.slt12);
            this.pnlSlots.Controls.Add(this.slt7);
            this.pnlSlots.Controls.Add(this.slt11);
            this.pnlSlots.Controls.Add(this.slt6);
            this.pnlSlots.Controls.Add(this.slt2);
            this.pnlSlots.Controls.Add(this.slt1);
            this.pnlSlots.Location = new System.Drawing.Point(217, 271);
            this.pnlSlots.Name = "pnlSlots";
            this.pnlSlots.Size = new System.Drawing.Size(387, 200);
            this.pnlSlots.TabIndex = 29;
            // 
            // slt15
            // 
            this.slt15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt15.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt15.Location = new System.Drawing.Point(293, 136);
            this.slt15.Name = "slt15";
            this.slt15.Size = new System.Drawing.Size(48, 39);
            this.slt15.TabIndex = 0;
            this.slt15.Text = "15";
            this.slt15.UseVisualStyleBackColor = false;
            this.slt15.Click += new System.EventHandler(this.slt15_Click);
            // 
            // slt10
            // 
            this.slt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt10.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt10.Location = new System.Drawing.Point(293, 80);
            this.slt10.Name = "slt10";
            this.slt10.Size = new System.Drawing.Size(48, 39);
            this.slt10.TabIndex = 0;
            this.slt10.Text = "10";
            this.slt10.UseVisualStyleBackColor = false;
            this.slt10.Click += new System.EventHandler(this.slt10_Click);
            // 
            // slt5
            // 
            this.slt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt5.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt5.Location = new System.Drawing.Point(293, 24);
            this.slt5.Name = "slt5";
            this.slt5.Size = new System.Drawing.Size(48, 39);
            this.slt5.TabIndex = 0;
            this.slt5.Text = "5";
            this.slt5.UseVisualStyleBackColor = false;
            this.slt5.Click += new System.EventHandler(this.slt5_Click);
            // 
            // slt9
            // 
            this.slt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt9.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt9.Location = new System.Drawing.Point(231, 80);
            this.slt9.Name = "slt9";
            this.slt9.Size = new System.Drawing.Size(48, 39);
            this.slt9.TabIndex = 0;
            this.slt9.Text = "9";
            this.slt9.UseVisualStyleBackColor = false;
            this.slt9.Click += new System.EventHandler(this.slt9_Click);
            // 
            // slt14
            // 
            this.slt14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt14.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt14.Location = new System.Drawing.Point(231, 136);
            this.slt14.Name = "slt14";
            this.slt14.Size = new System.Drawing.Size(48, 39);
            this.slt14.TabIndex = 0;
            this.slt14.Text = "14";
            this.slt14.UseVisualStyleBackColor = false;
            this.slt14.Click += new System.EventHandler(this.slt14_Click);
            // 
            // slt4
            // 
            this.slt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt4.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt4.Location = new System.Drawing.Point(231, 24);
            this.slt4.Name = "slt4";
            this.slt4.Size = new System.Drawing.Size(48, 39);
            this.slt4.TabIndex = 0;
            this.slt4.Text = "4";
            this.slt4.UseVisualStyleBackColor = false;
            this.slt4.Click += new System.EventHandler(this.slt4_Click);
            // 
            // slt8
            // 
            this.slt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt8.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt8.Location = new System.Drawing.Point(169, 80);
            this.slt8.Name = "slt8";
            this.slt8.Size = new System.Drawing.Size(48, 39);
            this.slt8.TabIndex = 0;
            this.slt8.Text = "8";
            this.slt8.UseVisualStyleBackColor = false;
            this.slt8.Click += new System.EventHandler(this.slt8_Click);
            // 
            // slt13
            // 
            this.slt13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt13.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt13.Location = new System.Drawing.Point(169, 136);
            this.slt13.Name = "slt13";
            this.slt13.Size = new System.Drawing.Size(48, 39);
            this.slt13.TabIndex = 0;
            this.slt13.Text = "13";
            this.slt13.UseVisualStyleBackColor = false;
            this.slt13.Click += new System.EventHandler(this.slt13_Click);
            // 
            // slt3
            // 
            this.slt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt3.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt3.Location = new System.Drawing.Point(169, 24);
            this.slt3.Name = "slt3";
            this.slt3.Size = new System.Drawing.Size(48, 39);
            this.slt3.TabIndex = 0;
            this.slt3.Text = "3";
            this.slt3.UseVisualStyleBackColor = false;
            this.slt3.Click += new System.EventHandler(this.slt3_Click);
            // 
            // slt12
            // 
            this.slt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt12.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt12.Location = new System.Drawing.Point(107, 136);
            this.slt12.Name = "slt12";
            this.slt12.Size = new System.Drawing.Size(48, 39);
            this.slt12.TabIndex = 0;
            this.slt12.Text = "12";
            this.slt12.UseVisualStyleBackColor = false;
            this.slt12.Click += new System.EventHandler(this.slt12_Click);
            // 
            // slt7
            // 
            this.slt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt7.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt7.Location = new System.Drawing.Point(107, 80);
            this.slt7.Name = "slt7";
            this.slt7.Size = new System.Drawing.Size(48, 39);
            this.slt7.TabIndex = 0;
            this.slt7.Text = "7";
            this.slt7.UseVisualStyleBackColor = false;
            this.slt7.Click += new System.EventHandler(this.slt7_Click);
            // 
            // slt11
            // 
            this.slt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt11.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt11.Location = new System.Drawing.Point(45, 136);
            this.slt11.Name = "slt11";
            this.slt11.Size = new System.Drawing.Size(48, 39);
            this.slt11.TabIndex = 0;
            this.slt11.Text = "11";
            this.slt11.UseVisualStyleBackColor = false;
            this.slt11.Click += new System.EventHandler(this.slt11_Click);
            // 
            // slt6
            // 
            this.slt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt6.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt6.Location = new System.Drawing.Point(45, 80);
            this.slt6.Name = "slt6";
            this.slt6.Size = new System.Drawing.Size(48, 39);
            this.slt6.TabIndex = 0;
            this.slt6.Text = "6";
            this.slt6.UseVisualStyleBackColor = false;
            this.slt6.Click += new System.EventHandler(this.slt6_Click);
            // 
            // slt2
            // 
            this.slt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt2.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt2.Location = new System.Drawing.Point(107, 24);
            this.slt2.Name = "slt2";
            this.slt2.Size = new System.Drawing.Size(48, 39);
            this.slt2.TabIndex = 0;
            this.slt2.Text = "2";
            this.slt2.UseVisualStyleBackColor = false;
            this.slt2.Click += new System.EventHandler(this.slt2_Click);
            // 
            // slt1
            // 
            this.slt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt1.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt1.Location = new System.Drawing.Point(45, 24);
            this.slt1.Name = "slt1";
            this.slt1.Size = new System.Drawing.Size(48, 39);
            this.slt1.TabIndex = 0;
            this.slt1.Text = "1";
            this.slt1.UseVisualStyleBackColor = false;
            this.slt1.Click += new System.EventHandler(this.slt1_Click);
            // 
            // frmPrePaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1116, 593);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrePaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPostPaidBooking";
            this.Load += new System.EventHandler(this.frmPrePaid_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSlots.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbOutSession;
        private System.Windows.Forms.ComboBox cbOutMin;
        private System.Windows.Forms.ComboBox cbInSession;
        private System.Windows.Forms.ComboBox cbOutHr;
        private System.Windows.Forms.ComboBox cbInMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbInHr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSlots;
        private System.Windows.Forms.Button slt15;
        private System.Windows.Forms.Button slt10;
        private System.Windows.Forms.Button slt5;
        private System.Windows.Forms.Button slt9;
        private System.Windows.Forms.Button slt14;
        private System.Windows.Forms.Button slt4;
        private System.Windows.Forms.Button slt8;
        private System.Windows.Forms.Button slt13;
        private System.Windows.Forms.Button slt3;
        private System.Windows.Forms.Button slt12;
        private System.Windows.Forms.Button slt7;
        private System.Windows.Forms.Button slt11;
        private System.Windows.Forms.Button slt6;
        private System.Windows.Forms.Button slt2;
        private System.Windows.Forms.Button slt1;
        private System.Windows.Forms.Button btnContinue;
    }
}