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
    public partial class achats : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OR83HS1\SQLEXPRESS01;Initial Catalog=pharmacine;Integrated Security=True");
        public void combobox()
        {
            string sql = "select * from Medicament01";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("nom_med", typeof(string));
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                box_achat.ValueMember = "nom_med";
                box_achat.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        int x;
        public void fetchquantite()
        {
            try
            {
                con.Open();
                string mysql = "select * from Medicament01 where Nom_med='" + box_achat.SelectedValue.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(mysql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                d.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    x = Convert.ToInt32(dr["quantite_med"].ToString());
                    // unite = Convert.ToInt32(dr["prix_med"].ToString());
                    quant_stocke.Text = "La Quantité dans Le Stock est:" + dr["quantite_med"].ToString();
                    quant_stocke.Visible = true;
                }
                con.Close();
            }
            catch 
            {

            } 
        }
        public void updateQuantMed()
        {
            con.Open();
            int y = Convert.ToInt32(quant_achat.Text.ToString());
            int newQuant = x + y ;
            string mysql = "update Medicament01 set quantite_med='"+newQuant+"'where Nom_med='" + box_achat.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void popular()
        {
            con.Open();
            string myquery = "select * from Medicament01";
            SqlDataAdapter dataAdaptor = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder commandbuilder = new SqlCommandBuilder(dataAdaptor);
            var ds = new DataSet();
            dataAdaptor.Fill(ds);
            Medapresmodification.ReadOnly = true;
           Medapresmodification.DataSource = ds.Tables[0];
            con.Close();
        }
        public achats()
        {
            InitializeComponent();
        }

        private void achats_Load(object sender, EventArgs e)
        {
            combobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateQuantMed();
            popular();
        }

        private void box_achat_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchquantite();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            echangeMed ec = new echangeMed();
            ec.Show();
            this.Hide();
        }
    }
}
