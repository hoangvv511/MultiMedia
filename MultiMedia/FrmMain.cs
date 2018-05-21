using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            //this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Xử lý đóng mở menu

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Sidemenu.Width == 80)
            {
                btnMenu.Location = new Point(260, 0);
                Sidemenu.Visible = false;
                Sidemenu.Width = 300;
                PanelAnimation.ShowSync(Sidemenu);
            }
            else
            {
                Sidemenu.Visible = false;
                Sidemenu.Width = 80;
                btnMenu.Location = new Point(20, 58);
                PanelAnimation2.ShowSync(Sidemenu);
            }


           
        }
      
    }
}
