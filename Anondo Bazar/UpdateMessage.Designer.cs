
namespace Anondo_Bazar
{
    partial class UpdateMessage
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
            this.messageClosePictureBox = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.messageLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.messageClosePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageClosePictureBox
            // 
            this.messageClosePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messageClosePictureBox.Image = global::Anondo_Bazar.Properties.Resources.cancel;
            this.messageClosePictureBox.Location = new System.Drawing.Point(571, 4);
            this.messageClosePictureBox.Name = "messageClosePictureBox";
            this.messageClosePictureBox.Size = new System.Drawing.Size(40, 33);
            this.messageClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageClosePictureBox.TabIndex = 4;
            this.messageClosePictureBox.TabStop = false;
            this.messageClosePictureBox.Click += new System.EventHandler(this.messageClosePictureBox_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.messageLabel.Location = new System.Drawing.Point(16, 52);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(440, 39);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Data Updated Successfully...";
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.DarkGreen;
            this.messagePanel.Location = new System.Drawing.Point(-2, 220);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(10, 16);
            this.messagePanel.TabIndex = 5;
            // 
            // messageTimer
            // 
            this.messageTimer.Enabled = true;
            this.messageTimer.Interval = 25;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // messageLabelTimer
            // 
            this.messageLabelTimer.Enabled = true;
            this.messageLabelTimer.Interval = 50;
            this.messageLabelTimer.Tick += new System.EventHandler(this.messageLabelTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.messageLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(75, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 141);
            this.panel1.TabIndex = 6;
            // 
            // UpdateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(616, 236);
            this.Controls.Add(this.messageClosePictureBox);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageClosePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox messageClosePictureBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Timer messageLabelTimer;
        private System.Windows.Forms.Panel panel1;
    }
}