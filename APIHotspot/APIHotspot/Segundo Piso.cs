﻿using System;
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
    public partial class Segundo_Piso : Form
    {
        public Segundo_Piso()
        {
            InitializeComponent();
        }

        private void Segundo_Piso_Load(object sender, EventArgs e)
        {
            deshabilitar();
        }
        public void deshabilitar()
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false; pictureBox6.Visible = false; pictureBox7.Visible = false;
            pictureBox8.Visible = false; pictureBox9.Visible = false; pictureBox10.Visible = false;
            pictureBox11.Visible = false; pictureBox13.Visible = false; pictureBox14.Visible = false;
            pictureBox15.Visible = false; pictureBox16.Visible = false; pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
            pictureBox5.Visible = true; pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox8.Visible = true; button1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            deshabilitar();
            pictureBox13.Visible = true; pictureBox16.Visible = true; pictureBox18.Visible = true;
            pictureBox14.Visible = true; pictureBox17.Visible = true; pictureBox2.Visible = true;
            pictureBox15.Visible = true;
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
            img.pboximage.Load("16.jpg");
            img.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("14.jpg");
            img.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.pboximage.Load("15.jpg");
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
