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
    public partial class Edificio : Form
    {
        
        public Edificio()
        {
            InitializeComponent();
        }

        private void moPisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Septimo_Piso p7 = new Septimo_Piso();
            p7.MdiParent = this;
            p7.Show();
        }

        private void toPisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sexto_Piso p6 = new Sexto_Piso();
            p6.MdiParent = this;
            p6.Show();
        }

        private void toPisoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quinto_Piso p5 = new Quinto_Piso();
            p5.MdiParent = this;
            p5.Show();
        }

        private void toPisoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cuarto_Piso p4 = new Cuarto_Piso();
            p4.MdiParent = this;
            p4.Show();
        }

        private void erPisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tercer_Piso p3 = new Tercer_Piso();
            p3.MdiParent = this;
            p3.Show();
        }
        private void doPisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segundo_Piso p2 = new Segundo_Piso();
            p2.MdiParent = this;
            p2.Show();
        }
        private void erPisoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Primer_Piso p1 = new Primer_Piso();
            p1.MdiParent = this;
            p1.Show();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void plantaBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planta_baja pb = new Planta_baja();
            pb.MdiParent = this;
            pb.Show();
        }
        private void Edificio_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString()+" "+DateTime.Now.ToLongDateString();
        }
    }
}
