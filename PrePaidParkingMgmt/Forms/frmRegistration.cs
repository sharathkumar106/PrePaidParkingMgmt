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
    public partial class frmRegistration : Form
    {
        SqlConnection Con = new SqlConnection(Program.strConn);
        public frmRegistration()
        {
            InitializeComponent();
          
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (FnisValid())
            {
                string strRegQuery = "insert into dbo.tbl_registration values ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + txtPhone.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtVehicleno.Text.ToUpper() + "', '" + txtAddress.Text + "','1')";
                Con.Open();
                SqlCommand cd = new SqlCommand(strRegQuery, Con);
                cd.ExecuteNonQuery();
                Con.Close();
                this.Hide();
            }
        }

        private bool FnisValid()
        {


            if (txtFname.Text == "")
            {
                MessageBox.Show("Enter First Name", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFname.Focus();
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Enter Phone Number", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }
            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone Number must contain 10 Digits", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }


            if (FnuserExists())
            {
                MessageBox.Show("Username already Exists!\nChoose a new Username", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }



            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter Username", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }            
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPassword.Text = txtRePassword.Text = "";
                txtPassword.Focus();
                return false;
            }
            if (txtVehicleno.Text == "")
            {
                MessageBox.Show("Enter Vehicle Number", "Parking Management Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehicleno.Focus();
                return false;
            }

            return true;
            
        }

        private bool FnuserExists()
        {
            string strGetDetailsQry = "select reg_username from dbo.tbl_registration where reg_aflag=1 and reg_username='"+txtUsername.Text+"'";
            Con.Open();
            SqlCommand cmd = new SqlCommand(strGetDetailsQry, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count>0)
                {
                    Con.Close();
                    return true;
                }
            }
            Con.Close();
            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Text = txtLname.Text = txtPassword.Text = txtPhone.Text = txtRePassword.Text = txtUsername.Text = txtVehicleno.Text = txtAddress.Text= "";
        }

        private void txtVehicleno_Leave(object sender, EventArgs e)
        {
            txtVehicleno.Text = txtVehicleno.Text.ToUpper();
        }
    }
}
