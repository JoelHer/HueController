
namespace HueController
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        



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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBorderRadius1 = new HueController.VisualScripts.ButtonBorderRadius();
            this.applicationTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moreInformationLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPointer = new System.Windows.Forms.PictureBox();
            this.pictureBoxNotFound = new System.Windows.Forms.PictureBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBorderRadius1
            // 
            this.buttonBorderRadius1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buttonBorderRadius1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buttonBorderRadius1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonBorderRadius1.BorderRadius = 50;
            this.buttonBorderRadius1.BorderSize = 0;
            this.buttonBorderRadius1.FlatAppearance.BorderSize = 0;
            this.buttonBorderRadius1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorderRadius1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonBorderRadius1.Location = new System.Drawing.Point(128, 520);
            this.buttonBorderRadius1.Name = "buttonBorderRadius1";
            this.buttonBorderRadius1.Size = new System.Drawing.Size(248, 64);
            this.buttonBorderRadius1.TabIndex = 1;
            this.buttonBorderRadius1.Text = "Search For Hue Bridge";
            this.buttonBorderRadius1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonBorderRadius1.UseVisualStyleBackColor = false;
            this.buttonBorderRadius1.Click += new System.EventHandler(this.buttonBorderRadius1_Click);
            // 
            // applicationTitle
            // 
            this.applicationTitle.AutoSize = true;
            this.applicationTitle.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applicationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.applicationTitle.Location = new System.Drawing.Point(64, 41);
            this.applicationTitle.Name = "applicationTitle";
            this.applicationTitle.Size = new System.Drawing.Size(374, 24);
            this.applicationTitle.TabIndex = 2;
            this.applicationTitle.Text = "Start Finding Your Brigde!";
            this.applicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.moreInformationLabel);
            this.panel1.Controls.Add(this.pictureBoxPointer);
            this.panel1.Controls.Add(this.pictureBoxNotFound);
            this.panel1.Controls.Add(this.richTextBoxInfo);
            this.panel1.Location = new System.Drawing.Point(30, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 416);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // moreInformationLabel
            // 
            this.moreInformationLabel.AutoSize = true;
            this.moreInformationLabel.Location = new System.Drawing.Point(4, 398);
            this.moreInformationLabel.Name = "moreInformationLabel";
            this.moreInformationLabel.Size = new System.Drawing.Size(101, 15);
            this.moreInformationLabel.TabIndex = 5;
            this.moreInformationLabel.TabStop = true;
            this.moreInformationLabel.Text = "More information";
            this.moreInformationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreInformationLabel_LinkClicked);
            // 
            // pictureBoxPointer
            // 
            this.pictureBoxPointer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPointer.Image")));
            this.pictureBoxPointer.Location = new System.Drawing.Point(111, 197);
            this.pictureBoxPointer.Name = "pictureBoxPointer";
            this.pictureBoxPointer.Size = new System.Drawing.Size(261, 268);
            this.pictureBoxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPointer.TabIndex = 4;
            this.pictureBoxPointer.TabStop = false;
            // 
            // pictureBoxNotFound
            // 
            this.pictureBoxNotFound.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotFound.Image")));
            this.pictureBoxNotFound.Location = new System.Drawing.Point(120, 197);
            this.pictureBoxNotFound.Name = "pictureBoxNotFound";
            this.pictureBoxNotFound.Size = new System.Drawing.Size(211, 200);
            this.pictureBoxNotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNotFound.TabIndex = 3;
            this.pictureBoxNotFound.TabStop = false;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.richTextBoxInfo.Location = new System.Drawing.Point(24, 18);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxInfo.Size = new System.Drawing.Size(404, 176);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "We currently don\'t know your Bridge :(\nStart searching for your bridge by clickin" +
    "g \"Search For Hue Bridge\"!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(507, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.applicationTitle);
            this.Controls.Add(this.buttonBorderRadius1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Hue-Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VisualScripts.ButtonBorderRadius buttonBorderRadius1;
        private System.Windows.Forms.Label applicationTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxNotFound;
        private System.Windows.Forms.PictureBox pictureBoxPointer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel moreInformationLabel;
    }
}

