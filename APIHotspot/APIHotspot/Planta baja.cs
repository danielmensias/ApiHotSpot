using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIHotspot
{
    public partial class Planta_baja : Form
    {
        public Planta_baja()
        {
            InitializeComponent();
        }
        private void Planta_baja_Load(object sender, EventArgs e)
        {
            deshabilitar();
        }
        public void deshabilitar()
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            pictureBox8.Visible = false; pictureBox9.Visible = false; pictureBox10.Visible = false;
            pictureBox11.Visible = false; 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox10.Visible = true;
            pictureBox10.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pictureBox11.Visible = true; 
            pictureBox11.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
            pictureBox5.Visible = true; pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox8.Visible = true; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox9.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("26.jpg");
            img.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("8.jpg");
            img.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("9.jpg");
            img.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Informacion inf = new Informacion();
            inf.Show();
            inf.BringToFront();
        }
    }
}
