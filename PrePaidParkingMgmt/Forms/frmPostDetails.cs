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
    public partial class frmPostDetails : Form
    {
        public frmPostDetails()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmConfirm objConfirm = new frmConfirm();
            objConfirm.Height = Program.formHeight - 5;
            objConfirm.Width = Program.formWidth - 5;
            objConfirm.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objConfirm.Show();

        }
    }
}
