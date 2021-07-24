using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace projet_dot_net
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OR83HS1\SQLEXPRESS01;Initial Catalog=pharmacine;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            /**  if (nom_utilisateur.Text=="med" && mot_de_pass.Text=="123") {
                  hp.Show();
                  this.Hide();
              }
              else
              {
                  MessageBox.Show("erreur dans votre nom ou votre mot de pass");
              }**/
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from employee where nom_emp='"+nom_utilisateur.Text+"'and pass_emp='"+mot_de_pass.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows[0][0].ToString()=="1")
            {
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("erreur dans votre nom ou votre mot de pass");
            }

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mot_de_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
