﻿
namespace BlueprintsInfoDC
{
    partial class frmSpaceship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpaceship));
            this.cmbNaus = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picSpaceMain = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picBlueprints = new System.Windows.Forms.PictureBox();
            this.picSpace1 = new System.Windows.Forms.PictureBox();
            this.picSpace2 = new System.Windows.Forms.PictureBox();
            this.picSpace4 = new System.Windows.Forms.PictureBox();
            this.picSpace3 = new System.Windows.Forms.PictureBox();
            this.picSpace5 = new System.Windows.Forms.PictureBox();
            this.lblSpaceshipName = new System.Windows.Forms.Label();
            this.axWMPvideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlMedia = new System.Windows.Forms.Panel();
            this.pnlImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueprints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPvideo)).BeginInit();
            this.pnlMedia.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNaus
            // 
            this.cmbNaus.FormattingEnabled = true;
            this.cmbNaus.Location = new System.Drawing.Point(77, 96);
            this.cmbNaus.Name = "cmbNaus";
            this.cmbNaus.Size = new System.Drawing.Size(363, 33);
            this.cmbNaus.TabIndex = 0;
            this.cmbNaus.SelectedIndexChanged += new System.EventHandler(this.cmbNaus_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(1635, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(680, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Spaceship Technical Information";
            // 
            // picSpaceMain
            // 
            this.picSpaceMain.BackColor = System.Drawing.Color.Khaki;
            this.picSpaceMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSpaceMain.Location = new System.Drawing.Point(0, 0);
            this.picSpaceMain.Name = "picSpaceMain";
            this.picSpaceMain.Size = new System.Drawing.Size(600, 600);
            this.picSpaceMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceMain.TabIndex = 2;
            this.picSpaceMain.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInfo.Location = new System.Drawing.Point(72, 166);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(368, 656);
            this.lblInfo.TabIndex = 3;
            // 
            // picBlueprints
            // 
            this.picBlueprints.Location = new System.Drawing.Point(648, 116);
            this.picBlueprints.Name = "picBlueprints";
            this.picBlueprints.Size = new System.Drawing.Size(600, 600);
            this.picBlueprints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueprints.TabIndex = 4;
            this.picBlueprints.TabStop = false;
            // 
            // picSpace1
            // 
            this.picSpace1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpace1.Location = new System.Drawing.Point(1460, 759);
            this.picSpace1.Margin = new System.Windows.Forms.Padding(5);
            this.picSpace1.Name = "picSpace1";
            this.picSpace1.Size = new System.Drawing.Size(200, 200);
            this.picSpace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpace1.TabIndex = 5;
            this.picSpace1.TabStop = false;
            this.picSpace1.Click += new System.EventHandler(this.picSpace1_Click);
            // 
            // picSpace2
            // 
            this.picSpace2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpace2.Location = new System.Drawing.Point(1670, 759);
            this.picSpace2.Margin = new System.Windows.Forms.Padding(5);
            this.picSpace2.Name = "picSpace2";
            this.picSpace2.Size = new System.Drawing.Size(200, 200);
            this.picSpace2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpace2.TabIndex = 6;
            this.picSpace2.TabStop = false;
            this.picSpace2.Click += new System.EventHandler(this.picSpace2_Click);
            // 
            // picSpace4
            // 
            this.picSpace4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpace4.Location = new System.Drawing.Point(2090, 759);
            this.picSpace4.Margin = new System.Windows.Forms.Padding(5);
            this.picSpace4.Name = "picSpace4";
            this.picSpace4.Size = new System.Drawing.Size(200, 200);
            this.picSpace4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpace4.TabIndex = 7;
            this.picSpace4.TabStop = false;
            this.picSpace4.Click += new System.EventHandler(this.picSpace4_Click);
            // 
            // picSpace3
            // 
            this.picSpace3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpace3.Location = new System.Drawing.Point(1880, 759);
            this.picSpace3.Margin = new System.Windows.Forms.Padding(5);
            this.picSpace3.Name = "picSpace3";
            this.picSpace3.Size = new System.Drawing.Size(200, 200);
            this.picSpace3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpace3.TabIndex = 8;
            this.picSpace3.TabStop = false;
            this.picSpace3.Click += new System.EventHandler(this.picSpace3_Click);
            // 
            // picSpace5
            // 
            this.picSpace5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpace5.Location = new System.Drawing.Point(2300, 759);
            this.picSpace5.Margin = new System.Windows.Forms.Padding(5);
            this.picSpace5.Name = "picSpace5";
            this.picSpace5.Size = new System.Drawing.Size(200, 200);
            this.picSpace5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpace5.TabIndex = 9;
            this.picSpace5.TabStop = false;
            this.picSpace5.Click += new System.EventHandler(this.picSpace5_Click);
            // 
            // lblSpaceshipName
            // 
            this.lblSpaceshipName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpaceshipName.AutoSize = true;
            this.lblSpaceshipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblSpaceshipName.Location = new System.Drawing.Point(1863, 982);
            this.lblSpaceshipName.Name = "lblSpaceshipName";
            this.lblSpaceshipName.Size = new System.Drawing.Size(0, 51);
            this.lblSpaceshipName.TabIndex = 10;
            // 
            // axWMPvideo
            // 
            this.axWMPvideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.axWMPvideo.Enabled = true;
            this.axWMPvideo.Location = new System.Drawing.Point(0, 0);
            this.axWMPvideo.Name = "axWMPvideo";
            this.axWMPvideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPvideo.OcxState")));
            this.axWMPvideo.Size = new System.Drawing.Size(598, 598);
            this.axWMPvideo.TabIndex = 11;
            this.axWMPvideo.Visible = false;
            // 
            // pnlMedia
            // 
            this.pnlMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMedia.BackColor = System.Drawing.Color.Silver;
            this.pnlMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMedia.Controls.Add(this.axWMPvideo);
            this.pnlMedia.ForeColor = System.Drawing.Color.White;
            this.pnlMedia.Location = new System.Drawing.Point(1679, 142);
            this.pnlMedia.Name = "pnlMedia";
            this.pnlMedia.Size = new System.Drawing.Size(600, 600);
            this.pnlMedia.TabIndex = 12;
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.BackColor = System.Drawing.Color.Maroon;
            this.pnlImage.Controls.Add(this.picSpaceMain);
            this.pnlImage.Location = new System.Drawing.Point(1683, 138);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(600, 600);
            this.pnlImage.TabIndex = 13;
            // 
            // frmSpaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2624, 1596);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlMedia);
            this.Controls.Add(this.lblSpaceshipName);
            this.Controls.Add(this.picSpace5);
            this.Controls.Add(this.picSpace3);
            this.Controls.Add(this.picSpace4);
            this.Controls.Add(this.picSpace2);
            this.Controls.Add(this.picSpace1);
            this.Controls.Add(this.picBlueprints);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbNaus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSpaceship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSpaceship";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSpaceship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueprints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPvideo)).EndInit();
            this.pnlMedia.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNaus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSpaceMain;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picBlueprints;
        private System.Windows.Forms.PictureBox picSpace1;
        private System.Windows.Forms.PictureBox picSpace2;
        private System.Windows.Forms.PictureBox picSpace4;
        private System.Windows.Forms.PictureBox picSpace3;
        private System.Windows.Forms.PictureBox picSpace5;
        private System.Windows.Forms.Label lblSpaceshipName;
        private AxWMPLib.AxWindowsMediaPlayer axWMPvideo;
        private System.Windows.Forms.Panel pnlMedia;
        private System.Windows.Forms.Panel pnlImage;
    }
}