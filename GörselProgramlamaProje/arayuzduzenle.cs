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
    public partial class arayuzduzenle : Form
    {
        public void Color(Color color)
        {
            button1.ForeColor = color;
        }
        public arayuzduzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            colorDialog2.ShowDialog();
            this.BackColor = colorDialog2.Color;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminmenu adminmenu = new Adminmenu();
            adminmenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            button1.BackColor = colorDialog2.Color;
            button2.BackColor = colorDialog2.Color;
            button3.BackColor = colorDialog2.Color;
            button4.BackColor = colorDialog2.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            button1.ForeColor = colorDialog2.Color;
            button2.ForeColor = colorDialog2.Color;
            button3.ForeColor = colorDialog2.Color;
            button4.ForeColor = colorDialog2.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
       
        }
    }
}
