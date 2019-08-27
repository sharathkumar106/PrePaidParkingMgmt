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
    public partial class frmPostPaid : Form
    {
        int count = 0;
        string sltBkd = "";
        SqlConnection Con = new SqlConnection(Program.strConn);
        public frmPostPaid()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            if (count < 3)
            {
                FnUpdateSlotStatus();
                FnInsertBookingDetails();
            }
            else
            {
                MessageBox.Show("Maximum 3 Slots can be booked!", "Parking Maangement", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            frmPostDetails objPostDetails = new frmPostDetails();
            objPostDetails.Height = Program.formHeight - 5;
            objPostDetails.Width = Program.formWidth - 5;
            objPostDetails.MdiParent = MDIPrePaidParkingMgmt.ActiveForm;
            objPostDetails.Show();
        }


        private void FnInsertBookingDetails()
        {
            string inDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string inTime = cbInHr.SelectedItem.ToString() + ":" + cbInMin.SelectedItem.ToString();
            if (cbInSession.SelectedItem.ToString().Equals("PM"))
            {
                inTime = (int.Parse(cbInHr.SelectedItem.ToString()) + 12) + ":" + cbInMin.SelectedItem.ToString();
            }
            
            string sqlInsertBooking = "insert into dbo.tbl_booking values('POSTPAID','" + inDate + "','" + inTime + "','00:00','1')";
            Con.Open();
            SqlCommand cmd = new SqlCommand(sqlInsertBooking, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void frmPrePaid_Load(object sender, EventArgs e)
        {

            string strSltStatusQuery = "select slt_number,slt_status from dbo.tbl_slots where slt_af=1";
            SqlCommand cmd = new SqlCommand(strSltStatusQuery, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int slot_id = 0, status = 0;
            Con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                slot_id = (int)dr["slt_number"];
                status = (int)dr["slt_status"];
                foreach (Button btn in pnlSlots.Controls)
                {
                    if (btn.Text == Convert.ToString(slot_id))
                    {
                        if (status == 0)
                        {
                            btn.BackColor = Color.Red;
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.BackColor = Color.Green;
                        }
                    }
                }
            }
            Con.Close();
        }

        private void FnUpdateSlotStatus()
        {
            Con.Open();
            foreach (Button slt in pnlSlots.Controls)
            {
                if (slt.BackColor == Color.Red && slt.Enabled == true && count < 3)
                {
                    count++;
                    sltBkd = slt.Text + " ";
                    string strUpdateSlt = "update dbo.tbl_slots set slt_status=0 where slt_af=1 and slt_number=@slotno";
                    SqlCommand cd = new SqlCommand(strUpdateSlt, Con);
                    cd.Parameters.Add("@slotno", SqlDbType.Int).Value = int.Parse(slt.Text);

                    cd.ExecuteNonQuery();
                }
            }
            Con.Close();
        }

        private void FnColorChange(Button slt)
        {
            int id = int.Parse(slt.Text);
            if (slt.BackColor == Color.Green)
            {
                slt.BackColor = Color.Red;

            }
            else
            {
                slt.BackColor = Color.Green;


            }
        }

        private void FnBookSlots(Button slt)
        {

            FnColorChange(slt);

        }

        private void slt1_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn1);
        }

        private void slt2_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn2);
        }

        private void slt3_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn3);
        }

        private void slt4_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn4);
        }

        private void slt5_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn5);
        }

        private void slt6_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn6);
        }

        private void slt7_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn7);
        }

        private void slt8_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn8);
        }

        private void slt9_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn9);
        }

        private void slt10_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn10);
        }

        private void slt11_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn11);
        }

        private void slt12_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn12);
        }

        private void slt13_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn13);
        }

        private void slt14_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn14);
        }

        private void slt15_Click(object sender, EventArgs e)
        {
            FnBookSlots(btn15);
        }

    }
}
