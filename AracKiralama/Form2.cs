using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Rapor : Form

    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5BIT6VN\\SQLEXPRESS;database=AracKiralama;Integrated Security=True");



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void AracKiralamaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonToplamKazancGoster_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("select sum(Odeme_tutarı) from MusteriAracKiralama", con);
            var a = sqlCommand.ExecuteScalar();
            labelKazanc.Text = a.ToString();
            con.Close();
        }

        private void verileriGoster(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            AracKiralamaDataGridView.DataSource = ds.Tables[0];

        }
        private void btGeriDon_Click(object sender, EventArgs e)
        {
            MüsteriAracKiralama aracKiralama = new MüsteriAracKiralama();
            aracKiralama.Show();
            this.Hide();

        }

        private void Rapor_Load(object sender, EventArgs e)
        {

            verileriGoster("Select*from MusteriAracKiralama");
        }



        private void btAracSayisi_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("select count(aracID) from MusteriAracKiralama", con);
            var b = sqlCommand.ExecuteScalar();//Sorguyu çalıştırır,ve istenilen alandaki değeri geri döndürür.
            labelAracSayisi.Text = b.ToString();
            con.Close();
        }

        private void btAracSayisi_MouseHover(object sender, EventArgs e)
        {

        }

        private void btAracSayisi_MouseLeave(object sender, EventArgs e)
        {

        }

        private void buttonToplamKazancGoster_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonToplamKazancGoster_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        SqlCommand komut;
        void KayıtSil(int AracKiralamaID)
        {
            string sql = "DELETE FROM MusteriAracKiralama WHERE AracKiralamaID=@AracKiralamaID";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@AracKiralamaID", AracKiralamaID);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in AracKiralamaDataGridView.SelectedRows)  //Seçili Satırları Silme
            {
                int AracKiralamaID = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(AracKiralamaID);
            }
            verileriGoster("Select*from MusteriAracKiralama");
        }
    }
}

