namespace BulletHell
{
    partial class Menu
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
            this.exitButton = new System.Windows.Forms.Button();
            this.lunaticButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.mageButton = new System.Windows.Forms.Button();
            this.warriorButton = new System.Windows.Forms.Button();
            this.rogueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(529, 517);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 27);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lunaticButton
            // 
            this.lunaticButton.Location = new System.Drawing.Point(189, 300);
            this.lunaticButton.Name = "lunaticButton";
            this.lunaticButton.Size = new System.Drawing.Size(281, 53);
            this.lunaticButton.TabIndex = 4;
            this.lunaticButton.Text = "Start Game";
            this.lunaticButton.UseVisualStyleBackColor = true;
            this.lunaticButton.Click += new System.EventHandler(this.lunaticButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(529, 463);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(95, 27);
            this.controlButton.TabIndex = 5;
            this.controlButton.Text = "Controls";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // controlLabel
            // 
            this.controlLabel.ForeColor = System.Drawing.Color.White;
            this.controlLabel.Location = new System.Drawing.Point(529, 363);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(95, 75);
            this.controlLabel.TabIndex = 6;
            this.controlLabel.Text = "Move: WASD \r\nAbilities: 1,2,3\r\nAttack: Space\r\nBomb: V\r\n\r\n";
            this.controlLabel.Visible = false;
            // 
            // chooseLabel
            // 
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(186, 405);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(284, 23);
            this.chooseLabel.TabIndex = 7;
            this.chooseLabel.Text = "Choose your class";
            this.chooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chooseLabel.Visible = false;
            // 
            // mageButton
            // 
            this.mageButton.Location = new System.Drawing.Point(150, 460);
            this.mageButton.Name = "mageButton";
            this.mageButton.Size = new System.Drawing.Size(98, 30);
            this.mageButton.TabIndex = 8;
            this.mageButton.Text = "Mage";
            this.mageButton.UseVisualStyleBackColor = true;
            this.mageButton.Visible = false;
            this.mageButton.Click += new System.EventHandler(this.mageButton_Click);
            // 
            // warriorButton
            // 
            this.warriorButton.Location = new System.Drawing.Point(278, 460);
            this.warriorButton.Name = "warriorButton";
            this.warriorButton.Size = new System.Drawing.Size(98, 30);
            this.warriorButton.TabIndex = 9;
            this.warriorButton.Text = "Warrior";
            this.warriorButton.UseVisualStyleBackColor = true;
            this.warriorButton.Visible = false;
            this.warriorButton.Click += new System.EventHandler(this.warriorButton_Click);
            // 
            // rogueButton
            // 
            this.rogueButton.Location = new System.Drawing.Point(409, 460);
            this.rogueButton.Name = "rogueButton";
            this.rogueButton.Size = new System.Drawing.Size(98, 30);
            this.rogueButton.TabIndex = 10;
            this.rogueButton.Text = "Rogue";
            this.rogueButton.UseVisualStyleBackColor = true;
            this.rogueButton.Visible = false;
            this.rogueButton.Click += new System.EventHandler(this.rogueButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.rogueButton);
            this.Controls.Add(this.warriorButton);
            this.Controls.Add(this.mageButton);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.lunaticButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(650, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button lunaticButton;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button mageButton;
        private System.Windows.Forms.Button warriorButton;
        private System.Windows.Forms.Button rogueButton;
    }
}
