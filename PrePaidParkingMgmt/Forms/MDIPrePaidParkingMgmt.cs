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
    public partial class MDIPrePaidParkingMgmt : Form
    {
        private int childFormNumber = 0;
        public MDIPrePaidParkingMgmt()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrePaidParkingMgmt_Load(object sender, EventArgs e)
        {
            Program.formHeight = pnlBody.Height - pnlBottom.Height - 4;
            Program.formWidth = pnlBody.Width - 4;
            
        }

        public void FnOpenCloseForm(Form objForm)
        {
            if (Application.OpenForms.Count > 0)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name == "frmLogin")
                    {
                        Application.OpenForms[i].Hide();
                    }
                    else if (Application.OpenForms[i].Name != "MDIPrePaidParkingMgmt")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
            objForm.Height = Program.formHeight;
            objForm.Width = Program.formWidth;
            this.pnlBody.Hide();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            frmVehicleType objVType = new frmVehicleType();
            FnOpenCloseForm(objVType);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            frmConfirm objConfirm = new frmConfirm();
            FnOpenCloseForm(objConfirm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {


            frmSettings objSettings = new frmSettings();
            FnOpenCloseForm(objSettings);
        }
    }
}
