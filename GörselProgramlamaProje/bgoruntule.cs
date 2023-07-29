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

namespace gorselprogramlamaproje
{
    public partial class bgoruntule : Form
    {
        public bgoruntule()
        {
            InitializeComponent();
        }

        private void bgoruntule_Load(object sender, EventArgs e)
        {
            int gazi = giris.veri.gaziler;
            int daru = giris.veri.darrusafaka;
            int losev = giris.veri.losev;
            if (giris.veri.gizlimi1 == 1) { label2.Hide(); label6.Hide(); } else if (giris.veri.gizlimi1 == 0) { label2.Text = giris.veri.bagiskurumu1+" BAĞIŞINIZ"; label6.Text = losev.ToString() + " TL"; }
            if (giris.veri.gizlimi2 == 1) { label1.Hide(); label5.Hide(); } else if (giris.veri.gizlimi2 == 0) { label1.Text = giris.veri.bagiskurumu2 + " BAĞIŞINIZ"; label5.Text = daru.ToString() + " TL"; }
            if (giris.veri.gizlimi3 == 1) { label3.Hide(); label4.Hide(); } else if (giris.veri.gizlimi3 == 0) { label3.Text = giris.veri.bagiskurumu3 + " BAĞIŞINIZ"; label4.Text = gazi.ToString() + " TL"; }

            if (giris.veri.gizlimi1 == 1 && giris.veri.gizlimi2 == 1 && giris.veri.gizlimi3 == 1) { yok.Text = "Gosterilecek Bir Bagis Kurumu Bulunmuyor."; }
           
           

            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anamenu git = new anamenu();
            git.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
