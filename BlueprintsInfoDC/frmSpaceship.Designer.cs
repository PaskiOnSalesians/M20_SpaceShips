
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
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueprints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpace5)).BeginInit();
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
            this.lblTitle.Location = new System.Drawing.Point(1549, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(680, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Spaceship Technical Information";
            // 
            // picSpaceMain
            // 
            this.picSpaceMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpaceMain.Location = new System.Drawing.Point(1628, 142);
            this.picSpaceMain.Name = "picSpaceMain";
            this.picSpaceMain.Size = new System.Drawing.Size(514, 500);
            this.picSpaceMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceMain.TabIndex = 2;
            this.picSpaceMain.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(72, 166);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(368, 656);
            this.lblInfo.TabIndex = 3;
            // 
            // picBlueprints
            // 
            this.picBlueprints.Location = new System.Drawing.Point(568, 142);
            this.picBlueprints.Name = "picBlueprints";
            this.picBlueprints.Size = new System.Drawing.Size(500, 500);
            this.picBlueprints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueprints.TabIndex = 4;
            this.picBlueprints.TabStop = false;
            // 
            // picSpace1
            // 
            this.picSpace1.Location = new System.Drawing.Point(1452, 709);
            this.picSpace1.Name = "picSpace1";
            this.picSpace1.Size = new System.Drawing.Size(156, 160);
            this.picSpace1.TabIndex = 5;
            this.picSpace1.TabStop = false;
            // 
            // picSpace2
            // 
            this.picSpace2.Location = new System.Drawing.Point(1628, 709);
            this.picSpace2.Name = "picSpace2";
            this.picSpace2.Size = new System.Drawing.Size(156, 160);
            this.picSpace2.TabIndex = 6;
            this.picSpace2.TabStop = false;
            // 
            // picSpace4
            // 
            this.picSpace4.Location = new System.Drawing.Point(1986, 709);
            this.picSpace4.Name = "picSpace4";
            this.picSpace4.Size = new System.Drawing.Size(156, 160);
            this.picSpace4.TabIndex = 7;
            this.picSpace4.TabStop = false;
            // 
            // picSpace3
            // 
            this.picSpace3.Location = new System.Drawing.Point(1804, 709);
            this.picSpace3.Name = "picSpace3";
            this.picSpace3.Size = new System.Drawing.Size(156, 160);
            this.picSpace3.TabIndex = 8;
            this.picSpace3.TabStop = false;
            // 
            // picSpace5
            // 
            this.picSpace5.Location = new System.Drawing.Point(2166, 709);
            this.picSpace5.Name = "picSpace5";
            this.picSpace5.Size = new System.Drawing.Size(156, 160);
            this.picSpace5.TabIndex = 9;
            this.picSpace5.TabStop = false;
            // 
            // frmSpaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2452, 1166);
            this.Controls.Add(this.picSpace5);
            this.Controls.Add(this.picSpace3);
            this.Controls.Add(this.picSpace4);
            this.Controls.Add(this.picSpace2);
            this.Controls.Add(this.picSpace1);
            this.Controls.Add(this.picBlueprints);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picSpaceMain);
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
    }
}