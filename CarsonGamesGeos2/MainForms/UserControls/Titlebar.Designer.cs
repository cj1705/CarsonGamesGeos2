
namespace CarsonGamesGeos.geos.UserControls.UI
{
    partial class Titlebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.minbutton = new System.Windows.Forms.Button();
            this.xbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Controls.Add(this.xbutton);
            this.panel1.Controls.Add(this.minbutton);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 33);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(15, 7);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(68, 19);
            this.flatLabel1.TabIndex = 19;
            this.flatLabel1.Text = "flatLabel1";
            this.flatLabel1.Click += new System.EventHandler(this.flatLabel1_Click);
            // 
            // minbutton
            // 
            this.minbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minbutton.BackColor = System.Drawing.Color.Black;
            this.minbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minbutton.CausesValidation = false;
            this.minbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.minbutton.Location = new System.Drawing.Point(673, 9);
            this.minbutton.Name = "minbutton";
            this.minbutton.Size = new System.Drawing.Size(33, 18);
            this.minbutton.TabIndex = 7;
            this.minbutton.Text = "-";
            this.minbutton.UseVisualStyleBackColor = false;
            this.minbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xbutton
            // 
            this.xbutton.BackgroundImage = global::CarsonGamesGeos2.MainResources.Geos_X;
            this.xbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xbutton.Location = new System.Drawing.Point(699, 3);
            this.xbutton.Name = "xbutton";
            this.xbutton.Size = new System.Drawing.Size(29, 28);
            this.xbutton.TabIndex = 18;
            this.xbutton.UseVisualStyleBackColor = true;
            this.xbutton.Click += new System.EventHandler(this.xbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Titlebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Titlebar";
            this.Size = new System.Drawing.Size(732, 32);
            this.Load += new System.EventHandler(this.Titlebar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minbutton;
        public System.Windows.Forms.Button xbutton;
        private FlatUI.FlatLabel flatLabel1;
    }
}
