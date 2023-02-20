
namespace Anondo_Bazar
{
    partial class splashScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.TopToBottomLeftPanel = new System.Windows.Forms.Panel();
            this.TopToBottomLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftToRightBottomTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftToRightBottomPanel = new System.Windows.Forms.Panel();
            this.TopToBottomRightPanel = new System.Windows.Forms.Panel();
            this.TopToBottomRightTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftToRightTopPanel = new System.Windows.Forms.Panel();
            this.LeftToRightTopTimer = new System.Windows.Forms.Timer(this.components);
            this.welcomeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.tagTitleTimer = new System.Windows.Forms.Timer(this.components);
            this.GoTimer = new System.Windows.Forms.Timer(this.components);
            this.GoPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblwelcome.Location = new System.Drawing.Point(192, 234);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(414, 39);
            this.lblwelcome.TabIndex = 11;
            this.lblwelcome.Text = "Welcome To Anondo Bazar";
            // 
            // TopToBottomLeftPanel
            // 
            this.TopToBottomLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.TopToBottomLeftPanel.Location = new System.Drawing.Point(38, -1);
            this.TopToBottomLeftPanel.Name = "TopToBottomLeftPanel";
            this.TopToBottomLeftPanel.Size = new System.Drawing.Size(19, 17);
            this.TopToBottomLeftPanel.TabIndex = 13;
            // 
            // TopToBottomLeftTimer
            // 
            this.TopToBottomLeftTimer.Enabled = true;
            this.TopToBottomLeftTimer.Interval = 15;
            this.TopToBottomLeftTimer.Tick += new System.EventHandler(this.TopToBottomLeftTimer_Tick);
            // 
            // LeftToRightBottomTimer
            // 
            this.LeftToRightBottomTimer.Enabled = true;
            this.LeftToRightBottomTimer.Interval = 15;
            this.LeftToRightBottomTimer.Tick += new System.EventHandler(this.LeftToRightBottomTimer_Tick);
            // 
            // LeftToRightBottomPanel
            // 
            this.LeftToRightBottomPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LeftToRightBottomPanel.Location = new System.Drawing.Point(0, 444);
            this.LeftToRightBottomPanel.Name = "LeftToRightBottomPanel";
            this.LeftToRightBottomPanel.Size = new System.Drawing.Size(17, 19);
            this.LeftToRightBottomPanel.TabIndex = 14;
            // 
            // TopToBottomRightPanel
            // 
            this.TopToBottomRightPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.TopToBottomRightPanel.Location = new System.Drawing.Point(730, -1);
            this.TopToBottomRightPanel.Name = "TopToBottomRightPanel";
            this.TopToBottomRightPanel.Size = new System.Drawing.Size(19, 17);
            this.TopToBottomRightPanel.TabIndex = 15;
            this.TopToBottomRightPanel.Visible = false;
            // 
            // TopToBottomRightTimer
            // 
            this.TopToBottomRightTimer.Interval = 15;
            this.TopToBottomRightTimer.Tick += new System.EventHandler(this.TopToBottomRightTimer_Tick);
            // 
            // LeftToRightTopPanel
            // 
            this.LeftToRightTopPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LeftToRightTopPanel.Location = new System.Drawing.Point(-1, 35);
            this.LeftToRightTopPanel.Name = "LeftToRightTopPanel";
            this.LeftToRightTopPanel.Size = new System.Drawing.Size(17, 19);
            this.LeftToRightTopPanel.TabIndex = 16;
            this.LeftToRightTopPanel.Visible = false;
            // 
            // LeftToRightTopTimer
            // 
            this.LeftToRightTopTimer.Interval = 15;
            this.LeftToRightTopTimer.Tick += new System.EventHandler(this.LeftToRightTopTimer_Tick);
            // 
            // welcomeTimer
            // 
            this.welcomeTimer.Interval = 200;
            this.welcomeTimer.Tick += new System.EventHandler(this.welcomeTimer_Tick);
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTagTitle.Location = new System.Drawing.Point(250, 287);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(293, 23);
            this.lblTagTitle.TabIndex = 17;
            this.lblTagTitle.Text = "Happy Shop, Happy Food, Happy Life";
            this.lblTagTitle.Visible = false;
            // 
            // tagTitleTimer
            // 
            this.tagTitleTimer.Interval = 50;
            this.tagTitleTimer.Tick += new System.EventHandler(this.tagTitleTimer_Tick);
            // 
            // GoTimer
            // 
            this.GoTimer.Interval = 80;
            this.GoTimer.Tick += new System.EventHandler(this.Go_Tick);
            // 
            // GoPanel
            // 
            this.GoPanel.BackColor = System.Drawing.Color.DimGray;
            this.GoPanel.Location = new System.Drawing.Point(199, 355);
            this.GoPanel.Name = "GoPanel";
            this.GoPanel.Size = new System.Drawing.Size(54, 24);
            this.GoPanel.TabIndex = 18;
            this.GoPanel.Visible = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Anondo_Bazar.Properties.Resources.anondoBazar;
            this.LogoPictureBox.Location = new System.Drawing.Point(306, 110);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(147, 107);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 12;
            this.LogoPictureBox.TabStop = false;
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.GoPanel);
            this.Controls.Add(this.lblTagTitle);
            this.Controls.Add(this.LeftToRightTopPanel);
            this.Controls.Add(this.TopToBottomRightPanel);
            this.Controls.Add(this.LeftToRightBottomPanel);
            this.Controls.Add(this.TopToBottomLeftPanel);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      Anondo Bazar";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel TopToBottomLeftPanel;
        private System.Windows.Forms.Timer TopToBottomLeftTimer;
        private System.Windows.Forms.Timer LeftToRightBottomTimer;
        private System.Windows.Forms.Panel LeftToRightBottomPanel;
        private System.Windows.Forms.Panel TopToBottomRightPanel;
        private System.Windows.Forms.Timer TopToBottomRightTimer;
        private System.Windows.Forms.Panel LeftToRightTopPanel;
        private System.Windows.Forms.Timer LeftToRightTopTimer;
        private System.Windows.Forms.Timer welcomeTimer;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.Timer tagTitleTimer;
        private System.Windows.Forms.Timer GoTimer;
        private System.Windows.Forms.Panel GoPanel;
    }
}

