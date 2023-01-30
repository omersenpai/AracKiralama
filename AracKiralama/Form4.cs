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

    public partial class MüsteriAracKiralama : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5BIT6VN\\SQLEXPRESS;database=AracKiralama;Integrated Security=True");
        public MüsteriAracKiralama()
        {
            InitializeComponent();
        }

        private void MüsteriAracKiralama_Load(object sender, EventArgs e)  //Form yüklendikten sonra tetiklenecek olayları burada yer alır. 
        {

            // TODO: Bu kod satırı 'aracKiralamaDataSet16.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter2.Fill(this.aracKiralamaDataSet16.Musteri);
            // TODO: Bu kod satırı 'aracKiralamaDataSet15.Araclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.araclarTableAdapter2.Fill(this.aracKiralamaDataSet15.Araclar);

            this.musteriTableAdapter.Fill(this.aracKiralamaDataSet6.Musteri);
            this.araclarTableAdapter.Fill(this.aracKiralamaDataSet4.Araclar);

            this.musteriAracKiralamaTableAdapter.Fill(this.aracKiralamaDataSet2.MusteriAracKiralama);

            araclar();
            cmbDoldurMarka();
            cmbDoldurModel();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void MusteriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void cmbDoldurMarka()
        {
            con.Open();

            SqlCommand doldur = new SqlCommand("SELECT marka from Araclar", con);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                cmbmarka.Items.Add(dr[0]);
            }
            con.Close();

        }
        void cmbDoldurModel()
        {
            con.Open();

            SqlCommand doldur = new SqlCommand("SELECT model from Araclar", con);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                cmbmodel.Items.Add(dr[0]);
            }
            con.Close();

        }
        private void MusteriDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = MusteriDataGridView.Rows[index];
            txtMusteriID.Text = selectedRow.Cells[0].Value.ToString();
            txtTc.Text = selectedRow.Cells[1].Value.ToString();
        }
        private void AracDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index1 = e.RowIndex;

            DataGridViewRow selectedRow1 = AracDataGridView.Rows[index1];
            txtAracID.Text = selectedRow1.Cells[0].Value.ToString();
            cmbmarka.Text = selectedRow1.Cells[1].Value.ToString();
            cmbmodel.Text = selectedRow1.Cells[2].Value.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Marka_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriTc_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btKirala_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SpMusteriAracKiralamaIns", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@musteriID", txtMusteriID.Text);
            cmd.Parameters.AddWithValue("@aracID", txtAracID.Text);
            cmd.Parameters.AddWithValue("@kiralama_Tarihi", txtAracKiraTarih.Value);
            cmd.Parameters.AddWithValue("@kiralama_Suresi", txtKiraSure.Text);
            cmd.Parameters.AddWithValue("@Odeme_tutarı", txtOdemeTutari.Text);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Kayıt Başarılı");

            con.Close();
            durum();

            cmbmarka.SelectedIndex = -1;
            cmbmodel.SelectedIndex = -1;
            txtAracID.Clear();
            txtMusteriID.Clear();
            txtOdemeTutari.Clear();
            txtKiraSure.Clear();
            araclar();

        }


        public void araclar()
        {
            con.Open();
            DataTable dTable = new DataTable();
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM Araclar WHERE durum=1", con))
            {
                dAdapter.Fill(dTable);
            }
            AracDataGridView.DataSource = dTable;
            con.Close();

        }
        private void durum()
        {
            con.Open();
            SqlCommand drm = new SqlCommand("sp_durum", con);
            drm.CommandType = CommandType.StoredProcedure;
            drm.Parameters.AddWithValue("@aracID", txtAracID.Text);
            drm.ExecuteNonQuery();
            drm.Parameters.Clear();
            con.Close();
        }
        private void durum_1(int aracID)
        {
            con.Open();
            SqlCommand drm = new SqlCommand("sp_durumBir", con);
            drm.CommandType = CommandType.StoredProcedure;
            drm.Parameters.AddWithValue("@aracID", txtAracID.Text);
            drm.ExecuteNonQuery();
            drm.Parameters.Clear();
            con.Close();
        }




        private void btMusteriKayit_Click(object sender, EventArgs e)
        {

            MüsteriGiris musteriGiris = new MüsteriGiris();
            musteriGiris.Show();
            this.Hide();
        }

        private void btAracGiris_Click(object sender, EventArgs e)
        {
            AracGiris aracGiris = new AracGiris();
            aracGiris.Show();
            this.Hide();
        }
        private void btCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        SqlCommand komut;

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void TimerBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            hour.Text = DateTime.Now.ToLongTimeString();
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            date.Text = String.Empty;
            hour.Text = String.Empty;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AracDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SqlCommand cmd;
        SqlDataReader dr;

        private void btRapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();

            this.Hide();
        }



        private void MusteriAracKiralamaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MusteriAracKiralamaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAracKiraTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAracID_TextChanged(object sender, EventArgs e)
        {
            txtAracID.BorderStyle = BorderStyle.None;
        }

        private void btAracGiris_MouseHover(object sender, EventArgs e)
        {

        }

        private void btAracGiris_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btMusteriKayit_MouseHover(object sender, EventArgs e)
        {

        }

        private void btMusteriKayit_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btRapor_MouseHover(object sender, EventArgs e)
        {

        }

        private void btRapor_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btCikis_MouseHover(object sender, EventArgs e)
        {

        }

        private void btCikis_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btKirala_MouseHover(object sender, EventArgs e)
        {

        }

        private void btKirala_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TimerBaslat_MouseHover(object sender, EventArgs e)
        {

        }

        private void TimerBaslat_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Stopbutton_MouseHover(object sender, EventArgs e)
        {

        }

        private void Stopbutton_MouseLeave(object sender, EventArgs e)
        {

        }


    }
}
