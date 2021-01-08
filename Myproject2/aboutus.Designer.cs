namespace Myproject2
{
    partial class aboutus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gmail = new System.Windows.Forms.PictureBox();
            this.instagram = new System.Windows.Forms.PictureBox();
            this.whatsapp = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whatsapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.gmail);
            this.panel1.Controls.Add(this.instagram);
            this.panel1.Controls.Add(this.whatsapp);
            this.panel1.Controls.Add(this.facebook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 512);
            this.panel1.TabIndex = 1;
            // 
            // gmail
            // 
            this.gmail.Image = ((System.Drawing.Image)(resources.GetObject("gmail.Image")));
            this.gmail.Location = new System.Drawing.Point(402, 458);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(43, 38);
            this.gmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gmail.TabIndex = 10;
            this.gmail.TabStop = false;
            this.gmail.Click += new System.EventHandler(this.gmail_Click);
            // 
            // instagram
            // 
            this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
            this.instagram.Location = new System.Drawing.Point(340, 458);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(43, 38);
            this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.instagram.TabIndex = 9;
            this.instagram.TabStop = false;
            this.instagram.Click += new System.EventHandler(this.instagram_Click);
            // 
            // whatsapp
            // 
            this.whatsapp.Image = ((System.Drawing.Image)(resources.GetObject("whatsapp.Image")));
            this.whatsapp.Location = new System.Drawing.Point(272, 458);
            this.whatsapp.Name = "whatsapp";
            this.whatsapp.Size = new System.Drawing.Size(43, 38);
            this.whatsapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.whatsapp.TabIndex = 8;
            this.whatsapp.TabStop = false;
            this.whatsapp.Click += new System.EventHandler(this.whatsapp_Click);
            // 
            // facebook
            // 
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Location = new System.Drawing.Point(209, 458);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(43, 38);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebook.TabIndex = 7;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contact With Us";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // aboutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "aboutus";
            this.Size = new System.Drawing.Size(655, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whatsapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox gmail;
        private System.Windows.Forms.PictureBox instagram;
        private System.Windows.Forms.PictureBox whatsapp;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
