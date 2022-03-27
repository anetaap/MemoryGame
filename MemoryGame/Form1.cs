using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private Start StartGame;
        private Configuration _configuration;
        private Settings player;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("You have to enter your nick!");
            }
            else
            {
                player = new Settings(name);

                StartGame = new Start(player, this);
            
                StartGame.Show();
                Hide();
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _configuration  = new Configuration(player, this);
            
            _configuration.Show();
            Hide();
        }
    }
}