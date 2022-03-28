using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Start : Form
    {
        private Settings _settings;
        private Form1 _start;
        private Statistics _statistics;
        
        private int _score;
        private int _time;
        private int _clickTime;
        private int _movements;
        private int _currentTime;
        private int _pause;
        
        private readonly List<Image> _images;
        private readonly List<Button> _buttons;
        private Dictionary<String, Button> _visible;
        private Dictionary<Button, int> _timers;

        public Start(Settings settings, Form1 start)
        {
            _settings = settings;
            _start = start;
            
            _images = new List<Image>();
            _buttons = new List<Button>();

            InitializeComponent();
            InitWall();
        }

        private void InitWall()
        {
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            tableLayoutPanel1.ColumnCount=_settings.Size2;
            tableLayoutPanel1.RowCount=_settings.Size1;

            float rows=100/(float)_settings.Size1;
            float cols=100/(float)_settings.Size2;

            for(int i=0; i<_settings.Size1; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,rows));
            }

            for(int i=0; i<_settings.Size2; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,cols));
            }

            tableLayoutPanel1.Visible=true;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        
        private void Shuffle(List<string> list)
        {
            Random random = new Random();
            int len = list.Count;
            while (len > 1)
            {
                len--;
                int rand = random.Next(len + 1);
                (list[rand], list[len]) = (list[len], list[rand]);
            }
        }
        
        private List<string> Shuffle()
        {
            List<string> pNames = new List<string>();
            string pathStatic = _settings.Path;

            Random random = new Random();
            int number;

            for (int i = 0; i < _settings.Size1 * _settings.Size2 / 2; i++)
            {
                do {
                    number = random.Next(1, 64);
                } while (pNames.Contains(pathStatic + "(" + number + ").png"));
                
                pNames.Add(pathStatic + "(" + number + ").png");
                pNames.Add(pNames[pNames.Count - 1]);
            }

            for (int i = 0; i < 10; i++)
            {
                Shuffle(pNames);
            }

            return pNames;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            _start.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelScore.Text = $@"Rigth: {_score}";
            labelTimer.Text = $@"Time: {_time}";
            _time++;
            TimeLimit();
        }

        /*private void SetButtons()
        {
            List<String> imgPath = Shuffle();
            foreach (string path in imgPath)
            {
                var imgControl = new Button();
                
                _buttons.Add(imgControl);
            }
        }*/

        private void ShowTime()
        {
            tableLayoutPanel1.Hide();
            tableLayoutPanel1.Controls.Clear();
            
            foreach (var button in _buttons)
            {
                button.PerformClick();
            }
            tableLayoutPanel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            _score = 0;
            _time = 0;
            _visible = new Dictionary<String, Button>();
            _timers = new Dictionary<Button, int>();

            List<String> imgPath = Shuffle();

            tableLayoutPanel1.Hide();
            tableLayoutPanel1.Controls.Clear();

            foreach (var path in imgPath)
            {
                var imgControl = new Button();
                var imageIcon = Image.FromFile(path);
                
                _buttons.Add(imgControl);

                imgControl.Click += (o, args) =>
                {
                    if (imgControl.Image == null && _visible.Count < 2)
                    {
                        imgControl.Image = _images[tableLayoutPanel1.Controls.IndexOf(imgControl)];
                        imgControl.BackColor = Color.SeaShell;

                        if (_visible.ContainsKey(path))
                        {
                            _score++;
                            imgControl.BackColor = Color.SeaShell;
                            _visible[path].BackColor = Color.SeaShell;
                            imgControl.Enabled = false;
                            _visible[path].Enabled = false;
                            _visible.Remove(path);
                            _timers.Remove(imgControl);
                        }
                        else
                        {
                            _visible[path] = imgControl;
                            _timers[imgControl] = _clickTime;
                        }

                    }
                    else
                    {
                        imgControl.Image = null;
                        imgControl.BackColor = Color.LightSlateGray;
                        _visible.Remove(path);
                        _timers.Remove(imgControl);
                    }

                    _movements++;
                    labelMovements.Text = _movements + @" Moves";
                    EndOfGame();

                };


                imageIcon = new Bitmap(imageIcon, new Size
                    (imageIcon.Size.Width / _settings.Scaler, imageIcon.Size.Height / _settings.Scaler));

                imgControl.Size = imageIcon.Size;

                _images.Add(imageIcon);
                tableLayoutPanel1.Controls.Add(imgControl);

                tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1].Anchor =
                    AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                
            }

            tableLayoutPanel1.Show();
        }

        private void TimeLimit()
        {
            foreach (KeyValuePair<String, Button> button in _visible)
            {
                if (_timers.ContainsKey(button.Value))
                {
                    if (_currentTime - _timers[button.Value] >= _settings.Time)
                    {
                        button.Value.Image = null;
                        button.Value.BackColor = Color.LightSlateGray;
                        _visible.Remove(button.Key);
                        _timers.Remove(button.Value);
                        break;
                    }
                }
            }
        }

        private void EndOfGame()
        {
            if (_score * 2 == _settings.Size1 * _settings.Size2)
            {
                timer1.Stop();
                MessageBox.Show(@"Congratulations");

                if (_settings.Scores.ContainsKey(_settings.Nick))
                {
                    if (_time * _movements < _settings.Scores[_settings.Nick])
                        _settings.Scores[_settings.Nick] = _time * _movements;
                }
                else
                {
                    _settings.Scores[_settings.Nick] = _time * _movements;   
                }
                _settings.ScoresToJson();
                _statistics = new Statistics(_start, _settings);
                _statistics.Show();
                
                Close();
            }
        }

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            _clickTime++;
        }

        private void timer3_Elapsed_1(object sender, ElapsedEventArgs e)
        {
            _currentTime++;
        }

        private void sToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _settings.Time += 2;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_settings.Time > 2)
            {
                _settings.Time -= 2;
            }
        }

        private void sToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _settings.Time += 3;
        }

        private void sToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_settings.Time > 3)
            {
                _settings.Time -= 3;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_pause == 1)
            {
                _pause = 0;
                start_.PerformClick();
            }
            else
            {
                _pause = 1;
            }
        }
    }
}