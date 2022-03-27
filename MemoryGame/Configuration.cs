using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Configuration : Form
    {
        private Form1 start_;
        private Settings settings;
        public Configuration(Settings _settings, Form1 start)
        {
            InitializeComponent();
            settings = _settings;
            start_ = start;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            start_.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings.Size1 = 6;
            settings.Size2 = 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings.Size1 = 7;
            settings.Size2 = 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settings.Size1 = 8;
            settings.Size2 = 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            settings.Size1 = 9;
            settings.Size2 = 11;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            settings.Size1 = 10;
            settings.Size2 = 12;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            settings.Time = 20;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            settings.Time = 30;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            settings.Time = 40;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            settings.Time = 50;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            settings.Time = 60;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            settings.Stitch();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            settings.Disney();
        }
    }
}