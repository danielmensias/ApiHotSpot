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
    public partial class Form1 : Form
    {
        Edificio edif;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            edif = new Edificio();
            edif.Show();
            this.Hide();
        }
    }
}
