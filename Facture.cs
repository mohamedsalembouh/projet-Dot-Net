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
using System.Net.Mail;

namespace projet_dot_net
{
    public partial class Facture : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OR83HS1\SQLEXPRESS01;Initial Catalog=pharmacine;Integrated Security=True");
        public void combobox()
        {
            string sql = "select * from Medicament01";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader rd;
            try {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("nom_med",typeof(string));
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                comboBox2.ValueMember = "nom_med";
                comboBox2.DataSource = dt;
                con.Close();
            }
            catch 
            {

            }
        }
        int x,unite;
        public void fetchquantite()
        {
            con.Open();
            string mysql = "select * from Medicament01 where Nom_med='" + comboBox2.SelectedValue.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(mysql,con);
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                 x = Convert.ToInt32(dr["quantite_med"].ToString());
                unite = Convert.ToInt32(dr["prix_med"].ToString());
                stock.Text = "La quantité dans le stock est  :"+dr["quantite_med"].ToString();
                stock.Visible = true;
            }


            con.Close();
        }
        public void updateQuantMed()
        {
            con.Open();
            int newQuant = x - Convert.ToInt32(quantbox.Text.ToString());
            string mysql = "update Medicament01 set quantite_med='"+newQuant+"'where Nom_med='"+comboBox2.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //fonction qui envoyer un message email au client
        public static void CreateTestMessage2(string server)
        {
            string to = "jane@contoso.com";
            string from = "ben@contoso.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an email message from an application very easily.";
            SmtpClient client = new SmtpClient(server);
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }
        public Facture()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Facture_Load(object sender, EventArgs e)
        {
            combobox();
        }
        int gridtotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (quantbox.Text == "" || Convert.ToInt32(quantbox.Text) > x)
            {
                MessageBox.Show("s'il vous plait entrer une quantité existe");
            }
            else
            {
                int total = Convert.ToInt32(quantbox.Text) * unite;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(facturedataGridView);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = comboBox2.SelectedValue.ToString();
                newrow.Cells[2].Value = quantbox.Text;
                newrow.Cells[3].Value = unite;
                newrow.Cells[4].Value = unite * Convert.ToInt32(quantbox.Text);
                facturedataGridView.Rows.Add(newrow);
                gridtotal = gridtotal + total;
                montant_total.Text = gridtotal + "MRU";
                updateQuantMed();
                
            }
            n = n + 1;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }
        homePage hp = new homePage();
        private void button2_Click_1(object sender, EventArgs e)
        {
            hp.Show();
            this.Hide();
        }
        Bitmap bitmap;
        private void label2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphic = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphic);
            graphic = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphic.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphic = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphic);
            graphic = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphic.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchquantite();
        }
    }
}
