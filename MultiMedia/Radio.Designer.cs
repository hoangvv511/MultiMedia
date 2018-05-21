namespace MultiMedia
{
    partial class Radio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radio));
            this.axVLCPlugin = new AxAXVLC.AxVLCPlugin2();
            this.btnVov1 = new System.Windows.Forms.Button();
            this.btnVov3 = new System.Windows.Forms.Button();
            this.btnVov4 = new System.Windows.Forms.Button();
            this.btnVov5 = new System.Windows.Forms.Button();
            this.btnVov63 = new System.Windows.Forms.Button();
            this.btnVovTG_HN = new System.Windows.Forms.Button();
            this.btnVovGT_TPHCM = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnVov2 = new System.Windows.Forms.Button();
            this.bunifuVTrackbar1 = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin
            // 
            this.axVLCPlugin.Enabled = true;
            this.axVLCPlugin.Location = new System.Drawing.Point(716, 0);
            this.axVLCPlugin.Name = "axVLCPlugin";
            this.axVLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin.OcxState")));
            this.axVLCPlugin.Size = new System.Drawing.Size(163, 129);
            this.axVLCPlugin.TabIndex = 0;
            this.axVLCPlugin.Visible = false;
            // 
            // btnVov1
            // 
            this.btnVov1.Location = new System.Drawing.Point(52, 80);
            this.btnVov1.Name = "btnVov1";
            this.btnVov1.Size = new System.Drawing.Size(75, 23);
            this.btnVov1.TabIndex = 2;
            this.btnVov1.Text = "VOV1";
            this.btnVov1.UseVisualStyleBackColor = true;
            this.btnVov1.Click += new System.EventHandler(this.btnVov1_Click);
            // 
            // btnVov3
            // 
            this.btnVov3.Location = new System.Drawing.Point(214, 80);
            this.btnVov3.Name = "btnVov3";
            this.btnVov3.Size = new System.Drawing.Size(75, 23);
            this.btnVov3.TabIndex = 4;
            this.btnVov3.Text = "VOV3";
            this.btnVov3.UseVisualStyleBackColor = true;
            this.btnVov3.Click += new System.EventHandler(this.btnVov3_Click);
            // 
            // btnVov4
            // 
            this.btnVov4.Location = new System.Drawing.Point(295, 80);
            this.btnVov4.Name = "btnVov4";
            this.btnVov4.Size = new System.Drawing.Size(75, 24);
            this.btnVov4.TabIndex = 5;
            this.btnVov4.Text = "VOV4";
            this.btnVov4.UseVisualStyleBackColor = true;
            this.btnVov4.Click += new System.EventHandler(this.btnVov4_Click);
            // 
            // btnVov5
            // 
            this.btnVov5.Location = new System.Drawing.Point(376, 81);
            this.btnVov5.Name = "btnVov5";
            this.btnVov5.Size = new System.Drawing.Size(75, 23);
            this.btnVov5.TabIndex = 6;
            this.btnVov5.Text = "VOV5";
            this.btnVov5.UseVisualStyleBackColor = true;
            this.btnVov5.Click += new System.EventHandler(this.btnVov5_Click);
            // 
            // btnVov63
            // 
            this.btnVov63.Location = new System.Drawing.Point(52, 122);
            this.btnVov63.Name = "btnVov63";
            this.btnVov63.Size = new System.Drawing.Size(75, 23);
            this.btnVov63.TabIndex = 7;
            this.btnVov63.Text = "VOV63";
            this.btnVov63.UseVisualStyleBackColor = true;
            this.btnVov63.Click += new System.EventHandler(this.btnVov63_Click);
            // 
            // btnVovTG_HN
            // 
            this.btnVovTG_HN.Location = new System.Drawing.Point(133, 122);
            this.btnVovTG_HN.Name = "btnVovTG_HN";
            this.btnVovTG_HN.Size = new System.Drawing.Size(108, 23);
            this.btnVovTG_HN.TabIndex = 8;
            this.btnVovTG_HN.Text = "VOVGT - Hà Nội";
            this.btnVovTG_HN.UseVisualStyleBackColor = true;
            this.btnVovTG_HN.Click += new System.EventHandler(this.btnVovTG_HN_Click);
            // 
            // btnVovGT_TPHCM
            // 
            this.btnVovGT_TPHCM.Location = new System.Drawing.Point(247, 122);
            this.btnVovGT_TPHCM.Name = "btnVovGT_TPHCM";
            this.btnVovGT_TPHCM.Size = new System.Drawing.Size(109, 23);
            this.btnVovGT_TPHCM.TabIndex = 9;
            this.btnVovGT_TPHCM.Text = "VOVGT - TP HCM";
            this.btnVovGT_TPHCM.UseVisualStyleBackColor = true;
            this.btnVovGT_TPHCM.Click += new System.EventHandler(this.btnVovGT_TPHCM_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(362, 122);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(89, 23);
            this.btnEnglish.TabIndex = 10;
            this.btnEnglish.Text = "24/7 - English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnVov2
            // 
            this.btnVov2.Location = new System.Drawing.Point(133, 80);
            this.btnVov2.Name = "btnVov2";
            this.btnVov2.Size = new System.Drawing.Size(75, 23);
            this.btnVov2.TabIndex = 11;
            this.btnVov2.Text = "VOV2";
            this.btnVov2.UseVisualStyleBackColor = true;
            this.btnVov2.Click += new System.EventHandler(this.btnVov2_Click_1);
            // 
            // bunifuVTrackbar1
            // 
            this.bunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuVTrackbar1.BorderRadius = 0;
            this.bunifuVTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuVTrackbar1.Location = new System.Drawing.Point(588, 66);
            this.bunifuVTrackbar1.MaximumValue = 100;
            this.bunifuVTrackbar1.Name = "bunifuVTrackbar1";
            this.bunifuVTrackbar1.Size = new System.Drawing.Size(30, 87);
            this.bunifuVTrackbar1.SliderRadius = 0;
            this.bunifuVTrackbar1.TabIndex = 13;
            this.bunifuVTrackbar1.Value = 0;
            this.bunifuVTrackbar1.ValueChanged += new System.EventHandler(this.bunifuVTrackbar1_ValueChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::MultiMedia.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(532, 113);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 16;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.bunifuVTrackbar1);
            this.Controls.Add(this.btnVov2);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnVovGT_TPHCM);
            this.Controls.Add(this.btnVovTG_HN);
            this.Controls.Add(this.btnVov63);
            this.Controls.Add(this.btnVov5);
            this.Controls.Add(this.btnVov4);
            this.Controls.Add(this.btnVov3);
            this.Controls.Add(this.btnVov1);
            this.Controls.Add(this.axVLCPlugin);
            this.Name = "Radio";
            this.Size = new System.Drawing.Size(882, 506);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        public System.Windows.Forms.Button btnVov5;
        public System.Windows.Forms.Button btnEnglish;
        public AxAXVLC.AxVLCPlugin2 axVLCPlugin;
        public System.Windows.Forms.Button btnVov1;
        public System.Windows.Forms.Button btnVov2;
        public System.Windows.Forms.Button btnVov3;
        public System.Windows.Forms.Button btnVov4;
        public System.Windows.Forms.Button btnVov63;
        public System.Windows.Forms.Button btnVovTG_HN;
        public System.Windows.Forms.Button btnVovGT_TPHCM;
        private Bunifu.Framework.UI.BunifuVTrackbar bunifuVTrackbar1;
        private System.Windows.Forms.Button btnPlay;
    }
}
