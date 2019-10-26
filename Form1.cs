using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        bool Drow;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drow = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Drow = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics  graf = pictureBox1.CreateGraphics();
            if (Drow == true)
            {
                graf.FillEllipse(Brushes.Violet, e.X, e.Y, 3, 3); // толщина кисти
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Рисование кистью"; button1.Text = "Очистить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics  Графика = pictureBox1.CreateGraphics();
            Графика.Clear(SystemColors.Window);
        }
    }
}
