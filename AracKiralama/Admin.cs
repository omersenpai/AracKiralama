
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AracKiralama
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Eksik Veri");
            }
            else if (txtName.Text == "Admin" || txtSifre.Text == "123456")
            {
                MüsteriAracKiralama aracKiralama = new MüsteriAracKiralama();
                aracKiralama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
            }

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Hatalı veya eksik karakter girdiniz.");
            }

        }
        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtName.Text == "Admin" && txtSifre.Text == "123456")
            {
                //enter'a basıldığında buraya girer.
                MüsteriAracKiralama aracKiralama = new MüsteriAracKiralama();
                aracKiralama.Show();
                this.Hide();
            }


        }

        private void LoginBtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Giriş_MouseHover(object sender, EventArgs e)
        {

        }

        private void Giriş_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}