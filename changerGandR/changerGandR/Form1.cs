using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changerGandR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.ClientSize = new Size(255, 255);
        }
        int f = 0;
        void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                f = 1;
            }
            else
            {
                this.BackColor = Color.FromArgb(0, 0, 0);
                this.Text = "x=" + 0 + "Y=" + 0;
            }
        }
        void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            f = 0;
        }
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (f == 1)
            {
                this.Text = "x=" + e.X + "Y=" + e.Y;
                if (e.X>0 && e.X<255&& e.Y > 0 && e.Y < 255)
                {
                    this.BackColor = Color.FromArgb(e.X, e.Y, 0);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
