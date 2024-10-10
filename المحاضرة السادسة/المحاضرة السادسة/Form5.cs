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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            //timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int s = -1, m = 0, h = 0, y = 0,d=0;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if(s>9)
                label1.Text=s.ToString();
            else
                label1.Text="0"+s.ToString();
            if(s>=59)
            {
                s = 0;
                timer1.Interval = 10;
                m++;
                if(m>9)
                    label2.Text=m.ToString();
                else
                    label2.Text="0"+m.ToString();
            }
            if(m>=59)
            {
                m = 0;
                s = 0;
                h++;
                if(h>9)
                label3.Text=h.ToString();
                else
                    label3.Text="0"+h.ToString();
            }
            if(h>=24)
            {
                m = 0;
                s = 0;
                h = 0;
                d++;
                label6.Text = d.ToString();

            }
        }
    }
}
