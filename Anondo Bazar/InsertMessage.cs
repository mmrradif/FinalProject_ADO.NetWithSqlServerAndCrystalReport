using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anondo_Bazar
{
    public partial class InsertMessage : Form
    {

        // --------------------------------------- ANIMATED TEXT -- START -->>
        private string text;
        private int len = 0;

        public InsertMessage()
        {
            InitializeComponent();
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            messagePanel.Width += 5;
            if (messagePanel.Width > 616)
            {
                messageTimer.Stop();
                this.Hide();
            }
        }

        private void messageClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            // --------------------------------------- ANIMATED TEXT -- START -->>
            text = messageLabel.Text;
            messageLabel.Text = "";

            //-- Call welcomeTimer
            messageLabelTimer.Start();

            // --------------------------------------- ANIMATED TEXT -- END -->>
        }

        private void messageLabelTimer_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                messageLabel.Text = messageLabel.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                messageLabelTimer.Stop();
            }
        }
    }
}
