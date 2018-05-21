using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MultiMedia
{
    public partial class Movie : UserControl
    {
        public static String url, url_origin, search2;
        public static int currentPage, MaxPage;
        public int numberPage = 1;
        public int numberFilm;
        public String keyword = "keyword";
        item_movie item_Movie;
        List<item_movie> list_itemmovies = new List<item_movie>();
        List<String> year = new List<string>();
        List<String> time = new List<string>();
        List<String> avatar = new List<string>();
        List<String> name = new List<string>();
        List<String> realname = new List<string>();
        List<String> url_first = new List<string>();

        public Movie()
        {
            InitializeComponent();
            //url_origin = "http://phimvnz.com/the-loai/chieu-rap?page=";
            //url = url_origin + numberPage;
            //LoadFilm(url);
            btn_back.Visible = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
        }

      
        public void LoadFilm(String url)
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            try
            {
                year.Clear();
                time.Clear();
                realname.Clear();
                avatar.Clear();
                name.Clear();
                url_first.Clear();
                
                HtmlWeb htmlWeb = new HtmlWeb()
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
                };
                htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
                //Lay so luong trang phim
                    HtmlNode Soluongphim = document.DocumentNode.SelectSingleNode("//ul[@class='pagination']");
                    currentPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"li[@class='active']").InnerText);
                    if (currentPage != MaxPage)
                    {
                        MaxPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"li[last()-1]/a").InnerText);
                    }
                    else
                    {
                        MaxPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"li[@class='active']").InnerText);
                    }

                    lbl_sotrang.Text = currentPage + " / " + MaxPage;
                    if (currentPage <= 1)
                    {
                        btn_back.Visible = false;
                        btn_forward.Visible = true;
                    }
                    else if (currentPage >= MaxPage)
                    {
                        btn_back.Visible = true;
                        btn_forward.Visible = false;
                    }
                    else
                    {
                        btn_back.Visible = true;
                        btn_forward.Visible = true;
                    }           
                //Lay so luong phim trong trang dau tien
                HtmlNode list_film = document.DocumentNode.SelectSingleNode("//div[@class='movie-grid']");
                HtmlNodeCollection listfilm_row = list_film.SelectNodes(@"div[@class='row movie-row']");
                numberFilm = 0;
                foreach (var n in listfilm_row)
                {
                    HtmlNodeCollection listfilm_col = n.SelectNodes(@"div[@class='col-xs-6 col-sm-3 col-md-3']");
                    foreach(var n2 in listfilm_col)
                    {
                        String name_film = n2.SelectSingleNode("div/a/div[@class='movie-data']/h2").InnerText;
                        String year_film = n2.SelectSingleNode("div/a/ul[@class='meta-data']/li[@class='year']").InnerText.Trim();
                        String time_film = n2.SelectSingleNode("div/a/ul[@class='meta-data']/li[@class='time']").InnerText.Trim();
                        String avatar_film = n2.SelectSingleNode("div/a/img").Attributes["src"].Value;
                        String url_film = n2.SelectSingleNode("div/a").Attributes["href"].Value;

                        time.Add(time_film);
                        year.Add(year_film);
                        name.Add(name_film);
                        avatar.Add(avatar_film);
                        url_first.Add(url_film);

                        numberFilm++;
                    }
                }

                //Hiển thị danh sách phim 
                for (int i = 0; i < numberFilm; i++)
                {
                    item_Movie = new item_movie();
                    item_Movie.Name = "movie" + i;
                    item_Movie.Tag = i.ToString();

                    item_Movie.name_movie.Text = name[i];                 
                    item_Movie.lbl_year.Text = year[i];
                    item_Movie.lbl_time.Text = time[i];
                    item_Movie.lbl_url.Text = url_first[i];

                    item_Movie.btn_avatar.ImageLocation = avatar[i];
                    item_Movie.btn_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    item_Movie.btn_avatar.Tag = i.ToString();
                    item_Movie.btn_avatar.Click += btnAvatar_Click;

                    flowLayoutPanel1.Controls.Add(item_Movie);

                    list_itemmovies.Add(item_Movie);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không có phim !!");
            }
        }

        void btnAvatar_Click(object sender, EventArgs e)
        {
            //Lấy vị trí film trong list            
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            int id = Convert.ToInt32(imageButton.Tag.ToString());
            item_movie film = list_itemmovies[id];

            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };
            htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(film.lbl_url.Text.ToString());
            HtmlNode origin_node = document.DocumentNode.SelectSingleNode("//script[@type='text/javascript'][last()]");
            String node = origin_node.InnerText;
            String node2 = node.Substring(node.IndexOf("src:"), node.IndexOf("label"));
            String[] arr = node2.Split(new char[] { ':', ',' });
            String final_link = (arr[1]+ ":"+ arr[2]).Replace("'","").Trim();
            Movie_module.FrmVLC frmVLC = new Movie_module.FrmVLC(final_link);
            frmVLC.Show();
        }

        private void dropdown_theloai_onItemSelected(object sender, EventArgs e)
        {
            if (dropdown_theloai.selectedIndex == 0)
            {
                url_origin = "http://phimvnz.com/the-loai/chieu-rap?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 1)
            {
                url_origin = "http://phimvnz.com/the-loai/kiem-hiep?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 2)
            {
                url_origin = "http://phimvnz.com/the-loai/hanh-dong?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 3)
            {
                url_origin = "http://phimvnz.com/the-loai/vo-thuat?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 4)
            {
                url_origin = "http://phimvnz.com/the-loai/tam-ly-tinh-cam?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 5)
            {
                url_origin = "http://phimvnz.com/the-loai/hai-huoc?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 6)
            {
                url_origin = "http://phimvnz.com/the-loai/hoat-hinh?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 7)
            {
                url_origin = "http://phimvnz.com/the-loai/phieu-luu?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 8)
            {
                url_origin = "http://phimvnz.com/the-loai/kinh-di-ma?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 9)
            {
                url = "http://phimvnz.com/the-loai/hinh-su?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 10)
            {
                url_origin = "http://phimvnz.com/the-loai/chien-tranh?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 11)
            {
                url_origin = "http://phimvnz.com/the-loai/than-thoai?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 12)
            {
                url_origin = "http://phimvnz.com/the-loai/khoa-hoc-vien-tuong?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 13)
            {
                url_origin = "http://phimvnz.com/the-loai/co-trang?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 14)
            {
                url_origin = "http://phimvnz.com/the-loai/am-nhac?page=";
                url = url_origin + numberPage;
            }
            else if (dropdown_theloai.selectedIndex == 15)
            {
                url_origin = "http://phimvnz.com/the-loai/viet-nam?page=";
                url = url_origin + numberPage;
            }

            LoadFilm(url);
        }

        private void btn_phimle_Click(object sender, EventArgs e)
        {
            url_origin = "http://phimvnz.com/phim-le?page=";
            url = url_origin + numberPage;
            LoadFilm(url);
        }

        private void btn_tv_Click(object sender, EventArgs e)
        {
            url_origin = "http://phimvnz.com/the-loai/tv-show?page=";
            url = url_origin + numberPage;
            LoadFilm(url);
        }

        private void btn_xemnhieu_Click(object sender, EventArgs e)
        {
            url_origin = "http://phimvnz.com/phim-xem-nhieu?page=";
            url = url_origin + numberPage;
            LoadFilm(url);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (url.IndexOf("keyword") != -1)
            {
                url = "http://phimvnz.com/tim-kiem?keyword=" + search2 + "&page=" + (currentPage - 1);

                LoadFilmSearch(url);
            }
            else if (currentPage < 1)
            {

                return;
            }
            else
            {
                String nextPage_url = url_origin + (currentPage - 1);
                LoadFilm(nextPage_url);
            }               
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if(url.IndexOf("keyword") != -1)
            {
                url = "http://phimvnz.com/tim-kiem?keyword=" + search2 + "&page=" + (currentPage + 1);

                LoadFilmSearch(url);
            }
            else if(currentPage > MaxPage)
            { 
                return;
            }
            else
            {
                String nextPage_url = url_origin + (currentPage + 1);
                LoadFilm(nextPage_url);
            }
        }


        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            String search = tb_timkiem.Text.ToString();
            if (search != null)
            {
                search2 = search.Replace(" ", "+");

                url = "http://phimvnz.com/tim-kiem?keyword=" + search2;

                LoadFilmSearch(url);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên phim muốn tìm !!");
            }
        }

        public void LoadFilmSearch(String url)
        {
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            year.Clear();
            time.Clear();
            realname.Clear();
            avatar.Clear();
            name.Clear();
            url_first.Clear();

                HtmlWeb htmlWeb = new HtmlWeb()
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
                };
                htmlWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);

                if (document.DocumentNode.SelectSingleNode("//ul[@class='pagination']") == null && document.DocumentNode.SelectSingleNode("//div[@class='col-xs-6 col-sm-3 col-md-3']") == null)
                {
                    MessageBox.Show("Không tìm thấy bộ phim nào !!");
                }
                else if (document.DocumentNode.SelectSingleNode("//ul[@class='pagination']") == null && document.DocumentNode.SelectSingleNode("//div[@class='col-xs-6 col-sm-3 col-md-3']") != null)
                {
                    lbl_sotrang.Text = 1 + " / " + 1;
                    btn_back.Visible = false;
                    btn_forward.Visible = false;

                    //Lay so luong phim trong trang dau tien
                    HtmlNode list_film = document.DocumentNode.SelectSingleNode("//div[@class='movie-grid']");
                    HtmlNodeCollection listfilm_row = list_film.SelectNodes(@"div[@class='row movie-row']");
                    numberFilm = 0;
                    foreach (var n in listfilm_row)
                    {
                        HtmlNodeCollection listfilm_col = n.SelectNodes(@"div[@class='col-xs-6 col-sm-3 col-md-3']");
                        foreach (var n2 in listfilm_col)
                        {
                            String name_film = n2.SelectSingleNode("div/a/div[@class='movie-data']/h5").InnerText;
                            String year_film = n2.SelectSingleNode("div/a/ul[@class='meta-data']/li[@class='year']").InnerText.Trim();
                            String time_film = n2.SelectSingleNode("div/a/ul[@class='meta-data']/li[@class='time']").InnerText.Trim();
                            String avatar_film = n2.SelectSingleNode("div/a/img").Attributes["src"].Value;
                            String url_film = n2.SelectSingleNode("div/a").Attributes["href"].Value;

                            time.Add(time_film);
                            year.Add(year_film);
                            name.Add(name_film);
                            avatar.Add(avatar_film);
                            url_first.Add(url_film);

                            numberFilm++;
                        }
                    }

                    //Hiển thị danh sách phim 
                    for (int i = 0; i < numberFilm; i++)
                    {
                        item_Movie = new item_movie();
                        item_Movie.Name = "movie" + i;
                        item_Movie.Tag = i.ToString();

                        item_Movie.name_movie.Text = name[i];
                        item_Movie.lbl_year.Text = year[i];
                        item_Movie.lbl_time.Text = time[i];
                        item_Movie.lbl_url.Text = url_first[i];

                        item_Movie.btn_avatar.ImageLocation = avatar[i];
                        item_Movie.btn_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                        item_Movie.btn_avatar.Tag = i.ToString();
                        item_Movie.btn_avatar.Click += btnAvatar_Click;

                        flowLayoutPanel1.Controls.Add(item_Movie);

                        list_itemmovies.Add(item_Movie);
                    }
                }
                else
                {
                    HtmlNode Soluongphim = document.DocumentNode.SelectSingleNode("//ul[@class='pagination']");
                    currentPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"li[@class='active']").InnerText);
                    if (currentPage != MaxPage)
                    {
                        MaxPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"li[last()-1]/a").InnerText);
                    }
                    else
                    {
                        MaxPage = Convert.ToInt32(Soluongphim.SelectSingleNode(@"li[@class='active']").InnerText);
                    }

                    lbl_sotrang.Text = currentPage + " / " + MaxPage;
                    if (currentPage <= 1)
                    {
                        btn_back.Visible = false;
                        btn_forward.Visible = true;
                    }
                    else if (currentPage >= MaxPage)
                    {
                        btn_back.Visible = true;
                        btn_forward.Visible = false;
                    }
                    else
                    {
                        btn_back.Visible = true;
                        btn_forward.Visible = true;
                    }
                    //Lay so luong phim trong trang dau tien
                    HtmlNode list_film = document.DocumentNode.SelectSingleNode("//div[@class='movie-grid']");
                    HtmlNodeCollection listfilm_row = list_film.SelectNodes(@"div[@class='row movie-row']");
                    numberFilm = 0;
                    foreach (var n in listfilm_row)
                    {
                        HtmlNodeCollection listfilm_col = n.SelectNodes(@"div[@class='col-xs-6 col-sm-3 col-md-3']");
                        foreach (var n2 in listfilm_col)
                        {
                            String name_film = n2.SelectSingleNode("div/a/div[@class='movie-data']/h5").InnerText;
                            String year_film = n2.SelectSingleNode("div/a/ul[@class='meta-data']/li[@class='year']").InnerText.Trim();
                            String time_film = n2.SelectSingleNode("div/a/ul[@class='meta-data']/li[@class='time']").InnerText.Trim();
                            String avatar_film = n2.SelectSingleNode("div/a/img").Attributes["src"].Value;
                            String url_film = n2.SelectSingleNode("div/a").Attributes["href"].Value;

                            time.Add(time_film);
                            year.Add(year_film);
                            name.Add(name_film);
                            avatar.Add(avatar_film);
                            url_first.Add(url_film);

                            numberFilm++;
                        }
                    }

                    //Hiển thị danh sách phim 
                    for (int i = 0; i < numberFilm; i++)
                    {
                        item_Movie = new item_movie();
                        item_Movie.Name = "movie" + i;
                        item_Movie.Tag = i.ToString();

                        item_Movie.name_movie.Text = name[i];
                        item_Movie.lbl_year.Text = year[i];
                        item_Movie.lbl_time.Text = time[i];
                        item_Movie.lbl_url.Text = url_first[i];

                        item_Movie.btn_avatar.ImageLocation = avatar[i];
                        item_Movie.btn_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                        item_Movie.btn_avatar.Tag = i.ToString();
                        item_Movie.btn_avatar.Click += btnAvatar_Click;

                        flowLayoutPanel1.Controls.Add(item_Movie);

                        list_itemmovies.Add(item_Movie);
                    }
                }
        }

        public void CreateConnection(String url)
        {
            
        }
    }
}
