using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;
using MultiMedia.Youtube;
using System.Net;
using System.IO;

namespace MultiMedia
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchYoutube();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string b = row.Cells["Url"].Value.ToString();
                //string a = list[index].Url;
                axVLCPlugin21.playlist.add(b);
                axVLCPlugin21.playlist.play();


            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            SearchYoutube();
        }
        private void SearchYoutube()
        {
            VideoSearch items = new VideoSearch();
            List<Video> list = new List<Video>();
            foreach (var item in items.SearchQuery(txtSearch.Text, 1))
            {
                Video video = new Video();
                video.Title = item.Title;
                video.Url = item.Url;

                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                }
                list.Add(video);
            }
            videoBindingSource.DataSource = list;
        }
    }
}
