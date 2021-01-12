using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_1_建造小人
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black);
            Graphics gThin = pictureBox1.CreateGraphics();
            gThin.DrawEllipse(p, 50, 20, 30, 30); //头
            gThin.DrawRectangle(p, 60, 50, 10, 50); //身体
            gThin.DrawLine(p, 60, 50, 40, 100); //左手
            gThin.DrawLine(p, 70, 50, 90, 100); //右手
            gThin.DrawLine(p, 60, 100, 45, 150);  //左脚
            gThin.DrawLine(p, 70, 100, 85, 150);  //右脚
        }
    }
}
