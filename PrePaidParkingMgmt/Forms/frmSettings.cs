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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = txtNewPass.Text = txtRePass.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmVehicleType objVType = new frmVehicleType();
            objVType.Height = Program.formHeight - 5;
            objVType.Width = Program.formWidth - 5;
            objVType.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objVType.Show();
        }
    }
}
