namespace CarsonGamesGeos2.MainForms.Misc_Forms.control
{
    partial class control
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.appearance = new System.Windows.Forms.TabPage();
            this.backcolorbtn = new System.Windows.Forms.Button();
            this.backpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.versionstring = new System.Windows.Forms.Label();
            this.titlebar1 = new CarsonGamesGeos.geos.UserControls.UI.Titlebar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.appearance.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "appearance",
            "about"});
            this.listBox1.Location = new System.Drawing.Point(0, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 304);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.appearance);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(161, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 313);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // appearance
            // 
            this.appearance.Controls.Add(this.backcolorbtn);
            this.appearance.Controls.Add(this.backpanel);
            this.appearance.Controls.Add(this.label2);
            this.appearance.Location = new System.Drawing.Point(4, 22);
            this.appearance.Name = "appearance";
            this.appearance.Padding = new System.Windows.Forms.Padding(3);
            this.appearance.Size = new System.Drawing.Size(308, 287);
            this.appearance.TabIndex = 0;
            this.appearance.Text = "1";
            this.appearance.UseVisualStyleBackColor = true;
            this.appearance.Click += new System.EventHandler(this.tabPage1_Click);
            this.appearance.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // backcolorbtn
            // 
            this.backcolorbtn.Location = new System.Drawing.Point(205, 7);
            this.backcolorbtn.Name = "backcolorbtn";
            this.backcolorbtn.Size = new System.Drawing.Size(75, 23);
            this.backcolorbtn.TabIndex = 4;
            this.backcolorbtn.Text = "Change";
            this.backcolorbtn.UseVisualStyleBackColor = true;
            this.backcolorbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backpanel
            // 
            this.backpanel.Location = new System.Drawing.Point(162, 11);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(23, 16);
            this.backpanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current background color";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(308, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.versionstring);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // versionstring
            // 
            this.versionstring.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.versionstring.Location = new System.Drawing.Point(3, 133);
            this.versionstring.Name = "versionstring";
            this.versionstring.Size = new System.Drawing.Size(251, 13);
            this.versionstring.TabIndex = 2;
            this.versionstring.Text = "aa";
            this.versionstring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlebar1
            // 
            this.titlebar1.Location = new System.Drawing.Point(0, 0);
            this.titlebar1.Name = "titlebar1";
            this.titlebar1.Size = new System.Drawing.Size(490, 32);
            this.titlebar1.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(312, 284);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 74);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 316);
            this.Controls.Add(this.titlebar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "control";
            this.Text = "control";
            this.tabControl1.ResumeLayout(false);
            this.appearance.ResumeLayout(false);
            this.appearance.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage appearance;
        private System.Windows.Forms.TabPage tabPage2;
        private CarsonGamesGeos.geos.UserControls.UI.Titlebar titlebar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label versionstring;
        private System.Windows.Forms.Button backcolorbtn;
        private System.Windows.Forms.Panel backpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}