using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaproje
{
    public partial class sifre_degistir : Form
    {
        public sifre_degistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kad = kadtxt.Text;
            String msifre = msifretxt.Text;
            String ysifre = ysifretxt.Text;
            String ysifre2 = ysifretxt2.Text;

            if (kad.Equals(giris.veri.kullanici)) {
                if (msifre.Equals(giris.veri.sifre)) {
                    if (ysifre.Equals(ysifre2)) {
                        giris.veridegis1("sifre",ysifre);
                        giris.veri.sifre = ysifre;
                        MessageBox.Show("Şifrenizi Başarıyla Değiştirdik!");
                    } else { MessageBox.Show("Yazdığınız Şifreler Aynı Değil."); }
                }else { MessageBox.Show("Mevcut şifreniz sistem ile uyuşmuyor."); }
            
            
            }else { MessageBox.Show("Kullanıcı Adınız Sistemimizdeki Verileri ile uyuşmuyor."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenu git = new anamenu();
            git.Show();
            this.Hide();
        }

        private void sifre_degistir_Load(object sender, EventArgs e)
        {
            if (giris.veri.cinsiyet == "erkek")
            {
                pictureBox2.Hide();
            }
            else if (giris.veri.cinsiyet == "kadin") { pictureBox1.Hide(); }
        }
    }
}
