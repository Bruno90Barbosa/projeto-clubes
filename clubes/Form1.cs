using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbLogoClube.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Real_Madrid.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Manchester_United_FC_logo.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\FC_Bayern_München_logo_(2017).svg.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\barcelona-4096.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Liverpool_FC.svg.png");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Logo_of_AC_Milan.svg.png");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Ajax_Amsterdam.svg.png");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Juventus_FC_2017_logo.png");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\logo-porto-2048.png");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Borussia_Dortmund_logo.svg.png");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Inter_Milano_2021_logo_with_2_stars.svg.png");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pbLogoClube.Image = Image.FromFile("imagens\\Arsenal_FC.svg.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
