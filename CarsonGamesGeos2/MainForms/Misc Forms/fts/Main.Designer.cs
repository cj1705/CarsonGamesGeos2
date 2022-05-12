namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts
{
    partial class Main
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatProgressBar1 = new FlatUI.FlatProgressBar();
            this.formpanel = new System.Windows.Forms.Panel();
            this.formSkin1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.formpanel);
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(800, 450);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Carson Games Geos 2 Setup";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.flatProgressBar1);
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 0;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(3, 7);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(51, 13);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "Progress";
            // 
            // flatProgressBar1
            // 
            this.flatProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.flatProgressBar1.Location = new System.Drawing.Point(60, -18);
            this.flatProgressBar1.Maximum = 100;
            this.flatProgressBar1.Name = "flatProgressBar1";
            this.flatProgressBar1.Pattern = false;
            this.flatProgressBar1.PercentSign = true;
            this.flatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatProgressBar1.ShowBalloon = false;
            this.flatProgressBar1.Size = new System.Drawing.Size(252, 42);
            this.flatProgressBar1.TabIndex = 1;
            this.flatProgressBar1.Text = "flatProgressBar1";
            this.flatProgressBar1.Value = 40;
            // 
            // formpanel
            // 
            this.formpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formpanel.BackColor = System.Drawing.Color.Transparent;
            this.formpanel.Location = new System.Drawing.Point(0, 51);
            this.formpanel.Name = "formpanel";
            this.formpanel.Size = new System.Drawing.Size(800, 377);
            this.formpanel.TabIndex = 1;
            this.formpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formpanel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTS";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Load);
            this.formSkin1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatProgressBar flatProgressBar1;
        public System.Windows.Forms.Panel formpanel;
    }
}