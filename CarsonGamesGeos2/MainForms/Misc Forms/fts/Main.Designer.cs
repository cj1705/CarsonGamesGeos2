namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts
{
    partial class FTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new FlatUI.FlatLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formpanel = new System.Windows.Forms.Panel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatProgressBar1 = new FlatUI.FlatProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 33);
            this.title.TabIndex = 1;
            this.title.Text = "Carson Games Geos 2 Setup";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flatProgressBar1);
            this.panel2.Controls.Add(this.flatLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 15);
            this.panel2.TabIndex = 1;
            // 
            // formpanel
            // 
            this.formpanel.BackColor = System.Drawing.Color.Black;
            this.formpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formpanel.Location = new System.Drawing.Point(0, 33);
            this.formpanel.Name = "formpanel";
            this.formpanel.Size = new System.Drawing.Size(800, 402);
            this.formpanel.TabIndex = 2;
            this.formpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 1);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(51, 13);
            this.flatLabel1.TabIndex = 3;
            this.flatLabel1.Text = "Progress";
            this.flatLabel1.Click += new System.EventHandler(this.flatLabel1_Click);
            // 
            // flatProgressBar1
            // 
            this.flatProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.flatProgressBar1.Location = new System.Drawing.Point(100, -24);
            this.flatProgressBar1.Maximum = 100;
            this.flatProgressBar1.Name = "flatProgressBar1";
            this.flatProgressBar1.Pattern = true;
            this.flatProgressBar1.PercentSign = false;
            this.flatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatProgressBar1.ShowBalloon = true;
            this.flatProgressBar1.Size = new System.Drawing.Size(700, 42);
            this.flatProgressBar1.TabIndex = 4;
            this.flatProgressBar1.Text = "flatProgressBar1";
            this.flatProgressBar1.Value = 0;
            // 
            // FTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTS";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatLabel title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel formpanel;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatProgressBar flatProgressBar1;
    }
}