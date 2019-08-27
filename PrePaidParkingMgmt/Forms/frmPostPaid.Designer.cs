namespace PrePaidParkingMgmt.Forms
{
    partial class frmPostPaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostPaid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbInSession = new System.Windows.Forms.ComboBox();
            this.cbInMin = new System.Windows.Forms.ComboBox();
            this.cbInHr = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.pnlSlots = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSlots.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlSlots);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 535);
            this.panel1.TabIndex = 8;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Verdana", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnContinue.Location = new System.Drawing.Point(314, 436);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(387, 53);
            this.btnContinue.TabIndex = 41;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Roboto", 14.17323F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(425, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 32);
            this.label15.TabIndex = 38;
            this.label15.Text = "Post-Paid Booking";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cbInSession);
            this.panel2.Controls.Add(this.cbInMin);
            this.panel2.Controls.Add(this.cbInHr);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(75, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 247);
            this.panel2.TabIndex = 14;
            // 
            // cbInSession
            // 
            this.cbInSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInSession.FormattingEnabled = true;
            this.cbInSession.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbInSession.Location = new System.Drawing.Point(338, 126);
            this.cbInSession.Name = "cbInSession";
            this.cbInSession.Size = new System.Drawing.Size(53, 24);
            this.cbInSession.TabIndex = 34;
            this.cbInSession.Text = "AM";
            // 
            // cbInMin
            // 
            this.cbInMin.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cbInMin.Location = new System.Drawing.Point(257, 126);
            this.cbInMin.Name = "cbInMin";
            this.cbInMin.Size = new System.Drawing.Size(53, 24);
            this.cbInMin.TabIndex = 35;
            this.cbInMin.Text = "MM";
            // 
            // cbInHr
            // 
            this.cbInHr.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cbInHr.Location = new System.Drawing.Point(176, 126);
            this.cbInHr.Name = "cbInHr";
            this.cbInHr.Size = new System.Drawing.Size(53, 24);
            this.cbInHr.TabIndex = 36;
            this.cbInHr.Text = "HH";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(316, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.070867F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(235, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(53, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(307, 23);
            this.label12.TabIndex = 31;
            this.label12.Text = "Minimum Booking Balance : Rs. 50";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto Medium", 10.77165F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(20, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "In-Time";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Roboto Medium", 10.77165F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(54, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Date";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn1.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(41, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 45);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn2.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(104, 39);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 45);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn6.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(41, 101);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 45);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn11.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(41, 168);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(48, 45);
            this.btn11.TabIndex = 0;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn7.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(104, 101);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 45);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn12.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(104, 168);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(48, 45);
            this.btn12.TabIndex = 0;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn3.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(166, 39);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 45);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn13.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(166, 168);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(48, 45);
            this.btn13.TabIndex = 0;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn8.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(166, 101);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 45);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn4.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(229, 39);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 45);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn14.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Location = new System.Drawing.Point(229, 168);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(48, 45);
            this.btn14.TabIndex = 0;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn9.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(229, 101);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 45);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn5.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(291, 39);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 45);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn10.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(291, 101);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(48, 45);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn15.Font = new System.Drawing.Font("Verdana", 10.77165F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(291, 168);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(48, 45);
            this.btn15.TabIndex = 0;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = false;
            // 
            // pnlSlots
            // 
            this.pnlSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSlots.BackColor = System.Drawing.Color.Transparent;
            this.pnlSlots.Controls.Add(this.btn15);
            this.pnlSlots.Controls.Add(this.btn10);
            this.pnlSlots.Controls.Add(this.btn5);
            this.pnlSlots.Controls.Add(this.btn9);
            this.pnlSlots.Controls.Add(this.btn14);
            this.pnlSlots.Controls.Add(this.btn4);
            this.pnlSlots.Controls.Add(this.btn8);
            this.pnlSlots.Controls.Add(this.btn13);
            this.pnlSlots.Controls.Add(this.btn3);
            this.pnlSlots.Controls.Add(this.btn12);
            this.pnlSlots.Controls.Add(this.btn7);
            this.pnlSlots.Controls.Add(this.btn11);
            this.pnlSlots.Controls.Add(this.btn6);
            this.pnlSlots.Controls.Add(this.btn2);
            this.pnlSlots.Controls.Add(this.btn1);
            this.pnlSlots.Location = new System.Drawing.Point(605, 143);
            this.pnlSlots.Name = "pnlSlots";
            this.pnlSlots.Size = new System.Drawing.Size(384, 247);
            this.pnlSlots.TabIndex = 13;
            // 
            // frmPostPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1048, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPostPaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSlots.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbInSession;
        private System.Windows.Forms.ComboBox cbInMin;
        private System.Windows.Forms.ComboBox cbInHr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel pnlSlots;
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
    }
}