using HueController.HueDiscovery;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HueController
{
    public partial class Form1 : Form
    {
        private static string ip = null;


        //INTERACTIONLEVELS
        //ILevel 0 = No bridge Found
        //ILevel 1 = Bridge Found, No token
        //ILevel 2 = Logged In with Token
        public int interactionLevel = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBoxPointer.Visible = false;
            moreInformationLabel.Visible = false;
        }

        private void buttonBorderRadius1_Click(object sender, EventArgs e)
        {
            if(interactionLevel == 0)
            {
                JArray bridges = FindBridge.discoverBridges();

                if (bridges.Count != 0)
                {
                    applicationTitle.Text = "We found your bridge!";
                    richTextBoxInfo.Text = "Looks like we found your bridge! \nYou're only one step away from connecting your bridge!\nPlease Press the connect button on your Philips Hue Bridge to connect this application to your network.";
                    interactionLevel = 1;
                    buttonBorderRadius1.Enabled = false;
                    pictureBoxNotFound.Visible = false;
                    pictureBoxPointer.Visible = true;
                    moreInformationLabel.Visible = true;
                }
                else
                {
                    buttonBorderRadius1.Text = "No bridge found, try again";
                }
            }
            if (interactionLevel == 1)
            {
                JArray result = FindBridge.getToken(HueBridge.ip);
                bool error = false;
                string errorDescription;
                try
                {
                    errorDescription = "no error.";
                    if (result[0]["error"]["type"].ToString() == "101")
                    {
                        error = true;
                        errorDescription = "Link button not pressed";
                    }
                }
                catch (Exception) { throw; }
                richTextBoxInfo.Text = errorDescription;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxInfo.Text = "We currently don't know where your Bridge is :( \nLet us search for your bridge, by clicking \"Search For Hue Bridge\"!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var aboutDialog = new AboutBox1();
            aboutDialog.Show(); 
        }

        private void moreInformationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var aboutDialog = new AboutBox2();
            aboutDialog.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
