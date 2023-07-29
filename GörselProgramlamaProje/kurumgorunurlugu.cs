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
    public partial class kurumgorunurlugu : Form
    {
        public kurumgorunurlugu()
        {
            InitializeComponent();
        }

        private void kurumgorunurlugu_Load(object sender, EventArgs e)
        {
            label1.Text = giris.veri.bagiskurumu1;
            label2.Text = giris.veri.bagiskurumu2;
            label3.Text = giris.veri.bagiskurumu3;

            comboBox1.Items.Add("Goster");
            comboBox1.Items.Add("Gizle");

            comboBox2.Items.Add("Goster");
            comboBox2.Items.Add("Gizle");

            comboBox3.Items.Add("Goster");
            comboBox3.Items.Add("Gizle");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminmenu adminmenu = new Adminmenu();
            adminmenu.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a  = comboBox1.Text;
            String b = comboBox2.Text;
            String c = comboBox3.Text;
            if (a.Equals("Gizle")) { giris.veri.gizlimi1 = 1; giris.veridegis5("b1kurum",1); MessageBox.Show(giris.veri.bagiskurumu1 + " Gizlendi." ); } else if (a.Equals("Goster")) { giris.veri.gizlimi1 = 0; giris.veridegis5("b1kurum", 0); MessageBox.Show(giris.veri.bagiskurumu1 + " Aktif Hale Getirildi."); }
            if (b.Equals("Gizle")) { giris.veri.gizlimi2 = 1; giris.veridegis5("b2kurum", 1); MessageBox.Show(giris.veri.bagiskurumu2 + " Gizlendi."); } else if (b.Equals("Goster")) { giris.veri.gizlimi2 = 0; giris.veridegis5("b2kurum", 0); MessageBox.Show(giris.veri.bagiskurumu2 + " Aktif Hale Getirildi."); }
            if (c.Equals("Gizle")) { giris.veri.gizlimi3 = 1; giris.veridegis5("b3kurum", 1); MessageBox.Show(giris.veri.bagiskurumu3 + " Gizlendi."); } else if (c.Equals("Goster")) { giris.veri.gizlimi3 = 0; giris.veridegis5("b3kurum", 0); MessageBox.Show(giris.veri.bagiskurumu3 + " Aktif Hale Getirildi."); }
        }
    }
}
