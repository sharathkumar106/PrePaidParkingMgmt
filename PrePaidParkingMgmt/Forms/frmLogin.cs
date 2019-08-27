using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrePaidParkingMgmt.Forms
{
    public partial class frmLogin : Form
    {
        SqlConnection Con = new SqlConnection(Program.strConn);
        string tmpUserText = "", tmpPassText = "";
        private bool isClicked = false;
        private bool isClickedPass = false;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIPrePaidParkingMgmt obj = new MDIPrePaidParkingMgmt();
            obj.Show();
        }
        public static void FnOpenCloseForm(Form objForm)
        {
            if (Application.OpenForms.Count > 0)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name == "frmLogin")
                    {
                        //Application.OpenForms[i].Hide();
                    }
                    else if (Application.OpenForms[i].Name != "MDIPrePaidParkingMgmt")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
            objForm.Height = Program.formHeight;
            objForm.Width = Program.formWidth;

            objForm.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objForm.Show();
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            Program.strUserName = txtUsername.Text;
            Program.strUserPassword = txtPassword.Text;

            if (FnIsValid())
            {
                string strGetDetailsQry = "select * from dbo.tbl_registration where reg_aflag=1 and reg_username='" + Program.strUserName + "' and reg_password='" + Program.strUserPassword + "'";
                SqlCommand cmd = new SqlCommand(strGetDetailsQry, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            Program.strvehicleNumber = dr["reg_vehicleno"].ToString();
                            Program.strPhoneNumber = dr["reg_phone"].ToString();
                        }

                        MessageBox.Show("Login Successful", "Parking Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrePaid objPrepaid = new frmPrePaid();
                        FnOpenCloseForm(objPrepaid);

                    }
                    else
                    {
                        MessageBox.Show("Invalid User or Password", "Parking Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private bool FnIsValid()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter Username", "Parking Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password", "Parking Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;

            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration objRegister = new frmRegistration();
            FnOpenCloseForm(objRegister);
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            frmPostPaid objPostPaid = new frmPostPaid();
            FnOpenCloseForm(objPostPaid);

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            tmpUserText = txtUsername.Text;
            if (tmpUserText == "")
            {
                tipUsername.Show("Please enter your Username!", pnlUserIcon);
            }
            else
            {
                tipUsername.Hide(pnlUserIcon);
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (!isClickedPass)
            {
                txtPassword.Text = "";
                isClickedPass = true;
            }
            tipPassword.Hide(pnlPassIcon);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            tmpPassText = txtPassword.Text;
            if (tmpPassText == "")
            {
                tipPassword.Show("Please enter the Password!", pnlPassIcon);
            }
            else
            {
                tipPassword.Hide(pnlPassIcon);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            pnlLogin.Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, pnlLogin.Width, pnlLogin.Height, 50, 50));
        }

       

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                txtUsername.Text = "";
                isClicked = true;
                 
            }
            tipUsername.Hide(pnlUserIcon);



        }



    }
}
