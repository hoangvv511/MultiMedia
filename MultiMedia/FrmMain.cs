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

        int _cornerRadius = 10;
        Point _locationLabel2;

        // Form.Load(...)

        // Form.Paint(...)
        //private void FrmMain_Paint(object sender, PaintEventArgs e)
        //{
        //    using (Pen pen = new Pen(label1.BackColor, 3.0f))
        //    {
        //        // Step 2: Smooth the label borders (ok only for label1)
        //        _drawRoundedRectangle(e.Graphics, pen, label1.Location.X, label1.Location.Y,
        //                              label1.ClientRectangle.Width, label1.ClientRectangle.Height, _cornerRadius);
        //        _drawRoundedRectangle(e.Graphics, pen, _locationLabel2.X, _locationLabel2.Y,
        //                              label2.ClientRectangle.Width, label2.ClientRectangle.Height, _cornerRadius);
        //    }
        //}

        // Helper 1/3
        private static GraphicsPath _getRoundPath(Rectangle rectangle, int radius)
        {
            int x = rectangle.X;
            int y = rectangle.Y;
            int width = rectangle.Width;
            int height = rectangle.Height;

            radius = radius << 1;

            GraphicsPath path = new GraphicsPath();

            if (radius > 0)
            {
                if (radius > height) radius = height;
                if (radius > width) radius = width;
                path.AddArc(x, y, radius, radius, 180, 90);
                path.AddArc(x + width - radius, y, radius, radius, 270, 90);
                path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                path.AddArc(x, y + height - radius, radius, radius, 90, 90);
                path.CloseFigure();
            }
            else
            {
                path.AddRectangle(rectangle);
            }

            return path;
        }

        // Helper 2/3
        private void _drawRoundedRectangle(Graphics graphics, Pen pen, int x, int y, int width, int height, int radius)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            GraphicsPath path = _generateRoundedRectangle(graphics, rectangle, radius);
            SmoothingMode old = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawPath(pen, path);
            graphics.SmoothingMode = old;
        }

        // Helper 3/3
        private static GraphicsPath _generateRoundedRectangle(Graphics graphics, RectangleF rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rectangle.Location, sizeF);

            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        //private void FrmMain_Load(object sender, EventArgs e)
        //{
        //    // Step 1: Cut the label regions (seems to be ok, result is the same for both labels)
        //    GraphicsPath graphicsPath = _getRoundPath(label1.ClientRectangle, _cornerRadius);
        //    label1.Region = new Region(graphicsPath);
        //    graphicsPath = _getRoundPath(label2.ClientRectangle, _cornerRadius);
        //    label2.Region = new Region(graphicsPath);
      
        //    _locationLabel2 = this.PointToClient(label2.Parent.PointToScreen(label2.Location));
        //}
    }
}
