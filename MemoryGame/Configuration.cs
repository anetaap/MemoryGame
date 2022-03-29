using System;
using System.IO;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Configuration : Form
    {
        private Form1 _start;
        private Settings _settings;
        public Configuration(Settings settings, Form1 start)
        {
            InitializeComponent();
            _settings = settings;
            _start = start;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            _start.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _settings.Size1 = 6;
            _settings.Size2 = 8;
            _settings.Scaler = 3;
            _settings.Jsonpath = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores1.json";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _settings.Size1 = 8;
            _settings.Size2 = 9;
            _settings.Scaler = 3;
            _settings.Jsonpath = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores2.json";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _settings.Size1 = 8;
            _settings.Size2 = 10;
            _settings.Scaler = 3;
            _settings.Jsonpath = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores3.json";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _settings.Size1 = 9;
            _settings.Size2 = 10;
            _settings.Scaler = 4;
            _settings.Jsonpath = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores4.json";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _settings.Size1 = 10;
            _settings.Size2 = 12;
            _settings.Scaler = 4;
            _settings.Jsonpath = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\scores5.json";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _settings.Time = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _settings.Time = 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _settings.Time = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _settings.Time = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _settings.Time = 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _settings.Stitch();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _settings.Disney();
        }
    }
}