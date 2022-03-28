using System;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Statistics : Form
    {
        private Settings _settings;
        private Form1 _start;
        public Statistics(Form1 start, Settings settings)
        {
            InitializeComponent();

            _settings = settings;
            _start = start;
            
            ShowStats();
        }

        private void ShowStats()
        {
            var sortedDict = from entry 
                in _settings.Scores orderby entry.Value ascending select entry;
            
            foreach (var settingsScore in sortedDict)
            {
                String score = settingsScore.Key + " best score: " + settingsScore.Value;
                listBox1.Items.Add(score);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            _start.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _start.Show();
            Close();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}