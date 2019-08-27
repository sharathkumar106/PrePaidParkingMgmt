namespace PrePaidParkingMgmt.Forms
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkTAC = new System.Windows.Forms.CheckBox();
            this.pnlUserIcon = new System.Windows.Forms.Panel();
            this.pnlPassIcon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnGuest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tipUsername = new System.Windows.Forms.ToolTip(this.components);
            this.tipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtUsername.Location = new System.Drawing.Point(77, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(379, 22);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtPassword.Location = new System.Drawing.Point(77, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(379, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.panel8.Location = new System.Drawing.Point(77, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(379, 2);
            this.panel8.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.panel7.Location = new System.Drawing.Point(77, 153);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(379, 2);
            this.panel7.TabIndex = 11;
            // 
            // btnSignin
            // 
            this.btnSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.FlatAppearance.BorderSize = 0;
            this.btnSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Roboto Medium", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnSignin.Location = new System.Drawing.Point(33, 233);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(423, 38);
            this.btnSignin.TabIndex = 10;
            this.btnSignin.Text = "SIGN IN";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.Navy;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Roboto Medium", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnRegister.Location = new System.Drawing.Point(33, 314);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(423, 38);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkTAC
            // 
            this.chkTAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTAC.FlatAppearance.BorderSize = 0;
            this.chkTAC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.chkTAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.chkTAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTAC.Font = new System.Drawing.Font("Roboto", 9.070867F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.chkTAC.Location = new System.Drawing.Point(115, 189);
            this.chkTAC.Name = "chkTAC";
            this.chkTAC.Size = new System.Drawing.Size(276, 26);
            this.chkTAC.TabIndex = 9;
            this.chkTAC.Text = "I agree to Terms and Conditions.";
            this.chkTAC.UseVisualStyleBackColor = true;
            // 
            // pnlUserIcon
            // 
            this.pnlUserIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUserIcon.AutoSize = true;
            this.pnlUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserIcon.BackgroundImage = global::PrePaidParkingMgmt.Properties.Resources.icons8_Male_User_32;
            this.pnlUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUserIcon.Location = new System.Drawing.Point(33, 46);
            this.pnlUserIcon.Name = "pnlUserIcon";
            this.pnlUserIcon.Size = new System.Drawing.Size(38, 41);
            this.pnlUserIcon.TabIndex = 15;
            // 
            // pnlPassIcon
            // 
            this.pnlPassIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPassIcon.AutoSize = true;
            this.pnlPassIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlPassIcon.BackgroundImage = global::PrePaidParkingMgmt.Properties.Resources.icons8_Key_32;
            this.pnlPassIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPassIcon.Location = new System.Drawing.Point(33, 115);
            this.pnlPassIcon.Name = "pnlPassIcon";
            this.pnlPassIcon.Size = new System.Drawing.Size(38, 41);
            this.pnlPassIcon.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 10.77165F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "OR";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.pnlLogin.Controls.Add(this.btnGuest);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.panel3);
            this.pnlLogin.Controls.Add(this.pnlPassIcon);
            this.pnlLogin.Controls.Add(this.pnlUserIcon);
            this.pnlLogin.Controls.Add(this.chkTAC);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.btnSignin);
            this.pnlLogin.Controls.Add(this.panel7);
            this.pnlLogin.Controls.Add(this.panel8);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Location = new System.Drawing.Point(281, 94);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(482, 483);
            this.pnlLogin.TabIndex = 6;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // btnGuest
            // 
            this.btnGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuest.FlatAppearance.BorderSize = 0;
            this.btnGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Roboto Medium", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnGuest.Location = new System.Drawing.Point(33, 431);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(423, 38);
            this.btnGuest.TabIndex = 12;
            this.btnGuest.Text = "Continue as Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.panel1.Location = new System.Drawing.Point(33, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 2);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.panel3.Location = new System.Drawing.Point(267, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 2);
            this.panel3.TabIndex = 13;
           
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkTAC;
        private System.Windows.Forms.Panel pnlUserIcon;
        private System.Windows.Forms.Panel pnlPassIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip tipUsername;
        private System.Windows.Forms.ToolTip tipPassword;
    }
}