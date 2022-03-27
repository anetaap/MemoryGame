﻿using System;
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
        private int _score;
        private int _time;
        private int _clickTime;
        private int _movements = 0;
        private List<Image> _images;
        private Dictionary<String, Button> _visible;
        private int _currentTime;

        public Start(Settings settings, Form1 start)
        {
            InitializeComponent();
            
            _settings = settings;
            _start = start;
            _images = new List<Image>();
            
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
            Random random_ = new Random();
            int len = list.Count;
            while (len > 1)
            {
                len--;
                int rand = random_.Next(len + 1);
                (list[rand], list[len]) = (list[len], list[rand]);
            }
        }
        
        private List<string> Shuffle()
        {
            List<string> pNames = new List<string>();
            string pathStatic = @"C:\Users\aneta_p\Documents\Studia\Semestr_4\PZ2\MemoryGame\MemoryGame\Stitch\";

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
            labelScore.Text = $"Score: {_score}";
            labelTimer.Text = $"Time: {_time}";
            _time++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            tableLayoutPanel1.Controls.Clear();
            
            timer2.Enabled = true;
            timer3.Enabled = true;
            _score = 0;
            _time = 0;
            _visible = new Dictionary<String, Button>();

            foreach (var path in Shuffle())
            {
                var imgControl = new Button();
                var imageIcon = Image.FromFile(path);

                imgControl.Click += (o, args) =>
                {
                    if (imgControl.Image == null && _visible.Count < 2)
                    {
                        imgControl.Image = _images[tableLayoutPanel1.Controls.IndexOf(imgControl)];
                        imgControl.BackColor = Color.SeaShell;
                        if(_visible.ContainsKey(path))
                        {
                            _score++;
                            imgControl.BackColor = Color.SeaShell;
                            _visible[path].BackColor = Color.SeaShell;
                            imgControl.Enabled = false;
                            _visible[path].Enabled = false;
                            _visible.Remove(path);
                        }
                        else
                        {
                            _visible[path] = imgControl;   
                        }

                    } else
                    {
                        imgControl.Image = null;
                        imgControl.BackColor = Color.LightSlateGray;
                        _visible.Remove(path);
                    }

                    _movements++;
                    labelMovements.Text = _movements + " Moves";
                };
                

                imageIcon = new Bitmap(imageIcon, new Size(imageIcon.Size.Width / 2, imageIcon.Size.Height / 2));

                imgControl.Size = imageIcon.Size;

                _images.Add(imageIcon);
                tableLayoutPanel1.Controls.Add(imgControl);

                tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1].Anchor =
                    AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            }

            tableLayoutPanel1.Show();

            timer1.Enabled = true;
        }

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            _clickTime++;
        }

        private void timer3_Elapsed(object sender, ElapsedEventArgs e)
        {
            _currentTime++;
        }
    }
}