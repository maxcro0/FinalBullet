namespace BulletHell
{
    partial class GameScreencs
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.colorBox = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.colorBox.Location = new System.Drawing.Point(-5, 460);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(655, 110);
            this.colorBox.TabIndex = 0;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(305, 513);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(44, 16);
            this.healthLabel.TabIndex = 16;
            this.healthLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Health:";
            // 
            // GameScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.colorBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreencs";
            this.Size = new System.Drawing.Size(650, 570);
            this.Load += new System.EventHandler(this.GameScreencs_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreencs_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label colorBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label label1;
    }
}
