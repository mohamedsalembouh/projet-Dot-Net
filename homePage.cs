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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }
        
        
        

        private void label1_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            s.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Facture fa = new Facture();
            fa.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Fabriquant f = new Fabriquant();
            f.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 lg = new Form1();
            lg.Show();
            this.Hide();
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            echangeMed em = new echangeMed();
            em.Show();
            this.Hide();
        }
    }
}
