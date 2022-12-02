using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pixelImageEditor
{
    public partial class pixelGiant : UserControl
    {

        public pixelGiant()
        {
            InitializeComponent();
        }

        Form1 f;
        public int val = 0;
        public int x;
        public int y;

        public void setx(int px)
        { x = px; }
        public void sety(int py)
        { y = py; }

        private void pixelGiant_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }

        private void pixelGiant_MouseClick(object sender, MouseEventArgs e)
        {
            if (val == 0)
            {
                val = 1;
                BackColor = Color.Black;
                f.pixels[(this.Left - 50) / 10, (this.Top - 50) / 10] = 1;
            }
            else
            {
                val = 0;
                BackColor = Color.White;
                f.pixels[(this.Left - 50) / 10, (this.Top - 50) / 10] = 0;
            }
            //f.printpixelstotextbox();

        }

    }
}
