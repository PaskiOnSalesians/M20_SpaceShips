
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
            this.picSpaceship = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picBlueprints = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueprints)).BeginInit();
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1531, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(590, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Spaceship Technical Information";
            // 
            // picSpaceship
            // 
            this.picSpaceship.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpaceship.Location = new System.Drawing.Point(1580, 142);
            this.picSpaceship.Name = "picSpaceship";
            this.picSpaceship.Size = new System.Drawing.Size(500, 500);
            this.picSpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceship.TabIndex = 2;
            this.picSpaceship.TabStop = false;
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
            // frmSpaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2308, 1166);
            this.Controls.Add(this.picBlueprints);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picSpaceship);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbNaus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSpaceship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSpaceship";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSpaceship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueprints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNaus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSpaceship;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picBlueprints;
    }
}