using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace gorselprogramlamaproje
{
    public partial class bagisyap : Form
    {
        public bagisyap()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kad = kadtxt.Text;
            string sifre = msifretxt.Text;
            string bagis = bagistxt.Text;
            try { int bagis2 = int.Parse(bagis);
                MessageBox.Show("bagis: miktari " +bagis2);
            String a = comboBox1.Text;
            if (kad.Equals(giris.veri.kullanici) && sifre.Equals(giris.veri.sifre))
            {
                if (giris.veri.bakiyesi >= bagis2 ) { 
                if (a.Equals(giris.veri.bagiskurumu1))
                {
                            
                        int bagis3 = giris.veri.losev + bagis2;
                            
                        giris.veridegis2("bagis1", bagis3);
                             giris.veri.losev = bagis3;

                           
                            giris.veri.bakiyesi -= bagis2;
                           
                        giris.veridegis2("bakiye",giris.veri.bakiyesi);
                        MessageBox.Show(+bagis2 + "TL Değerinde Bağışınız Gerçekleşmiştir.Değerli Bağışınız İçin Teşekkür ederiz. - "+ giris.veri.bagiskurumu1);

                    }
                else if (a.Equals(giris.veri.bagiskurumu2))
                {
                        int bagis3 = giris.veri.darrusafaka + bagis2;
                        giris.veridegis2("bagis2", bagis3);
                        giris.veri.darrusafaka = bagis3;
                        giris.veri.bakiyesi -= bagis2;
                        giris.veridegis2("bakiye", giris.veri.bakiyesi);
                        MessageBox.Show(+bagis2 + "TL Değerinde Bağışınız Gerçekleşmiştir.Değerli Bağışınız İçin Teşekkür ederiz. -"+ giris.veri.bagiskurumu2);
                    }
                else if (a.Equals(giris.veri.bagiskurumu3))
                {
                        int bagis3 = giris.veri.gaziler + bagis2;
                        giris.veridegis2("bagis3", bagis3);
                        giris.veri.gaziler = bagis3;
                        giris.veri.bakiyesi -= bagis2;
                        giris.veridegis2("bakiye", giris.veri.bakiyesi);
                        MessageBox.Show(+bagis2+"TL Değerinde Bağışınız Gerçekleşmiştir.Değerli Bağışınız İçin Teşekkür ederiz. - "+ giris.veri.bagiskurumu3);
                    }
                else { MessageBox.Show("Lütfen bir kurum seçiniz."); }
                }else { MessageBox.Show("Bağış Yapmak İstediğiniz Miktar Bakiyenizde bulunmuyor."); }




            }
            else { MessageBox.Show("Kullanıcı Bilgileriniz Yanlış!"); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Geçerli Bir Bağış Miktarı Giriniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenu anamenu = new anamenu();
            anamenu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bagisyap_Load(object sender, EventArgs e)
        { 
            if (giris.veri.gizlimi1 == 1) {  } else if (giris.veri.gizlimi1 == 0) { comboBox1.Items.Add(giris.veri.bagiskurumu1); }
            if (giris.veri.gizlimi2 == 1) {  } else if (giris.veri.gizlimi2 == 0) { comboBox1.Items.Add(giris.veri.bagiskurumu2); }
            if (giris.veri.gizlimi3 == 1) {  } else if (giris.veri.gizlimi3 == 0) { comboBox1.Items.Add(giris.veri.bagiskurumu3); }

            if (giris.veri.gizlimi1 == 1 && giris.veri.gizlimi2 == 1 && giris.veri.gizlimi3 == 1) { comboBox1.Items.Add("Gosterilecek Bir Bagis Kurumu Bulunmuyor!"); button1.Hide(); }
            else { button1.Show(); }

        }
    }
}
