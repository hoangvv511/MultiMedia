using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MultiMedia
{
    public partial class Movie : UserControl
    {
        public String url;
        public String currentPage, MaxPage;
        public int page = 1;
        public int numberFilmAtCurrentPage = 0;

        public Movie()
        {
            InitializeComponent();
        }

        private void btn_locphim_Click(object sender, EventArgs e)
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            if (dropdown_theloai.selectedIndex == 0)
            {
                url = "https://woohay.com/the-loai/phim-thuyet-minh/";
            }
            else if (dropdown_theloai.selectedIndex == 1)
            {
                url = "https://woohay.com/the-loai/phim-thieu-nhi/";
            }
            else if (dropdown_theloai.selectedIndex == 2)
            {
                url = "https://woohay.com/the-loai/phim-hanh-dong/";
            }
            else if (dropdown_theloai.selectedIndex == 3)
            {
                url = "https://woohay.com/the-loai/phim-vo-thuat/";
            }
            else if (dropdown_theloai.selectedIndex == 4)
            {
                url = "https://woohay.com/the-loai/phim-tam-ly/";
            }
            else if (dropdown_theloai.selectedIndex == 5)
            {
                url = "https://woohay.com/the-loai/phim-hai-huoc/";
            }
            else if (dropdown_theloai.selectedIndex == 6)
            {
                url = "https://woohay.com/the-loai/phim-hoat-hinh/";
            }
            else if (dropdown_theloai.selectedIndex == 7)
            {
                url = "https://woohay.com/the-loai/phim-phieu-luu/";
            }
            else if (dropdown_theloai.selectedIndex == 8)
            {
                url = "https://woohay.com/the-loai/phim-kinh-di/";
            }
            else if (dropdown_theloai.selectedIndex == 9)
            {
                url = "https://woohay.com/the-loai/phim-hinh-su/";
            }
            else if (dropdown_theloai.selectedIndex == 10)
            {
                url = "https://woohay.com/the-loai/phim-chien-tranh/";
            }
            else if (dropdown_theloai.selectedIndex == 11)
            {
                url = "https://woohay.com/the-loai/phim-than-thoai/";
            }
            else if (dropdown_theloai.selectedIndex == 12)
            {
                url = "https://woohay.com/the-loai/phim-vien-tuong/";
            }
            else if (dropdown_theloai.selectedIndex == 13)
            {
                url = "https://woohay.com/the-loai/phim-co-trang/";
            }
            else if (dropdown_theloai.selectedIndex == 14)
            {
                url = "https://woohay.com/the-loai/phim-am-nhac/";
            }
            else if (dropdown_theloai.selectedIndex == 15)
            {
                url = "https://woohay.com/the-loai/phim-tv-show/";
            }

            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };

            htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
            try
            {
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
                //Lay so luong trang phim
                HtmlNode Soluongphim = document.DocumentNode.SelectSingleNode("//div/span[@class='page_nav']");
                MaxPage = Soluongphim.SelectSingleNode(@"span[last()-1]/a").InnerText;
                currentPage = Soluongphim.SelectSingleNode(@"span[@class='current']").InnerText;
                lbl_sotrang.Text = currentPage + " / " + MaxPage ;

                //Lay so luong phim trong trang dau tien
                HtmlNode list_film = document.DocumentNode.SelectSingleNode("//ul[@class='list-film']");
                HtmlNodeCollection list_itemfilm = list_film.SelectNodes(@"li");
                numberFilmAtCurrentPage = list_itemfilm.Count;
                for(int i = 0 ; i < numberFilmAtCurrentPage ; i++)
                {
                    
                }
            
                foreach(var n in list_itemfilm)
                {
                    String detail = n.SelectSingleNode("div/div[@class='status']").InnerText;
                    String name = n.SelectSingleNode("div/div[@class='info']/div[@class='name']").InnerText;
                    String avatar = n.SelectSingleNode("div/a/img").Attributes["src"].Value;
                    String realname = n.SelectSingleNode("div/div[@class='info']/div[@class='name2']").InnerText;
                    String url_first = n.SelectSingleNode("div/a").Attributes["href"].Value;
                  
                    item_movie item_Movie = new item_movie();
                    item_Movie.name_movie.Text = name;
                    item_Movie.realname_movie.Text = realname;
                    item_Movie.btn_avatar.ImageLocation = avatar;
                    item_Movie.btn_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    item_Movie.lbl_detail.Text = detail;
                    flowLayoutPanel1.Controls.Add(item_Movie);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi mạng!");
            }
          
          
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
