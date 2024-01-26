namespace BulletHell
{
    partial class Dungeon
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
            this.currentBox = new System.Windows.Forms.Label();
            this.left1 = new System.Windows.Forms.Label();
            this.right1 = new System.Windows.Forms.Label();
            this.left2 = new System.Windows.Forms.Label();
            this.left3 = new System.Windows.Forms.Label();
            this.right3 = new System.Windows.Forms.Label();
            this.right2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentBox
            // 
            this.currentBox.BackColor = System.Drawing.Color.DimGray;
            this.currentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentBox.Location = new System.Drawing.Point(275, 437);
            this.currentBox.Name = "currentBox";
            this.currentBox.Size = new System.Drawing.Size(100, 95);
            this.currentBox.TabIndex = 0;
            this.currentBox.Text = "Current";
            this.currentBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // left1
            // 
            this.left1.BackColor = System.Drawing.Color.DimGray;
            this.left1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left1.Location = new System.Drawing.Point(95, 243);
            this.left1.Name = "left1";
            this.left1.Size = new System.Drawing.Size(132, 128);
            this.left1.TabIndex = 5;
            this.left1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.left1.Click += new System.EventHandler(this.left1_Click);
            // 
            // right1
            // 
            this.right1.BackColor = System.Drawing.Color.DimGray;
            this.right1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.right1.Location = new System.Drawing.Point(425, 243);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(132, 128);
            this.right1.TabIndex = 6;
            this.right1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.right1.Click += new System.EventHandler(this.right1_Click);
            // 
            // left2
            // 
            this.left2.BackColor = System.Drawing.Color.DimGray;
            this.left2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left2.Location = new System.Drawing.Point(13, 29);
            this.left2.Name = "left2";
            this.left2.Size = new System.Drawing.Size(132, 128);
            this.left2.TabIndex = 7;
            this.left2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // left3
            // 
            this.left3.BackColor = System.Drawing.Color.DimGray;
            this.left3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left3.Location = new System.Drawing.Point(179, 29);
            this.left3.Name = "left3";
            this.left3.Size = new System.Drawing.Size(132, 128);
            this.left3.TabIndex = 8;
            this.left3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right3
            // 
            this.right3.BackColor = System.Drawing.Color.DimGray;
            this.right3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.right3.Location = new System.Drawing.Point(505, 29);
            this.right3.Name = "right3";
            this.right3.Size = new System.Drawing.Size(132, 128);
            this.right3.TabIndex = 9;
            this.right3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right2
            // 
            this.right2.BackColor = System.Drawing.Color.DimGray;
            this.right2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.right2.Location = new System.Drawing.Point(343, 29);
            this.right2.Name = "right2";
            this.right2.Size = new System.Drawing.Size(132, 128);
            this.right2.TabIndex = 10;
            this.right2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.right2);
            this.Controls.Add(this.right3);
            this.Controls.Add(this.left3);
            this.Controls.Add(this.left2);
            this.Controls.Add(this.right1);
            this.Controls.Add(this.left1);
            this.Controls.Add(this.currentBox);
            this.Name = "Dungeon";
            this.Size = new System.Drawing.Size(650, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentBox;
        private System.Windows.Forms.Label left1;
        private System.Windows.Forms.Label right1;
        private System.Windows.Forms.Label left2;
        private System.Windows.Forms.Label left3;
        private System.Windows.Forms.Label right3;
        private System.Windows.Forms.Label right2;
    }
}
