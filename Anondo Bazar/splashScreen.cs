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
    public partial class splashScreen : Form
    {
        // --------------------------------------- ANIMATED TEXT -- START -->>
        private string text;
        private int len = 0;

        //-- START -- TAG TITLE
        private string tagTitle;
        private int tagLen = 0;

        //-- END -- TAG TITLE
        // --------------------------------------- ANIMATED TEXT -- END -->>

        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            // --------------------------------------- ANIMATED TEXT -- START -->>
            text = lblwelcome.Text;
            lblwelcome.Text = "";

            //-- Call welcomeTimer
            welcomeTimer.Start();


            //-- START -- TAG TITLE
            tagTitle = lblTagTitle.Text;
            lblTagTitle.Text = "";

            //-- END -- TAG TITLE
            // --------------------------------------- ANIMATED TEXT -- END -->>

        }


        //-------------------------------------------------------------- SPLASH SCREEN -- START -->>>
        //-- START TopToBottomLeftTimer For TopToBottomLeftPanel
        private void TopToBottomLeftTimer_Tick(object sender, EventArgs e)
        {
            TopToBottomLeftPanel.Height += 3;

            if (TopToBottomLeftPanel.Height > 500)
            {
                TopToBottomLeftTimer.Stop();

                //-- Call TopToBottomRightTimer
                TopToBottomRightPanel.Visible = true;
                TopToBottomRightTimer.Start();

                //-- Call tagTitleTimer
                tagTitleTimer.Start();
            }
        }

        //-- START LeftToRightBottomTimer For LeftToRightBottomPanel
        private void LeftToRightBottomTimer_Tick(object sender, EventArgs e)
        {
            LeftToRightBottomPanel.Width += 5;

            if (LeftToRightBottomPanel.Width > 785)
            {
                LeftToRightBottomTimer.Stop();

                //-- Call LeftToRightTopTimer
                LeftToRightTopPanel.Visible = true;
                LeftToRightTopTimer.Start();

                //-- SHOW TAG TITLE
                lblTagTitle.Visible = true;
            }
        }

        //-- START TopToBottomRightTimer For TopToBottomRightPanel
        private void TopToBottomRightTimer_Tick(object sender, EventArgs e)
        {
            TopToBottomRightPanel.Height += 3;

            if (TopToBottomRightPanel.Height > 500)
            {
                TopToBottomRightTimer.Stop();
            }
        }

        //-- LeftToRightTopTimer For LeftToRightTopPanel
        private void LeftToRightTopTimer_Tick(object sender, EventArgs e)
        {
            LeftToRightTopPanel.Width += 5;

            if (LeftToRightTopPanel.Width > 784)
            {
                LeftToRightTopTimer.Stop();

                //-- Call GoTimer
                GoTimer.Start();
            }
        }
        //-------------------------------------------------------------- SPLASH SCREEN -- END -->>>


        // --------------------------------------- ANIMATED TEXT -- START -->>
        // -- welcomeTimer For lblwelcome
        private void welcomeTimer_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lblwelcome.Text = lblwelcome.Text + text.ElementAt(len);
                len++;             
            }
            else
            {
                welcomeTimer.Stop();
            }
        }

        //-- tagTitleTimer For lblTagTitle
        private void tagTitleTimer_Tick(object sender, EventArgs e)
        {
            if (tagLen < tagTitle.Length)
            {
                lblTagTitle.Text = lblTagTitle.Text + tagTitle.ElementAt(tagLen);
                tagLen++;
            }
            else
            {
                tagTitleTimer.Stop();
            }
        }
        // --------------------------------------- ANIMATED TEXT -- END -->>

        // --------------------------------------- GoTimer For Next Page -- START -->>>
        private void Go_Tick(object sender, EventArgs e)
        {
            GoPanel.Width += 3;
            if (GoPanel.Width > 100)
            {
                GoTimer.Stop();

                HomeLogin h = new HomeLogin();
                h.Show();
                this.Hide();
            }
        }
        // --------------------------------------- GoTimer For Next Page -- END -->>>

    }
}
