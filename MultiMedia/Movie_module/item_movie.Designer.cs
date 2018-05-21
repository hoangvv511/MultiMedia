namespace MultiMedia
{
    partial class item_movie
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_movie));
            this.name_movie = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_avatar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_time = new MultiMedia.LabelRoundCorners();
            this.lbl_year = new MultiMedia.LabelRoundCorners();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // name_movie
            // 
            this.name_movie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_movie.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.name_movie.Location = new System.Drawing.Point(3, 0);
            this.name_movie.Name = "name_movie";
            this.tableLayoutPanel1.SetRowSpan(this.name_movie, 2);
            this.name_movie.Size = new System.Drawing.Size(294, 40);
            this.name_movie.TabIndex = 5;
            this.name_movie.Text = "Chiến Binh Báo Đen\r\n";
            this.name_movie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name_movie.Click += new System.EventHandler(this.name_movie_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.name_movie, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 40);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btn_avatar
            // 
            this.btn_avatar.BackColor = System.Drawing.Color.Black;
            this.btn_avatar.Image = ((System.Drawing.Image)(resources.GetObject("btn_avatar.Image")));
            this.btn_avatar.ImageActive = null;
            this.btn_avatar.Location = new System.Drawing.Point(0, 0);
            this.btn_avatar.Name = "btn_avatar";
            this.btn_avatar.Size = new System.Drawing.Size(300, 170);
            this.btn_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_avatar.TabIndex = 16;
            this.btn_avatar.TabStop = false;
            this.btn_avatar.Zoom = 10;
            this.btn_avatar.Click += new System.EventHandler(this.btn_avatar_Click);
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(3, 7);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(0, 13);
            this.lbl_url.TabIndex = 17;
            this.lbl_url.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time._BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time.Location = new System.Drawing.Point(37, 3);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(55, 17);
            this.lbl_time.TabIndex = 18;
            this.lbl_time.Text = "90 phút";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_year
            // 
            this.lbl_year._BackColor = System.Drawing.Color.Red;
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.Red;
            this.lbl_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_year.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_year.Location = new System.Drawing.Point(3, 3);
            this.lbl_year.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(34, 17);
            this.lbl_year.TabIndex = 14;
            this.lbl_year.Text = "2018";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.btn_avatar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "item_movie";
            this.Size = new System.Drawing.Size(300, 210);
            this.Load += new System.EventHandler(this.item_movie_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label name_movie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public LabelRoundCorners lbl_year;
        public Bunifu.Framework.UI.BunifuImageButton btn_avatar;
        public System.Windows.Forms.Label lbl_url;
        public LabelRoundCorners lbl_time;
    }
}
