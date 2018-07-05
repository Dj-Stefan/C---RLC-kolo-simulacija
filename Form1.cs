using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using rlc;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double R, L, C, f, Um, pfu, Im,pfi,Ul, Uc,Ur;

        private void button1_Click(object sender, EventArgs e)
        {
          
            textBox2.Enabled =textBox1.Enabled =textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled=textBox8.Enabled =false;
            R = Convert.ToDouble(textBox1.Text);
            L = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);
            f = Convert.ToDouble(textBox4.Text);
            Um = Convert.ToDouble(textBox5.Text);
            pfu = Convert.ToDouble(textBox6.Text);           

            textBox7.Text =(redno.propracun(R, L, C, f, Um, pfu, Im)).ToString("0.00");
            textBox8.Text =(redno.propracun1(R, L, C, f, Um, pfu, pfi)).ToString("0.00");
            label17.Text = (redno.propracun2(R, L, C, f, Convert.ToDouble(textBox7.Text) ,Ul )).ToString("0.00");
            label18.Text = (redno.propracun3(R, L, C, f, Convert.ToDouble(textBox7.Text), Uc)).ToString("0.00");
            label19.Text = (redno.propracun4(f)).ToString("ω=" + "0.00" + " rad/s");
            label20.Text = (redno.propracun5(R, Convert.ToDouble(textBox7.Text), Ur)).ToString("0.00");
            label21.Text = pfu.ToString("0.00");
            label22.Text = (pfu+90).ToString("0.00");
            label24.Text = (pfu - 90).ToString("0.00");
            label23.Text = "pfUc=";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x0 = pictureBox1.Width / 2;
            int y0 = pictureBox1.Height / 2;
            redno.crtaj(x0,y0,pictureBox1.CreateGraphics());          
                      
        }       

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = textBox8.Enabled = true;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = label17.Text = label18.Text = label24.Text=label19.Text= label20.Text=label21.Text=label22.Text= "";
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x0 = pictureBox1.Width / 2;
            int y0 = pictureBox1.Height / 2;
            redno.crtaju(x0, y0, pictureBox1.CreateGraphics(), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            redno.crtaji(x0, y0, pictureBox1.CreateGraphics(), Convert.ToDouble(label20.Text), Convert.ToDouble(label21.Text));
            redno.crtaju(x0, y0, pictureBox1.CreateGraphics(), Convert.ToDouble(label17.Text), Convert.ToDouble(label22.Text));
            redno.crtaju(x0, y0, pictureBox1.CreateGraphics(), Convert.ToDouble(label18.Text), Convert.ToDouble(label24.Text));
            redno.crtaju(x0, y0, pictureBox1.CreateGraphics(), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text));
           
        }
    }
}
