using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dot_net
{
    public partial class echangeMed : Form
    {
        public echangeMed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            achats ac = new achats();
            ac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facture f = new Facture();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            hp.Show();
            this.Hide();
        }
    }
}
