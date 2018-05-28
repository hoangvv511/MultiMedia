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
            this.lbl_url = new System.Windows.Forms.Label();
            this.btn_avatar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_detail = new MultiMedia.LabelRoundCorners();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_realname = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_detail.Size = new System.Drawing.Size(34, 17);
            this.lbl_detail.TabIndex = 14;
            this.lbl_detail.Text = "2018";
            this.lbl_detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_realname, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 40);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(294, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Chiến binh báo đen";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_realname
            // 
            this.lbl_realname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_realname.AutoSize = true;
            this.lbl_realname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_realname.ForeColor = System.Drawing.Color.White;
            this.lbl_realname.Location = new System.Drawing.Point(3, 20);
            this.lbl_realname.Name = "lbl_realname";
            this.lbl_realname.Size = new System.Drawing.Size(294, 20);
            this.lbl_realname.TabIndex = 1;
            this.lbl_realname.Text = "Black Panther";
            this.lbl_realname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_detail);
            this.Controls.Add(this.btn_avatar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "item_movie";
            this.Size = new System.Drawing.Size(300, 210);
            this.Load += new System.EventHandler(this.item_movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_avatar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_url;
        public Bunifu.Framework.UI.BunifuImageButton btn_avatar;
        public LabelRoundCorners lbl_detail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_realname;
    }
}
