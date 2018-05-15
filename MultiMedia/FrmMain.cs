using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //qa
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            radio2.Visible = true;
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị Tiếng Việt
            };
            htmlWeb.UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";

            //radio2.axVLCPlugin.playlist.add("http://talk2.vcdn.vn/hls/c913e93833d3fa1aff0fca6ffe9f2d33/162d29f55cd/htvbch/index.m3u8");

            string _url = "https://vov.vn/RadioPlayer.aspx?c=vov1";
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(_url);
            HtmlNode _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");

            string linkgoc = _notechinh.InnerHtml.ToString();
            string str1 = "https";
            string str2 = "m3u8";
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            string url = linkgoc;
            //String url = "https://5a6872aace0ce.streamlock.net/vov3/vov3.stream_aac/playlist.m3u8";
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov2";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov3";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov4";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov5";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov5b";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vovgt";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vovgtsg";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov247";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov2477";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            radio2.axVLCPlugin.playlist.add(url);

            radio2.axVLCPlugin.playlist.playItem(0);
        }
    }
}
