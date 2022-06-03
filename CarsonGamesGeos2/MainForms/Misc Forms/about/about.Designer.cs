namespace CarsonGamesGeos2.MainForms.Misc_Forms.about
{
    partial class about
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
            this.titlebar1 = new CarsonGamesGeos.geos.UserControls.UI.Titlebar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versionstring = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar1
            // 
            this.titlebar1.Location = new System.Drawing.Point(0, 0);
            this.titlebar1.Name = "titlebar1";
            this.titlebar1.Size = new System.Drawing.Size(821, 32);
            this.titlebar1.TabIndex = 0;
            this.titlebar1.Load += new System.EventHandler(this.titlebar1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarsonGamesGeos2.MainResources.CGGeosLogo2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 126);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // versionstring
            // 
            this.versionstring.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.versionstring.Location = new System.Drawing.Point(3, 156);
            this.versionstring.Name = "versionstring";
            this.versionstring.Size = new System.Drawing.Size(252, 13);
            this.versionstring.TabIndex = 2;
            this.versionstring.Text = "aa";
            this.versionstring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionstring.Click += new System.EventHandler(this.versionstring_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.versionstring);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(306, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titlebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "about";
            this.Text = "about";
            this.Load += new System.EventHandler(this.about_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CarsonGamesGeos.geos.UserControls.UI.Titlebar titlebar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label versionstring;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}