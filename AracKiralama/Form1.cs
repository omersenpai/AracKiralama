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
    public partial class AracGiris : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5BIT6VN\\SQLEXPRESS;database=AracKiralama;Integrated Security=True");

        public AracGiris()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracKiralamaDataSet7.Araclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.araclarTableAdapter.Fill(this.aracKiralamaDataSet7.Araclar);
            
            txtAracPlaka.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verileriGoster(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            AracDataGridView.DataSource = ds.Tables[0];

        }
        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_AracKayit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@plaka", txtAracPlaka.Text);
            cmd.Parameters.AddWithValue("@marka", cmbmarka.Text);
            cmd.Parameters.AddWithValue("@model", cmbmodel.Text);
            cmd.Parameters.AddWithValue("@durum", txtDurum.Text);
            //1 aktif demek,0 inaktif demek
            if (txtDurum.Text != "1")
            {
                MessageBox.Show("Aktif olan araçları giriniz.");
            }

            else
            {
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Kayıt Başarılı");
                txtAracPlaka.Clear();
                cmbmarka.SelectedIndex = -1;
                cmbmodel.SelectedIndex = -1;
                txtDurum.Clear();
            }
            verileriGoster("Select*from Araclar");
            con.Close();
        }



        private void btGeriDon_Click(object sender, EventArgs e)
        {
            MüsteriAracKiralama aracKiralama = new MüsteriAracKiralama();
            aracKiralama.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAracID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDurum_Click(object sender, EventArgs e)
        {

        }

        private void labelModel_Click(object sender, EventArgs e)
        {

        }

        private void labelMarka_Click(object sender, EventArgs e)
        {

        }

        private void labelPlaka_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxAracKayıt_Enter(object sender, EventArgs e)
        {

        }

        private void btnAracKaydet_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAracKaydet_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btGeriDon_MouseHover(object sender, EventArgs e)
        {

        }

        private void btGeriDon_MouseLeave(object sender, EventArgs e)
        {

        }

        SqlCommand komut;
        void KayıtSil(int aracID)
        {
            string sql = "DELETE FROM Araclar WHERE aracID=@aracID";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@aracID", aracID);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in AracDataGridView.SelectedRows)  //Seçili Satırları Silme
            {
                int aracID = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(aracID);
            }
            verileriGoster("Select*from Araclar");
        }
    }
}
