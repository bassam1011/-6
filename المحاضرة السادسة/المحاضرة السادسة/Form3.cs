using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_السادسة
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog op1 = new OpenFileDialog();

            
            op1.Filter = "Png and Jpj Images|*.png;*.jpg";

            if (op1.ShowDialog() == DialogResult.OK)
            {
                
                string filename = op1.FileName;
                Bitmap mybitmap = new Bitmap(filename);
                pictureBox1.Image = mybitmap;

               
                label1.Text =  filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
