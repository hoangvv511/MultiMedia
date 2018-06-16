using HtmlAgilityPack;
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            movie1.Enabled = true;
            movie1.Visible = true;

            tv1.Visible = false;
            tv1.Enabled = false;
            tv1.axVLCPlugin21.playlist.stop();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            tv1.Visible = true;
            tv1.Enabled = true;

            movie1.Enabled = false;
            movie1.Visible = false;

            tv1.axVLCPlugin21.playlist.stop();

            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-thuanviethd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-phimhd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-dulichhd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-giadinhhd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-phunuhd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-canhachd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htv1");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htv2hd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htv3");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htv7hd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htv9hd");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc1&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc4&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc7&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc8&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc9&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc10&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc11&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc14&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=vtc16&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Vinh_Long_1&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Vinh_Long_2&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=htvc-thethaohd");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=foxhd");
            tv1.axVLCPlugin21.playlist.add("http://cshms3.airtel.tv/PLTV/88888888/224/3221225874/01.m3u8");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=cartoon");
            tv1.axVLCPlugin21.playlist.add("http://baochinh.ml/iptv-hplus.php?kenh=mtv");
            tv1.axVLCPlugin21.playlist.add("http://mhms5.airtel.tv/PLTV/88888888/224/3221226201/01.m3u8");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Binh_Dinh&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Binh_Phuoc_1&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Ha_Tinh&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Khanh_Hoa&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Hue&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Kien_Giang_1&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Lam_Dong&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Lang_Son&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Long_An_34&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Quang_Nam&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Soc_Trang&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Tay_Ninh&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Can_Tho&cdn=1");
            tv1.axVLCPlugin21.playlist.add("http://ott.realplaytv.net:12388/?header=hplus&name=Tra_Vinh&cdn=1");

            
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
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov2";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov3";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov4";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov5";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov5b";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vovgt";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vovgtsg";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov247";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);

            _url = "https://vov.vn/RadioPlayer.aspx?c=vov2477";
            document = htmlWeb.Load(_url);
            _notechinh = document.DocumentNode.SelectSingleNode("//form[@id='form1']//script");
            linkgoc = _notechinh.InnerHtml.ToString();
            linkgoc = linkgoc.Substring(linkgoc.IndexOf(str1), linkgoc.IndexOf(str2) + str2.Length - linkgoc.IndexOf(str1));
            url = linkgoc;
            tv1.axVLCPlugin21.playlist.add(url);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
