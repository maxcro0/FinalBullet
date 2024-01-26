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
            this.myGear = new System.Windows.Forms.Label();
            this.newGear = new System.Windows.Forms.Label();
            this.takeButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.rerollButton = new System.Windows.Forms.Button();
            this.rerollOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gearOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myGear
            // 
            this.myGear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGear.ForeColor = System.Drawing.Color.White;
            this.myGear.Location = new System.Drawing.Point(45, 60);
            this.myGear.Name = "myGear";
            this.myGear.Size = new System.Drawing.Size(205, 300);
            this.myGear.TabIndex = 0;
            this.myGear.Text = "label1";
            this.myGear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGear
            // 
            this.newGear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGear.ForeColor = System.Drawing.Color.White;
            this.newGear.Location = new System.Drawing.Point(400, 60);
            this.newGear.Name = "newGear";
            this.newGear.Size = new System.Drawing.Size(205, 300);
            this.newGear.TabIndex = 1;
            this.newGear.Text = "label2";
            this.newGear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeButton
            // 
            this.takeButton.Location = new System.Drawing.Point(400, 416);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(205, 26);
            this.takeButton.TabIndex = 2;
            this.takeButton.Text = "Take";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(45, 416);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(205, 26);
            this.leaveButton.TabIndex = 3;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // rerollButton
            // 
            this.rerollButton.Location = new System.Drawing.Point(227, 488);
            this.rerollButton.Name = "rerollButton";
            this.rerollButton.Size = new System.Drawing.Size(205, 26);
            this.rerollButton.TabIndex = 4;
            this.rerollButton.Text = "Reroll";
            this.rerollButton.UseVisualStyleBackColor = true;
            this.rerollButton.Click += new System.EventHandler(this.rerollButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "My gear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(462, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "New gear";
            // 
            // gearOut
            // 
            this.gearOut.AutoSize = true;
            this.gearOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearOut.ForeColor = System.Drawing.Color.White;
            this.gearOut.Location = new System.Drawing.Point(286, 198);
            this.gearOut.Name = "gearOut";
            this.gearOut.Size = new System.Drawing.Size(83, 25);
            this.gearOut.TabIndex = 8;
            this.gearOut.Text = "My gear";
            // 
            // ItemGain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gearOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rerollOut);
            this.Controls.Add(this.rerollButton);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.newGear);
            this.Controls.Add(this.myGear);
            this.Name = "ItemGain";
            this.Size = new System.Drawing.Size(650, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myGear;
        private System.Windows.Forms.Label newGear;
        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button rerollButton;
        private System.Windows.Forms.Label rerollOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gearOut;
    }
}
