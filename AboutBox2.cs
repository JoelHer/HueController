using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace HueController
{
    partial class AboutBox2 : Form
    {
        public AboutBox2()
        {
            InitializeComponent();
            ActiveForm.BackColor = Appearance.Colors.PrimaryBackgroundDark;
            label2.Text = HueBridge.ip;
            label4.Text = HueBridge.name;
            label6.Text = HueBridge.id;
            label8.Text = HueBridge.token;
        }

        private void AboutBox2_Load(object sender, EventArgs e)
        {

        }
    }
}
