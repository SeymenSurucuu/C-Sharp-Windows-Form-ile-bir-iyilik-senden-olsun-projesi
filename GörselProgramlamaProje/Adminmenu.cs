using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static gorselprogramlamaproje.giris;

namespace gorselprogramlamaproje
{
    public partial class Adminmenu : Form
    {
        public Adminmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adminmenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bagiskurumlariduzenle adminmenu = new bagiskurumlariduzenle();
            adminmenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            anamenu anamenu = new anamenu();
            anamenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            askidafaturayonetim askidafaturayonetim = new askidafaturayonetim();
            askidafaturayonetim.Show();
            this.Hide();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminduzenle adminduzenle = new Adminduzenle();
            adminduzenle.Show();
            this.Hide();    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            arayuzduzenle arayuzduzenle = new arayuzduzenle();
            arayuzduzenle.Show();
            this.Hide();
        }
    }
}
