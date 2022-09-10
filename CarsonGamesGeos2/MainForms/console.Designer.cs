namespace CarsonGamesGeos2.MainForms
{
    partial class console
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
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.titlebar1 = new CarsonGamesGeos.geos.UserControls.UI.Titlebar();
            this.SuspendLayout();
            // 
            // consoleControl1
            // 
            this.consoleControl1.IsInputEnabled = true;
            this.consoleControl1.Location = new System.Drawing.Point(0, 27);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = false;
            this.consoleControl1.Size = new System.Drawing.Size(801, 424);
            this.consoleControl1.TabIndex = 2;
            this.consoleControl1.Load += new System.EventHandler(this.consoleControl1_Load_2);
            // 
            // titlebar1
            // 
            this.titlebar1.Location = new System.Drawing.Point(-1, -1);
            this.titlebar1.Name = "titlebar1";
            this.titlebar1.Size = new System.Drawing.Size(805, 31);
            this.titlebar1.TabIndex = 3;
            // 
            // console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleControl1);
            this.Controls.Add(this.titlebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "console";
            this.Text = " console";
            this.Load += new System.EventHandler(this.console_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ConsoleControl.ConsoleControl consoleControl1;
        private CarsonGamesGeos.geos.UserControls.UI.Titlebar titlebar1;
    }
}