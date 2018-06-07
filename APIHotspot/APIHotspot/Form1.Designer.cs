namespace APIHotspot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBienvenido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBienvenido
            // 
            this.btnBienvenido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBienvenido.Font = new System.Drawing.Font("Bodoni MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBienvenido.Location = new System.Drawing.Point(174, 330);
            this.btnBienvenido.Name = "btnBienvenido";
            this.btnBienvenido.Size = new System.Drawing.Size(147, 31);
            this.btnBienvenido.TabIndex = 0;
            this.btnBienvenido.Text = "BIENVENIDO";
            this.btnBienvenido.UseVisualStyleBackColor = false;
            this.btnBienvenido.Click += new System.EventHandler(this.btnBienvenido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 369);
            this.Controls.Add(this.btnBienvenido);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Redes de área local inalambricas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBienvenido;

    }
}

