using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMedia.Movie_module
{
    public partial class VLCdesign : UserControl
    {

        public bool isFullScreen = false;
        public int sec, min, hour;

        public string url;

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public void Init()
        {
            
        }


        public VLCdesign(String url)
        {
            InitializeComponent();

            volume.Value = 100;
            vlcControl1.SetMedia(url);
            vlcControl1.Play(url);


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
 
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void volume_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = volume.Value;
        }
    }
}
