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
            this.detail_movie = new System.Windows.Forms.Label();
            this.name_movie = new System.Windows.Forms.Label();
            this.realname_movie = new System.Windows.Forms.Label();
            this.avatar_movie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // detail_movie
            // 
            this.detail_movie.AutoSize = true;
            this.detail_movie.BackColor = System.Drawing.Color.Red;
            this.detail_movie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detail_movie.Location = new System.Drawing.Point(4, 3);
            this.detail_movie.Name = "detail_movie";
            this.detail_movie.Size = new System.Drawing.Size(34, 13);
            this.detail_movie.TabIndex = 4;
            this.detail_movie.Text = "Detail";
            // 
            // name_movie
            // 
            this.name_movie.AutoSize = true;
            this.name_movie.ForeColor = System.Drawing.Color.DodgerBlue;
            this.name_movie.Location = new System.Drawing.Point(4, 213);
            this.name_movie.Name = "name_movie";
            this.name_movie.Size = new System.Drawing.Size(35, 13);
            this.name_movie.TabIndex = 5;
            this.name_movie.Text = "Name";
            // 
            // realname_movie
            // 
            this.realname_movie.AutoSize = true;
            this.realname_movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.realname_movie.Location = new System.Drawing.Point(4, 233);
            this.realname_movie.Name = "realname_movie";
            this.realname_movie.Size = new System.Drawing.Size(58, 13);
            this.realname_movie.TabIndex = 6;
            this.realname_movie.Text = "Real-name";
            // 
            // avatar_movie
            // 
            this.avatar_movie.Location = new System.Drawing.Point(0, 0);
            this.avatar_movie.Name = "avatar_movie";
            this.avatar_movie.Size = new System.Drawing.Size(162, 210);
            this.avatar_movie.TabIndex = 1;
            this.avatar_movie.TabStop = false;
            // 
            // item_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.realname_movie);
            this.Controls.Add(this.name_movie);
            this.Controls.Add(this.detail_movie);
            this.Controls.Add(this.avatar_movie);
            this.Name = "item_movie";
            this.Size = new System.Drawing.Size(162, 256);
            ((System.ComponentModel.ISupportInitialize)(this.avatar_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label detail_movie;
        public System.Windows.Forms.PictureBox avatar_movie;
        public System.Windows.Forms.Label name_movie;
        public System.Windows.Forms.Label realname_movie;
    }
}
