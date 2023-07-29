using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaproje
{
    public partial class anamenu : Form
    {
        
        public anamenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
           
           
           
       
            label1.Text = "Merhaba, " + giris.veri.ad + " bakiyeniz: " + giris.veri.bakiyesi +"TL";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sifre_degistir git = new sifre_degistir();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bakiyeyukle git = new bakiyeyukle();
            git.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bagisyap git = new bagisyap();
            git.Show();
            this.Hide();
        }

        

        private void anamenu_Load(object sender, EventArgs e)
        {
          

            label1.Text = "Merhaba, " + giris.veri.ad + " bakiyeniz: " + giris.veri.bakiyesi + "TL";

            if (giris.veri.adminmi == 1) { } else { button10.Hide(); }


            label3.Text = "Askıdaki Fatura Miktarınız: " + giris.veri.fatura+"TL";
            if (giris.veri.cinsiyet == "erkek") { pictureBox2.Hide();  
            } else if (giris.veri.cinsiyet == "kadin") { pictureBox1.Hide(); }
        }

        


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            kadegistir git = new kadegistir();
            git.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bgoruntule git = new bgoruntule();
            git.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            askidafatura git = new askidafatura();
            git.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faturaiste git = new faturaiste();
            git.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Adminmenu adminmenu = new Adminmenu();
            adminmenu.Show();
            this.Hide();
        }
    }
}
