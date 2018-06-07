namespace APIHotspot
{
    partial class imagen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboximage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboximage)).BeginInit();
            this.SuspendLayout();
            // 
            // pboximage
            // 
            this.pboximage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboximage.Location = new System.Drawing.Point(0, 0);
            this.pboximage.Name = "pboximage";
            this.pboximage.Size = new System.Drawing.Size(325, 358);
            this.pboximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboximage.TabIndex = 0;
            this.pboximage.TabStop = false;
            // 
            // imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 358);
            this.Controls.Add(this.pboximage);
            this.Name = "imagen";
            this.Text = "imagen";
            ((System.ComponentModel.ISupportInitialize)(this.pboximage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pboximage;
    }
}