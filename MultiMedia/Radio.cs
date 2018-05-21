using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace MultiMedia
{
    public partial class Radio : UserControl
    {
        private int a = 0;
        public Radio()
        {
            InitializeComponent();
        }

        private void btnVov1_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(0);
        }

        private void btnVov3_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(2);
        }

        private void btnVov4_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(3);
        }

        private void btnVov5_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(4);
        }

        private void btnVov63_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(5);
        }

        private void btnVovTG_HN_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(6);
        }

        private void btnVovGT_TPHCM_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(7);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(8);
        }

        private void btnVov2_Click_1(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("play.png");
            axVLCPlugin.playlist.playItem(1);
        }

        private void bunifuVTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            axVLCPlugin.audio.volume = 100 - bunifuVTrackbar1.Value;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            a = axVLCPlugin.playlist.itemCount;
            if (axVLCPlugin.playlist.isPlaying)
            {
                btnPlay.Image = Image.FromFile("pause.png");
                axVLCPlugin.playlist.stop();
            }
            else
            {
                btnPlay.Image = Image.FromFile("play.png");
                axVLCPlugin.playlist.playItem(a);
            }
        }
    }
}
