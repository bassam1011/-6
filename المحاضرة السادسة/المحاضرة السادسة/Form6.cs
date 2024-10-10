using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_السادسة
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"c#.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 9)
            {
                pictureBox1.Image = Image.FromFile(@i.ToString() + ".png");
                BackgroundImage = Image.FromFile(@i.ToString() + ".png");
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromFile(@i.ToString() + ".png");
                BackgroundImage = Image.FromFile(@i.ToString() + ".png");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 0)
                i = 9;
            pictureBox1.Image = Image.FromFile(@i.ToString() + ".png");
            BackgroundImage = Image.FromFile(i.ToString() + ".png");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 9)
            {
                pictureBox1.Image = Image.FromFile(@i.ToString() + ".png");
                BackgroundImage = Image.FromFile(@i.ToString() + ".png");
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromFile(@i.ToString() + ".png");
                BackgroundImage = Image.FromFile(@i.ToString() + ".png");
            }
        }
    }
}
