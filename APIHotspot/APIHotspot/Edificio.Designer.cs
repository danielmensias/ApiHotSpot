namespace APIHotspot
{
    partial class Edificio
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moPisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toPisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toPisoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toPisoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.erPisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doPisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erPisoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plantaBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moPisoToolStripMenuItem,
            this.toPisoToolStripMenuItem,
            this.toPisoToolStripMenuItem1,
            this.toPisoToolStripMenuItem2,
            this.erPisoToolStripMenuItem,
            this.doPisoToolStripMenuItem,
            this.erPisoToolStripMenuItem1,
            this.plantaBajaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // moPisoToolStripMenuItem
            // 
            this.moPisoToolStripMenuItem.Name = "moPisoToolStripMenuItem";
            this.moPisoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.moPisoToolStripMenuItem.Text = "&7mo Piso";
            this.moPisoToolStripMenuItem.Click += new System.EventHandler(this.moPisoToolStripMenuItem_Click);
            // 
            // toPisoToolStripMenuItem
            // 
            this.toPisoToolStripMenuItem.Name = "toPisoToolStripMenuItem";
            this.toPisoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toPisoToolStripMenuItem.Text = "&6to Piso";
            this.toPisoToolStripMenuItem.Click += new System.EventHandler(this.toPisoToolStripMenuItem_Click);
            // 
            // toPisoToolStripMenuItem1
            // 
            this.toPisoToolStripMenuItem1.Name = "toPisoToolStripMenuItem1";
            this.toPisoToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toPisoToolStripMenuItem1.Text = "&5to Piso";
            this.toPisoToolStripMenuItem1.Click += new System.EventHandler(this.toPisoToolStripMenuItem1_Click);
            // 
            // toPisoToolStripMenuItem2
            // 
            this.toPisoToolStripMenuItem2.Name = "toPisoToolStripMenuItem2";
            this.toPisoToolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.toPisoToolStripMenuItem2.Text = "&4to Piso";
            this.toPisoToolStripMenuItem2.Click += new System.EventHandler(this.toPisoToolStripMenuItem2_Click);
            // 
            // erPisoToolStripMenuItem
            // 
            this.erPisoToolStripMenuItem.Name = "erPisoToolStripMenuItem";
            this.erPisoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.erPisoToolStripMenuItem.Text = "&3er Piso";
            this.erPisoToolStripMenuItem.Click += new System.EventHandler(this.erPisoToolStripMenuItem_Click);
            // 
            // doPisoToolStripMenuItem
            // 
            this.doPisoToolStripMenuItem.Name = "doPisoToolStripMenuItem";
            this.doPisoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.doPisoToolStripMenuItem.Text = "&2do Piso";
            this.doPisoToolStripMenuItem.Click += new System.EventHandler(this.doPisoToolStripMenuItem_Click);
            // 
            // erPisoToolStripMenuItem1
            // 
            this.erPisoToolStripMenuItem1.Name = "erPisoToolStripMenuItem1";
            this.erPisoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.erPisoToolStripMenuItem1.Text = "&1er Piso";
            this.erPisoToolStripMenuItem1.Click += new System.EventHandler(this.erPisoToolStripMenuItem1_Click);
            // 
            // plantaBajaToolStripMenuItem
            // 
            this.plantaBajaToolStripMenuItem.Name = "plantaBajaToolStripMenuItem";
            this.plantaBajaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.plantaBajaToolStripMenuItem.Text = "&Planta Baja";
            this.plantaBajaToolStripMenuItem.Click += new System.EventHandler(this.plantaBajaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(752, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1051, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Edificio";
            this.Text = "Edificio";
            this.Load += new System.EventHandler(this.Edificio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moPisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toPisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toPisoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toPisoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem erPisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doPisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erPisoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plantaBajaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}