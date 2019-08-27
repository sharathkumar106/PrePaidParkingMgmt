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
    public partial class frmConfirm : Form
    {
        SqlConnection Con = new SqlConnection(Program.strConn);
        private string slotsBooked;
        private int Amount;
        public frmConfirm()
        {
            InitializeComponent();
        }
        public frmConfirm(string sltsBkd,int slotsCount)
        {
            this.slotsBooked = sltsBkd;
            this.Amount = (slotsCount) * 20;
            InitializeComponent();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            string strConfirmBookingDetails = "select * from dbo.tbl_booking where bk_af=1";
            Con.Open();
            SqlCommand cmd = new SqlCommand(strConfirmBookingDetails, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                txtInDate.Text = dr["bk_date"].ToString();
                txtInTime.Text = dr["bk_intime"].ToString();
                txtFname.Text = Program.strUserName;
                txtVehicleNo.Text = Program.strvehicleNumber;
                txtVehicleType.Text = Program.strvehicleType;
                txtPhone.Text = Program.strPhoneNumber;
                txtSlotNo.Text = slotsBooked;
                txtAmount.Text = "Rs. " + Amount;
            }
            Con.Close();
        }
    }
}
