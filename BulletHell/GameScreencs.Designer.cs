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
            this.label1 = new System.Windows.Forms.Label();
            this.cd2Out = new System.Windows.Forms.Label();
            this.cd3Out = new System.Windows.Forms.Label();
            this.cd1Out = new System.Windows.Forms.Label();
            this.cd4Out = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // cd2Out
            // 
            this.cd2Out.BackColor = System.Drawing.Color.White;
            this.cd2Out.Location = new System.Drawing.Point(288, 460);
            this.cd2Out.Name = "cd2Out";
            this.cd2Out.Size = new System.Drawing.Size(37, 33);
            this.cd2Out.TabIndex = 12;
            this.cd2Out.Text = "label2";
            // 
            // cd3Out
            // 
            this.cd3Out.BackColor = System.Drawing.Color.White;
            this.cd3Out.Location = new System.Drawing.Point(331, 460);
            this.cd3Out.Name = "cd3Out";
            this.cd3Out.Size = new System.Drawing.Size(37, 33);
            this.cd3Out.TabIndex = 13;
            this.cd3Out.Text = "label2";
            // 
            // cd1Out
            // 
            this.cd1Out.BackColor = System.Drawing.Color.White;
            this.cd1Out.Location = new System.Drawing.Point(245, 460);
            this.cd1Out.Name = "cd1Out";
            this.cd1Out.Size = new System.Drawing.Size(37, 33);
            this.cd1Out.TabIndex = 14;
            this.cd1Out.Text = "label2";
            // 
            // cd4Out
            // 
            this.cd4Out.BackColor = System.Drawing.Color.White;
            this.cd4Out.Location = new System.Drawing.Point(374, 460);
            this.cd4Out.Name = "cd4Out";
            this.cd4Out.Size = new System.Drawing.Size(37, 33);
            this.cd4Out.TabIndex = 15;
            this.cd4Out.Text = "label2";
            // 
            // GameScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cd4Out);
            this.Controls.Add(this.cd1Out);
            this.Controls.Add(this.cd3Out);
            this.Controls.Add(this.cd2Out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreencs";
            this.Size = new System.Drawing.Size(650, 570);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreencs_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label colorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cd2Out;
        private System.Windows.Forms.Label cd3Out;
        private System.Windows.Forms.Label cd1Out;
        private System.Windows.Forms.Label cd4Out;
    }
}
