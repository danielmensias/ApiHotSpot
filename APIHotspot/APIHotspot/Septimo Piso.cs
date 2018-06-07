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
    public partial class Septimo_Piso : Form
    {
        public Septimo_Piso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
            pictureBox5.Visible = true; pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox8.Visible = true; button1.Visible = true;
        }

        public void deshabilitar()
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            pictureBox8.Visible = false; pictureBox9.Visible = false; pictureBox10.Visible = false;
            pictureBox11.Visible = false; button1.Visible = false;
        }

        private void Septimo_Piso_Load(object sender, EventArgs e)
        {
            deshabilitar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox9.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox10.Visible = true; pictureBox11.Visible = true; pictureBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("35.jpg");
            img.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("32.jpg");
            img.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("33.jpg");
            img.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("36.jpg");
            img.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ing. Maria Soledad Jimenez ------- QE/707\nDr. Ivan Bernal ------- QE/712\nUME ------- QE/708","Oficinas");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
