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
    public partial class stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OR83HS1\SQLEXPRESS01;Initial Catalog=pharmacine;Integrated Security=True");
        public void popular()
        {
            con.Open();
            string myquery = "select * from Medicament01";
            SqlDataAdapter dataAdaptor = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder commandbuilder = new SqlCommandBuilder(dataAdaptor);
            var ds = new DataSet();
            dataAdaptor.Fill(ds);
            MedicamentGridView.ReadOnly = true;
            MedicamentGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public stock()
        {
            InitializeComponent();
        }
        public void fillfabrique()
        {
            string sql = "select Nom_fabriquant from Fabriquant ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Nom_fabriquant", typeof(string));
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                fabrique_med.ValueMember = "Nom_fabriquant";
                fabrique_med.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }

        private void stock_Load(object sender, EventArgs e)
        {
            popular();
            fillfabrique();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nom_med.Text = MedicamentGridView.SelectedRows[0].Cells[0].Value.ToString();
            prix_med.Text = MedicamentGridView.SelectedRows[0].Cells[1].Value.ToString();
            quantite_med.Text = MedicamentGridView.SelectedRows[0].Cells[2].Value.ToString();
            fabrique_med.Text = MedicamentGridView.SelectedRows[0].Cells[3].Value.ToString();
            date_med.Text = MedicamentGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom_med.Text == "" || prix_med.Text == "" || quantite_med.Text == "" || fabrique_med.SelectedItem == null || date_med.Text == "")
            {
                MessageBox.Show("enter tous les informations du medicament");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicament01 values('" + nom_med.Text + "','" + prix_med.Text + "','" + quantite_med.Text + "','" + fabrique_med.SelectedItem.ToString() + "','" + date_med.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Medicament est ajoute avec succes");
                con.Close();
                popular();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "UPDATE Medicament01 SET Nom_med='"+nom_med.Text+"',prix_med='"+prix_med.Text+"',quantite_med='"+quantite_med.Text+"',fabriquant_med='"+fabrique_med.SelectedItem.ToString() +"',date_med='"+date_med.Text+"' where Nom_med='"+nom_med.Text+"'; ";
           SqlCommand cmd = new SqlCommand(myquery, con);
           cmd.ExecuteNonQuery();
            MessageBox.Show("le Medicament est modifie");
            con.Close();
            popular();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nom_med.Text == "")
            {
                MessageBox.Show("specifie un Medicament SVP");
            }
            else
            {
                con.Open();
                string myquery = "delete from Medicament01 where Nom_med='" + nom_med.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Medicament est supprimer");
                con.Close();
                popular();
            }
        }
        homePage hp = new homePage();
        private void button4_Click(object sender, EventArgs e)
        {
            hp.Show();
            this.Hide();
        }

        private void nom_med_TextChanged(object sender, EventArgs e)
        {

        }

        private void fabrique_med_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
