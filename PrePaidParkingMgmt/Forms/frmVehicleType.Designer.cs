namespace PrePaidParkingMgmt.Forms
{
    partial class frmVehicleType
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btn2Wheel = new System.Windows.Forms.Button();
            this.btnWheeler = new System.Windows.Forms.Button();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBody.Controls.Add(this.btnWheeler);
            this.pnlBody.Controls.Add(this.btn2Wheel);
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1015, 660);
            this.pnlBody.TabIndex = 6;
            // 
            // btn2Wheel
            // 
            this.btn2Wheel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2Wheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btn2Wheel.FlatAppearance.BorderSize = 0;
            this.btn2Wheel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Wheel.Font = new System.Drawing.Font("Roboto", 14.17323F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Wheel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btn2Wheel.Location = new System.Drawing.Point(199, 266);
            this.btn2Wheel.Name = "btn2Wheel";
            this.btn2Wheel.Size = new System.Drawing.Size(164, 138);
            this.btn2Wheel.TabIndex = 8;
            this.btn2Wheel.Text = "2 Wheelers";
            this.btn2Wheel.UseVisualStyleBackColor = false;
            this.btn2Wheel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWheeler
            // 
            this.btnWheeler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWheeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnWheeler.FlatAppearance.BorderSize = 0;
            this.btnWheeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWheeler.Font = new System.Drawing.Font("Roboto", 14.17323F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWheeler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnWheeler.Location = new System.Drawing.Point(636, 266);
            this.btnWheeler.Name = "btnWheeler";
            this.btnWheeler.Size = new System.Drawing.Size(164, 138);
            this.btnWheeler.TabIndex = 8;
            this.btnWheeler.Text = "4 Wheelers";
            this.btnWheeler.UseVisualStyleBackColor = false;
            this.btnWheeler.Click += new System.EventHandler(this.btn4Wheel);
            // 
            // frmVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1015, 660);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVehicleType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVehicleType";
            this.TopMost = true;
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btn2Wheel;
        private System.Windows.Forms.Button btnWheeler;
    }
}