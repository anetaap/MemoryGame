using System.ComponentModel;

namespace MemoryGame
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelMovements = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_ = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label2.Location = new System.Drawing.Point(138, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(943, 85);
            this.label2.TabIndex = 4;
            this.label2.Text = "MEMORY GAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1205, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelScore.Location = new System.Drawing.Point(0, 525);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(179, 49);
            this.labelScore.TabIndex = 6;
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTimer.Location = new System.Drawing.Point(510, 525);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(178, 49);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMovements
            // 
            this.labelMovements.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovements.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelMovements.Location = new System.Drawing.Point(1026, 525);
            this.labelMovements.Name = "labelMovements";
            this.labelMovements.Size = new System.Drawing.Size(179, 49);
            this.labelMovements.TabIndex = 8;
            this.labelMovements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_
            // 
            this.start_.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.start_.Location = new System.Drawing.Point(0, 448);
            this.start_.Name = "start_";
            this.start_.Size = new System.Drawing.Size(1205, 59);
            this.start_.TabIndex = 9;
            this.start_.Text = "Start";
            this.start_.UseVisualStyleBackColor = true;
            this.start_.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.18939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.81061F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1205, 325);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1205, 675);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.start_);
            this.Controls.Add(this.labelMovements);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Button start_;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Label labelTimer;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMovements;

        private System.Windows.Forms.Label labelScore;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;

        #endregion
    }
}