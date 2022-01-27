namespace BlueprintsInfoDC
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSpaceship = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "Starkiller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpaceship
            // 
            this.btnSpaceship.Location = new System.Drawing.Point(452, 90);
            this.btnSpaceship.Margin = new System.Windows.Forms.Padding(6);
            this.btnSpaceship.Name = "btnSpaceship";
            this.btnSpaceship.Size = new System.Drawing.Size(192, 98);
            this.btnSpaceship.TabIndex = 2;
            this.btnSpaceship.Text = "Spaceship";
            this.btnSpaceship.UseVisualStyleBackColor = true;
            this.btnSpaceship.Click += new System.EventHandler(this.btnSpaceship_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnSpaceship);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSpaceship;
    }
}