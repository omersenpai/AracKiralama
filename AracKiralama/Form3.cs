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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AracKiralama
{
    public partial class MüsteriGiris : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5BIT6VN\\SQLEXPRESS;database=AracKiralama;Integrated Security=True");
        public MüsteriGiris()
        {
            InitializeComponent();
        }



        private void MüsteriGiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracKiralamaDataSet8.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.aracKiralamaDataSet8.Musteri);

        }

        private void btGeriDon_Click(object sender, EventArgs e)
        {
            MüsteriAracKiralama aracKiralama = new MüsteriAracKiralama();
            aracKiralama.Show();
            this.Hide();
        }

        private void btMusteriKayit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_MusteriKayit", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@soyad", txtMusteriSoyad.Text);
            cmd.Parameters.AddWithValue("@ad", txtMusteriAdi.Text);
            cmd.Parameters.AddWithValue("@tc", txtMaskedKimlik.Text);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Kayıt Başarılı");
            verileriGoster("Select*from Musteri");
            txtMusteriAdi.Clear();
            txtMusteriSoyad.Clear();
            txtMaskedKimlik.Clear();
            con.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMusteriSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {

        }


        private void verileriGoster(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MusteriDataGridView.DataSource = ds.Tables[0];

        }

        private void txtMusKaydet_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtMusKaydet_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btGeriDon_MouseHover(object sender, EventArgs e)
        {

        }

        private void btGeriDon_MouseLeave(object sender, EventArgs e)
        {

        }
        SqlCommand komut;
        void KayıtSil(int musteriID)
        {
            string sql = "DELETE FROM Musteri WHERE musteriID=@musteriID";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@musteriID", musteriID);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in MusteriDataGridView.SelectedRows)  //Seçili Satırları Silme
            {
                int musteriID = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(musteriID);
            }
            verileriGoster("Select*from Musteri");
        }
    }
}
