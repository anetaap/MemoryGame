using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private Start _startGame;
        private Configuration _configuration;
        private Settings _settings;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Settings settings)
        {
            _settings = settings;
        }

        private void Start()
        {
            String name = textBox1.Text;

            if (name.Length == 0)
            {
                MessageBox.Show(@"You have to enter your nick!");
            }
            else
            {
                _settings = new Settings(name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(_settings == null)
                Start();
            else
            {
                _startGame = new Start(_settings, this);
            
                _startGame.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_settings == null)
                Start();
            else
            {
                _configuration  = new Configuration(_settings, this);
            
                _configuration.Show();
                Hide();   
            }
        }
    }
}