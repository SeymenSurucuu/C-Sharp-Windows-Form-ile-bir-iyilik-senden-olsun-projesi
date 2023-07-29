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
    public partial class kadegistir : Form
    {
        public kadegistir()
        {
            InitializeComponent();
        }

        private void kadegistir_Load(object sender, EventArgs e)
        {
            mkullaniciadi.Text = giris.veri.kullanici;
            if (giris.veri.cinsiyet == "erkek")
            {
                pictureBox2.Hide();
            }
            else if (giris.veri.cinsiyet == "kadin") { pictureBox1.Hide(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sifrem =msifretxt.Text;
            if (!(ykadi.Text == String.Empty)) { 
              String ykad =ykadi.Text;
            
            if (sifrem.Equals(giris.veri.sifre)) {

                    giris.veri.kullanici = ykad;
                    giris.veridegis1("kullaniciadi", ykad);
                    MessageBox.Show("Kullanıcı Adınız Başarıyla Değişti! Yeni Kullanıcı Adınız: "+ykad);

                } else { MessageBox.Show("Şifreniz Yanlış"); }
            }
            else { MessageBox.Show("Lütfen Yeni bir kullanıcı adı giriniz."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenu git = new anamenu();
            git.Show();
            this.Hide();
        }
    }
}
