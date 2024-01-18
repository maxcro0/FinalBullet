namespace BulletHell
{
    partial class ItemGain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.takeButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.rerollButton = new System.Windows.Forms.Button();
            this.rerollOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 300);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(400, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 300);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // takeButton
            // 
            this.takeButton.Location = new System.Drawing.Point(400, 416);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(205, 26);
            this.takeButton.TabIndex = 2;
            this.takeButton.Text = "Take";
            this.takeButton.UseVisualStyleBackColor = true;
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(45, 416);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(205, 26);
            this.leaveButton.TabIndex = 3;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            // 
            // rerollButton
            // 
            this.rerollButton.Location = new System.Drawing.Point(227, 488);
            this.rerollButton.Name = "rerollButton";
            this.rerollButton.Size = new System.Drawing.Size(205, 26);
            this.rerollButton.TabIndex = 4;
            this.rerollButton.Text = "Reroll";
            this.rerollButton.UseVisualStyleBackColor = true;
            // 
            // rerollOut
            // 
            this.rerollOut.ForeColor = System.Drawing.Color.White;
            this.rerollOut.Location = new System.Drawing.Point(224, 462);
            this.rerollOut.Name = "rerollOut";
            this.rerollOut.Size = new System.Drawing.Size(208, 23);
            this.rerollOut.TabIndex = 5;
            this.rerollOut.Text = "3/3";
            this.rerollOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemGain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.rerollOut);
            this.Controls.Add(this.rerollButton);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemGain";
            this.Size = new System.Drawing.Size(650, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button rerollButton;
        private System.Windows.Forms.Label rerollOut;
    }
}
