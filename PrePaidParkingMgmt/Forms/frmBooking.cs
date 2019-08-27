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
    public partial class frmBooking : Form
    {
        public frmBooking()
        {

            InitializeComponent();
            this.Height = Program.formHeight;
            this.Width = Program.formWidth;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slot_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.DarkGray;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            //if(cbType.SelectedIndex==0)
            //{
            //    panel1.Location = new Point(0, 20);
            //    panel1.Visible = true;
            //    panel1.Visible = false;
            //}
            //else if(cbType.SelectedIndex == 1)
            //{
            //    panel1.Location = new Point(20,0);
            //    panel1.Visible = false;
            //    panel1.Visible = true;
            //}
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            frmConfirm objConfirm = new frmConfirm();
            this.Hide();
            objConfirm.Height = Program.formHeight;
            btnContinue.Show();
            objConfirm.Width = Program.formWidth;
            objConfirm.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objConfirm.Show();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
