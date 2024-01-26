using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletHell
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lunaticButton_Click(object sender, EventArgs e)
        {
            //Changes to game
            //Form1.ChangeScreen(this, new Dungeon());

            chooseLabel.Visible = true; 
            mageButton.Visible = true;
            warriorButton.Visible = true;
            rogueButton.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            //Shows controls
            if (controlLabel.Visible == false)
            {
                controlLabel.Visible = true;
            }
            else
            {
                controlLabel.Visible = false;
            }

        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            //Selects job
            Dungeon.job = "Mage";
            Form1.ChangeScreen(this, new Dungeon());
        }

        private void warriorButton_Click(object sender, EventArgs e)
        {
            //Selects job
            Dungeon.job = "Warrior";
            Form1.ChangeScreen(this, new Dungeon());
        }

        private void rogueButton_Click(object sender, EventArgs e)
        {
            //Selects job
            Dungeon.job = "Rogue";
            Form1.ChangeScreen(this, new Dungeon());
        }
    }
}
