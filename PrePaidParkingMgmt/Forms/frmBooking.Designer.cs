namespace PrePaidParkingMgmt.Forms
{
    partial class frmBooking
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlPostPaid = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbInHr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbInMin = new System.Windows.Forms.ComboBox();
            this.cbOutHr = new System.Windows.Forms.ComboBox();
            this.cbInSession = new System.Windows.Forms.ComboBox();
            this.cbOutMin = new System.Windows.Forms.ComboBox();
            this.cbOutSession = new System.Windows.Forms.ComboBox();
            this.pnlPrePaid = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.pnlPostPaid.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPrePaid.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.cbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.cbType.IntegralHeight = false;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Post-Paid",
            "Pre-Paid"});
            this.cbType.Location = new System.Drawing.Point(0, 0);
            this.cbType.MaxDropDownItems = 2;
            this.cbType.Name = "cbType";
            this.cbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbType.Size = new System.Drawing.Size(1015, 31);
            this.cbType.TabIndex = 5;
            this.cbType.Text = "Please Select Mode";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Verdana", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnContinue.Location = new System.Drawing.Point(0, 612);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(1015, 48);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 14.17323F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(376, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 32);
            this.label15.TabIndex = 27;
            this.label15.Text = "Post-Paid Booking";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(332, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 22);
            this.label14.TabIndex = 9;
            this.label14.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(298, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 22);
            this.label13.TabIndex = 8;
            this.label13.Text = "In-Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(454, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Minimum Booking Balance : Rs. 50";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn15);
            this.panel4.Controls.Add(this.btn10);
            this.panel4.Controls.Add(this.btn5);
            this.panel4.Controls.Add(this.btn9);
            this.panel4.Controls.Add(this.btn14);
            this.panel4.Controls.Add(this.btn4);
            this.panel4.Controls.Add(this.btn8);
            this.panel4.Controls.Add(this.btn13);
            this.panel4.Controls.Add(this.btn3);
            this.panel4.Controls.Add(this.btn12);
            this.panel4.Controls.Add(this.btn7);
            this.panel4.Controls.Add(this.btn11);
            this.panel4.Controls.Add(this.btn6);
            this.panel4.Controls.Add(this.btn2);
            this.panel4.Controls.Add(this.btn1);
            this.panel4.Location = new System.Drawing.Point(300, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 228);
            this.panel4.TabIndex = 13;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn15.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(285, 154);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(48, 45);
            this.btn15.TabIndex = 0;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn10.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(285, 87);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(48, 45);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn5.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(285, 25);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 45);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn9.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(223, 87);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 45);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn14.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Location = new System.Drawing.Point(223, 154);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(48, 45);
            this.btn14.TabIndex = 0;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn4.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(223, 25);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 45);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn8.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(160, 87);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 45);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn13.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(160, 154);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(48, 45);
            this.btn13.TabIndex = 0;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn3.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(160, 25);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 45);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn12.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(98, 154);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(48, 45);
            this.btn12.TabIndex = 0;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn7.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(98, 87);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 45);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn11.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(35, 154);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(48, 45);
            this.btn11.TabIndex = 0;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn6.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(35, 87);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 45);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn2.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(98, 25);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 45);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn1.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(35, 25);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 45);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(513, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(594, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(454, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 22);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.Text = "HH";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(535, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(53, 22);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.Text = "MM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox1.Location = new System.Drawing.Point(616, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 22);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "AM";
            // 
            // pnlPostPaid
            // 
            this.pnlPostPaid.Controls.Add(this.comboBox1);
            this.pnlPostPaid.Controls.Add(this.comboBox2);
            this.pnlPostPaid.Controls.Add(this.comboBox3);
            this.pnlPostPaid.Controls.Add(this.label10);
            this.pnlPostPaid.Controls.Add(this.label11);
            this.pnlPostPaid.Controls.Add(this.panel4);
            this.pnlPostPaid.Controls.Add(this.label12);
            this.pnlPostPaid.Controls.Add(this.dateTimePicker2);
            this.pnlPostPaid.Controls.Add(this.label13);
            this.pnlPostPaid.Controls.Add(this.label14);
            this.pnlPostPaid.Controls.Add(this.label15);
            this.pnlPostPaid.Location = new System.Drawing.Point(21, 61);
            this.pnlPostPaid.Name = "pnlPostPaid";
            this.pnlPostPaid.Size = new System.Drawing.Size(972, 477);
            this.pnlPostPaid.TabIndex = 9;
            this.pnlPostPaid.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.slt15);
            this.panel3.Controls.Add(this.slt10);
            this.panel3.Controls.Add(this.slt5);
            this.panel3.Controls.Add(this.slt9);
            this.panel3.Controls.Add(this.slt14);
            this.panel3.Controls.Add(this.slt4);
            this.panel3.Controls.Add(this.slt8);
            this.panel3.Controls.Add(this.slt13);
            this.panel3.Controls.Add(this.slt3);
            this.panel3.Controls.Add(this.slt12);
            this.panel3.Controls.Add(this.slt7);
            this.panel3.Controls.Add(this.slt11);
            this.panel3.Controls.Add(this.slt6);
            this.panel3.Controls.Add(this.slt2);
            this.panel3.Controls.Add(this.slt1);
            this.panel3.Location = new System.Drawing.Point(309, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 200);
            this.panel3.TabIndex = 29;
            // 
            // slt15
            // 
            this.slt15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt15.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt15.Location = new System.Drawing.Point(283, 134);
            this.slt15.Name = "slt15";
            this.slt15.Size = new System.Drawing.Size(48, 39);
            this.slt15.TabIndex = 0;
            this.slt15.Text = "15";
            this.slt15.UseVisualStyleBackColor = false;
            // 
            // slt10
            // 
            this.slt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt10.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt10.Location = new System.Drawing.Point(283, 78);
            this.slt10.Name = "slt10";
            this.slt10.Size = new System.Drawing.Size(48, 39);
            this.slt10.TabIndex = 0;
            this.slt10.Text = "10";
            this.slt10.UseVisualStyleBackColor = false;
            // 
            // slt5
            // 
            this.slt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt5.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt5.Location = new System.Drawing.Point(283, 22);
            this.slt5.Name = "slt5";
            this.slt5.Size = new System.Drawing.Size(48, 39);
            this.slt5.TabIndex = 0;
            this.slt5.Text = "5";
            this.slt5.UseVisualStyleBackColor = false;
            // 
            // slt9
            // 
            this.slt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt9.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt9.Location = new System.Drawing.Point(221, 78);
            this.slt9.Name = "slt9";
            this.slt9.Size = new System.Drawing.Size(48, 39);
            this.slt9.TabIndex = 0;
            this.slt9.Text = "9";
            this.slt9.UseVisualStyleBackColor = false;
            // 
            // slt14
            // 
            this.slt14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt14.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt14.Location = new System.Drawing.Point(221, 134);
            this.slt14.Name = "slt14";
            this.slt14.Size = new System.Drawing.Size(48, 39);
            this.slt14.TabIndex = 0;
            this.slt14.Text = "14";
            this.slt14.UseVisualStyleBackColor = false;
            // 
            // slt4
            // 
            this.slt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt4.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt4.Location = new System.Drawing.Point(221, 22);
            this.slt4.Name = "slt4";
            this.slt4.Size = new System.Drawing.Size(48, 39);
            this.slt4.TabIndex = 0;
            this.slt4.Text = "4";
            this.slt4.UseVisualStyleBackColor = false;
            // 
            // slt8
            // 
            this.slt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt8.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt8.Location = new System.Drawing.Point(159, 78);
            this.slt8.Name = "slt8";
            this.slt8.Size = new System.Drawing.Size(48, 39);
            this.slt8.TabIndex = 0;
            this.slt8.Text = "8";
            this.slt8.UseVisualStyleBackColor = false;
            // 
            // slt13
            // 
            this.slt13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt13.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt13.Location = new System.Drawing.Point(159, 134);
            this.slt13.Name = "slt13";
            this.slt13.Size = new System.Drawing.Size(48, 39);
            this.slt13.TabIndex = 0;
            this.slt13.Text = "13";
            this.slt13.UseVisualStyleBackColor = false;
            // 
            // slt3
            // 
            this.slt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt3.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt3.Location = new System.Drawing.Point(159, 22);
            this.slt3.Name = "slt3";
            this.slt3.Size = new System.Drawing.Size(48, 39);
            this.slt3.TabIndex = 0;
            this.slt3.Text = "3";
            this.slt3.UseVisualStyleBackColor = false;
            // 
            // slt12
            // 
            this.slt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt12.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt12.Location = new System.Drawing.Point(97, 134);
            this.slt12.Name = "slt12";
            this.slt12.Size = new System.Drawing.Size(48, 39);
            this.slt12.TabIndex = 0;
            this.slt12.Text = "12";
            this.slt12.UseVisualStyleBackColor = false;
            // 
            // slt7
            // 
            this.slt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt7.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt7.Location = new System.Drawing.Point(97, 78);
            this.slt7.Name = "slt7";
            this.slt7.Size = new System.Drawing.Size(48, 39);
            this.slt7.TabIndex = 0;
            this.slt7.Text = "7";
            this.slt7.UseVisualStyleBackColor = false;
            // 
            // slt11
            // 
            this.slt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt11.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt11.Location = new System.Drawing.Point(35, 134);
            this.slt11.Name = "slt11";
            this.slt11.Size = new System.Drawing.Size(48, 39);
            this.slt11.TabIndex = 0;
            this.slt11.Text = "11";
            this.slt11.UseVisualStyleBackColor = false;
            // 
            // slt6
            // 
            this.slt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt6.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt6.Location = new System.Drawing.Point(35, 78);
            this.slt6.Name = "slt6";
            this.slt6.Size = new System.Drawing.Size(48, 39);
            this.slt6.TabIndex = 0;
            this.slt6.Text = "6";
            this.slt6.UseVisualStyleBackColor = false;
            // 
            // slt2
            // 
            this.slt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt2.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt2.Location = new System.Drawing.Point(97, 22);
            this.slt2.Name = "slt2";
            this.slt2.Size = new System.Drawing.Size(48, 39);
            this.slt2.TabIndex = 0;
            this.slt2.Text = "2";
            this.slt2.UseVisualStyleBackColor = false;
            // 
            // slt1
            // 
            this.slt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slt1.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slt1.Location = new System.Drawing.Point(35, 22);
            this.slt1.Name = "slt1";
            this.slt1.Size = new System.Drawing.Size(48, 39);
            this.slt1.TabIndex = 0;
            this.slt1.Text = "1";
            this.slt1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "In-Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Out-Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.20472F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Rate/Hr : Rs. 20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.17323F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "Pre-Paid Booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            // 
            // cbInHr
            // 
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
            this.cbInHr.Location = new System.Drawing.Point(481, 104);
            this.cbInHr.Name = "cbInHr";
            this.cbInHr.Size = new System.Drawing.Size(53, 22);
            this.cbInHr.TabIndex = 39;
            this.cbInHr.Text = "HH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = ":";
            // 
            // cbInMin
            // 
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
            this.cbInMin.Location = new System.Drawing.Point(562, 104);
            this.cbInMin.Name = "cbInMin";
            this.cbInMin.Size = new System.Drawing.Size(53, 22);
            this.cbInMin.TabIndex = 38;
            this.cbInMin.Text = "MM";
            // 
            // cbOutHr
            // 
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
            this.cbOutHr.Location = new System.Drawing.Point(481, 137);
            this.cbOutHr.Name = "cbOutHr";
            this.cbOutHr.Size = new System.Drawing.Size(53, 22);
            this.cbOutHr.TabIndex = 37;
            this.cbOutHr.Text = "HH";
            // 
            // cbInSession
            // 
            this.cbInSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInSession.FormattingEnabled = true;
            this.cbInSession.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbInSession.Location = new System.Drawing.Point(643, 104);
            this.cbInSession.Name = "cbInSession";
            this.cbInSession.Size = new System.Drawing.Size(53, 22);
            this.cbInSession.TabIndex = 36;
            this.cbInSession.Text = "AM";
            // 
            // cbOutMin
            // 
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
            this.cbOutMin.Location = new System.Drawing.Point(562, 137);
            this.cbOutMin.Name = "cbOutMin";
            this.cbOutMin.Size = new System.Drawing.Size(53, 22);
            this.cbOutMin.TabIndex = 35;
            this.cbOutMin.Text = "MM";
            // 
            // cbOutSession
            // 
            this.cbOutSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOutSession.FormattingEnabled = true;
            this.cbOutSession.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbOutSession.Location = new System.Drawing.Point(643, 137);
            this.cbOutSession.Name = "cbOutSession";
            this.cbOutSession.Size = new System.Drawing.Size(53, 22);
            this.cbOutSession.TabIndex = 34;
            this.cbOutSession.Text = "AM";
            // 
            // pnlPrePaid
            // 
            this.pnlPrePaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrePaid.Controls.Add(this.cbOutSession);
            this.pnlPrePaid.Controls.Add(this.cbOutMin);
            this.pnlPrePaid.Controls.Add(this.cbInSession);
            this.pnlPrePaid.Controls.Add(this.cbOutHr);
            this.pnlPrePaid.Controls.Add(this.cbInMin);
            this.pnlPrePaid.Controls.Add(this.label7);
            this.pnlPrePaid.Controls.Add(this.cbInHr);
            this.pnlPrePaid.Controls.Add(this.label6);
            this.pnlPrePaid.Controls.Add(this.label5);
            this.pnlPrePaid.Controls.Add(this.label4);
            this.pnlPrePaid.Controls.Add(this.label9);
            this.pnlPrePaid.Controls.Add(this.label8);
            this.pnlPrePaid.Controls.Add(this.label3);
            this.pnlPrePaid.Controls.Add(this.dateTimePicker1);
            this.pnlPrePaid.Controls.Add(this.label2);
            this.pnlPrePaid.Controls.Add(this.label1);
            this.pnlPrePaid.Controls.Add(this.panel3);
            this.pnlPrePaid.Location = new System.Drawing.Point(21, 119);
            this.pnlPrePaid.Name = "pnlPrePaid";
            this.pnlPrePaid.Size = new System.Drawing.Size(972, 477);
            this.pnlPrePaid.TabIndex = 11;
            this.pnlPrePaid.Visible = false;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1015, 660);
            this.Controls.Add(this.pnlPrePaid);
            this.Controls.Add(this.pnlPostPaid);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnContinue);
            this.Font = new System.Drawing.Font("Verdana", 6.80315F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.panel4.ResumeLayout(false);
            this.pnlPostPaid.ResumeLayout(false);
            this.pnlPostPaid.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlPrePaid.ResumeLayout(false);
            this.pnlPrePaid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlPostPaid;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbInHr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbInMin;
        private System.Windows.Forms.ComboBox cbOutHr;
        private System.Windows.Forms.ComboBox cbInSession;
        private System.Windows.Forms.ComboBox cbOutMin;
        private System.Windows.Forms.ComboBox cbOutSession;
        private System.Windows.Forms.Panel pnlPrePaid;
    }
}