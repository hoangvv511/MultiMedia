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
            this.realname_movie = new System.Windows.Forms.Label();
            this.btn_avatar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_detail = new MultiMedia.LabelRoundCorners();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // name_movie
            // 
            this.name_movie.AutoSize = true;
            this.name_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_movie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_movie.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.name_movie.Location = new System.Drawing.Point(3, 0);
            this.name_movie.Name = "name_movie";
            this.name_movie.Size = new System.Drawing.Size(294, 20);
            this.name_movie.TabIndex = 5;
            this.name_movie.Text = "Chiến Binh Báo Đen\r\n";
            this.name_movie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name_movie.Click += new System.EventHandler(this.name_movie_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.name_movie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.realname_movie, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 40);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // realname_movie
            // 
            this.realname_movie.AutoSize = true;
            this.realname_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realname_movie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realname_movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.realname_movie.Location = new System.Drawing.Point(3, 20);
            this.realname_movie.Name = "realname_movie";
            this.realname_movie.Size = new System.Drawing.Size(294, 20);
            this.realname_movie.TabIndex = 6;
            this.realname_movie.Text = "Black Panther (2018)";
            this.realname_movie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // lbl_detail
            // 
            this.lbl_detail._BackColor = System.Drawing.Color.Red;
            this.lbl_detail.AutoSize = true;
            this.lbl_detail.BackColor = System.Drawing.Color.Red;
            this.lbl_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_detail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_detail.Location = new System.Drawing.Point(3, 3);
            this.lbl_detail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.Size = new System.Drawing.Size(171, 17);
            this.lbl_detail.TabIndex = 14;
            this.lbl_detail.Text = "HD VietSub + Thuyết Minh\r\n";
            this.lbl_detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbl_detail);
            this.Controls.Add(this.btn_avatar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "item_movie";
            this.Size = new System.Drawing.Size(300, 210);
            this.Load += new System.EventHandler(this.item_movie_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label name_movie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label realname_movie;
        public LabelRoundCorners lbl_detail;
        public Bunifu.Framework.UI.BunifuImageButton btn_avatar;
    }
}
