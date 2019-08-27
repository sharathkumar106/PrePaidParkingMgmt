using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrePaidParkingMgmt.Forms
{
    public partial class frmVehicleType : Form
    {
        private string v;

        public frmVehicleType()
        {
            
            InitializeComponent();
        }

        public frmVehicleType(string v)
        {
            this.v = v;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        private void lbl4Wheel_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl2Wheel_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.strvehicleType = "2 WHEELER";
            frmLogin objLogin = new frmLogin();
            //FnOpenCloseForm(objLogin);
            objLogin.Height = Program.formHeight;
            objLogin.Width = Program.formWidth;
            objLogin.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objLogin.Show();
        }

        private void btn4Wheel(object sender, EventArgs e)
        {
            Program.strvehicleType = "4 WHEELER";
            frmLogin objLogin = new frmLogin();
            //FnOpenCloseForm(objLogin);
            objLogin.Height = Program.formHeight;
            objLogin.Width = Program.formWidth;
            objLogin.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objLogin.Show();
        }
    }
}
