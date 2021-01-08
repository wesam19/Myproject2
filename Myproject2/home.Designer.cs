namespace Myproject2
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.HomePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePic
            // 
            this.HomePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePic.BackColor = System.Drawing.Color.Black;
            this.HomePic.Image = ((System.Drawing.Image)(resources.GetObject("HomePic.Image")));
            this.HomePic.Location = new System.Drawing.Point(-1, 0);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(656, 526);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 1;
            this.HomePic.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.HomePic);
            this.Name = "home";
            this.Size = new System.Drawing.Size(655, 526);
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePic;
    }
}
