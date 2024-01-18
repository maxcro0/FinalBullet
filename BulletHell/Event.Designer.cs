namespace BulletHell
{
    partial class Event
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventtextOut = new System.Windows.Forms.Label();
            this.engageButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventtextOut
            // 
            this.eventtextOut.ForeColor = System.Drawing.Color.White;
            this.eventtextOut.Location = new System.Drawing.Point(3, 304);
            this.eventtextOut.Name = "eventtextOut";
            this.eventtextOut.Size = new System.Drawing.Size(644, 152);
            this.eventtextOut.TabIndex = 0;
            this.eventtextOut.Text = "You found an underground holy cave!";
            this.eventtextOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // engageButton
            // 
            this.engageButton.Location = new System.Drawing.Point(449, 497);
            this.engageButton.Name = "engageButton";
            this.engageButton.Size = new System.Drawing.Size(124, 31);
            this.engageButton.TabIndex = 1;
            this.engageButton.Text = "Engage";
            this.engageButton.UseVisualStyleBackColor = true;
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(79, 497);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(124, 31);
            this.leaveButton.TabIndex = 2;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 237);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.engageButton);
            this.Controls.Add(this.eventtextOut);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(650, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventtextOut;
        private System.Windows.Forms.Button engageButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
