using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pixelImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] pixels = new int[50, 50];

        public void printpixelstotextbox()
        {
            textBox1.Text = "";
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    textBox1.Text += pixels[j, i] + "";
                }
                 textBox1.Text += "\r\n";
            }
        }
        public void addtoform()
        { 
            int k = Controls.Count-1;
            for(int i = 0 ; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    k++;
                    Controls.Add(new pixelGiant());
                    Controls[k].Left = (j * 10) + 50;    // j = (((j*10)+50) - 50)/10 
                    Controls[k].Top = (i * 10) + 50;     // i = (((i*10)+50) - 50)/10 
                    Controls[k].Show();
                    
                    
                   
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Start Draw";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtoform();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.printpixelstotextbox();
        }
    }
}
