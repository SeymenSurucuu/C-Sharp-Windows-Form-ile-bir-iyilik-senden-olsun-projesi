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
    public partial class faturaiste : Form
    {
        public faturaiste()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           String a =  user1.Text;
           String b = pass.Text;
            if (a.Equals(giris.veri.kullanici) && b.Equals(giris.veri.sifre)) {

                if (!(textBox1.Text == String.Empty))
                {
                    String ast = textBox1.Text;
                    try {
                        int bes = int.Parse(ast);
                        int alti = giris.veri.fatura + bes;
                        giris.veridegis2("fatura",alti);
                        giris.veri.fatura = alti;
                        MessageBox.Show("Fatura Başarıyla İşlendi!");
                    }
                    catch (FormatException) { MessageBox.Show("Hatı İşlem"); }
                }
                else { MessageBox.Show("Lütfen geçerli bir fatura miktarı giriniz."); }

            }
            else { MessageBox.Show("Bilgileriniz Yanlış"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenu git = new anamenu();
            git.Show();
            this.Hide();
        }
    }
}
