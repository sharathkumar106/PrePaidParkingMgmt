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
    public partial class frmPrePaid : Form
    {
        int count=0;
        string sltBkd = "";
        SqlConnection Con = new SqlConnection(Program.strConn);
        public frmPrePaid()
        {
            InitializeComponent();
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
            frmConfirm objConfirm = new frmConfirm(sltBkd,count);
            
                objConfirm.Height = Program.formHeight;
                objConfirm.Width = Program.formWidth;
                objConfirm.MdiParent = this.MdiParent;
                objConfirm.Show();
        }

        private void FnInsertBookingDetails()
        {
            string inDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string inTime = cbInHr.SelectedItem.ToString() + ":" + cbInMin.SelectedItem.ToString();
            if (cbInSession.SelectedItem.ToString().Equals("PM"))
            {
                inTime = (int.Parse(cbInHr.SelectedItem.ToString())+12) + ":" + cbInMin.SelectedItem.ToString();
            }
            string outTime= cbOutHr.SelectedItem.ToString() + ":" + cbOutMin.SelectedItem.ToString();
            if (cbOutSession.SelectedItem.ToString().Equals("PM"))
            {
                outTime = (int.Parse(cbOutHr.SelectedItem.ToString()) + 12) + ":" + cbInMin.SelectedItem.ToString();
            }
            string sqlInsertBooking = "insert into dbo.tbl_booking values('PREPAID','"+inDate+"','"+inTime+"','"+outTime+"','1')";
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
            foreach(Button slt in pnlSlots.Controls)
            {
                if (slt.BackColor == Color.Red&&slt.Enabled==true&&count<3)
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
            if (slt.BackColor == Color.Green )
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
            FnBookSlots(slt1);
        }

        private void slt2_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt2);
        }

        private void slt3_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt3);
        }

        private void slt4_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt4);
        }

        private void slt5_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt5);
        }

        private void slt6_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt6);
        }

        private void slt7_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt7);
        }

        private void slt8_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt8);
        }

        private void slt9_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt9);
        }

        private void slt10_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt10);
        }

        private void slt11_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt11);
        }

        private void slt12_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt12);
        }

        private void slt13_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt13);
        }
        
        private void slt14_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt14);
        }

        private void slt15_Click(object sender, EventArgs e)
        {
            FnBookSlots(slt15);
        }
    }
}
