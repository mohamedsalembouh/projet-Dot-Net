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
    public partial class Fabriquant : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OR83HS1\SQLEXPRESS01;Initial Catalog=pharmacine;Integrated Security=True");
        public void popular()
        {
            con.Open();
            string myquery = "select * from Fabriquant";
            SqlDataAdapter dataAdaptor = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder commandbuilder = new SqlCommandBuilder(dataAdaptor);
            var ds = new DataSet();
            dataAdaptor.Fill(ds);
            Fab_dataGridView1.ReadOnly = true;
            Fab_dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public Fabriquant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numero_fab.Text == "" || nom_fab.Text == "" || addresse_fab.Text == "" || tel_fab.Text == "")
            {
                MessageBox.Show("entrer tous les informations du Fabricant");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Fabriquant  values('" + numero_fab.Text + "','" + nom_fab.Text + "','" + addresse_fab.Text + "','" + tel_fab.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Fabricant est ajoute");
                con.Close();
                popular();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numero_fab.Text == "" || nom_fab.Text == "" || addresse_fab.Text == "" || tel_fab.Text == "")
            {
                MessageBox.Show("entrer tous les informations ");
            }
            else
            {
                con.Open();
                string myquery = "UPDATE Fabriquant SET Numero_Fabriquant='" + numero_fab.Text + "',Nom_Fabriquant='" + nom_fab.Text + "',Addresse_Fabriquant='" + addresse_fab.Text + "',Telephone_Fabriquant='" + tel_fab.Text + "'  where Numero_Fabriquant='" + numero_fab.Text + "'; ";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Fabricant est Modifie");
                con.Close();
                popular();
            }
        }

        private void Fabriquant_Load(object sender, EventArgs e)
        {
            popular();
        }

        private void MedicamentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        homePage hp = new homePage();
        private void button4_Click(object sender, EventArgs e)
        {
            hp.Show();
            this.Hide();
        }

        private void numero_fab_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fab_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numero_fab.Text = Fab_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nom_fab.Text = Fab_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            addresse_fab.Text = Fab_dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tel_fab.Text = Fab_dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numero_fab.Text == "")
            {
                MessageBox.Show("specifie un Fabricant");
            }
            else
            {
                con.Open();
                string myquery = "delete from Fabriquant where Numero_Fabriquant ='" + numero_fab.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fabricant est supprimer");
                con.Close();
                popular();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

