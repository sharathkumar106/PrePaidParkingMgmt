using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace PrePaidParkingMgmt
{
    
    static class Program
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );



        public static string strConn = "Data Source=sharathkumar;Initial Catalog=db_icsolutions;Integrated Security=True;";

        public static string strUserName = "";
        public static string strUserPassword = "";
        public static string strvehicleType = "";
        public static string strvehicleNumber = "";
        public static string strPhoneNumber = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static int formHeight, formWidth;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MDIPrePaidParkingMgmt());
        }
    }
}
