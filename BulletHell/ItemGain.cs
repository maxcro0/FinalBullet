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
    public partial class ItemGain : UserControl
    {
        //Vars
        Random Random = new Random();
        string gear;
        int myDamage;
        int myAR;
        int myCR;
        int myDefence;
        float myLS;
        int newDamage;
        int newAR;
        int newCR;
        int newDefence;
        float newLS;
        int myHealth;
        int reroll = 3;

        //Item arrays
        //health boost, armour, lifesteal, damage,  attackRate, crit
        int[] newStats = { 0, 0, 0, 0, 0, 0 };
        //lifesteal, damage, attackRate, crit
        int[] newWeap = { 0, 0, 0, 0 };
        public ItemGain()
        {
            InitializeComponent();
            GenGear();
            DisplayGear();
            reroll = 3;
        }

        public void GenGear()
        {
            //Clears arrays for new items
            Array.Clear(newStats, 0, newStats.Length);
            Array.Clear(newWeap, 0, newWeap.Length);
            int tempNum = Random.Next(0, 3);
            //tempNum = Random.Next(0, 3);

            //Random chance for each item
            if (tempNum == 1)
            {
                gear = "Helmet";
            }

            else if (tempNum == 2)
            {
                gear = "Chestplate";
            }

            else
            {
                gear = "Weapon";
            }

            if (gear == "Weapon")
            {
                //Fills current stats from an array
                myLS = Player.weapon[0];
                myDamage = Player.weapon[1];
                myAR = Player.weapon[2];
                myCR = Player.weapon[3];

                int lsChance = Random.Next(0, 3);

                //Lifesteal chance
                if (lsChance == 3)

                {

                    newWeap[0] = Random.Next((int)(myLS - (myLS / 2)), (int)(myLS + 7));

                }

                //random stats based on current stats

                newWeap[1] = Random.Next(myDamage - (myDamage / 2), myDamage * 2);

                newWeap[2] = Random.Next(myAR - (myAR / 2), myAR + 20);

                newWeap[3] = Random.Next(myCR - (myCR / 2), myCR + 30);

            }

            else if (gear == "Chestplate")
            {
                //Fills current stats from an array
                myHealth = Player.chestplate[0];
                myDefence = Player.chestplate[1];
                myLS = Player.chestplate[2];
                myDamage = Player.chestplate[3];
                myAR = Player.chestplate[4];
                myCR = Player.chestplate[5];

                int lsChance = Random.Next(0, 3);

                //Lifesteal chance
                if (lsChance == 3)

                {

                    newStats[2] = Random.Next((int)(myLS - (myLS / 2)), (int)(myLS + 7));

                }

                //Random stats  based on current

                newStats[0] = Random.Next(myHealth - (myHealth / 2), myHealth * 2);
                newStats[1] = Random.Next(myDefence - (myDefence / 2), myDefence * 2);
                newStats[3] = Random.Next(myDamage - (myDamage / 2), myDamage * 2);
                newStats[4] = Random.Next(myAR - (myAR / 2), myAR * 2);
                newStats[5] = Random.Next(myCR - (myCR / 2), myCR * 2);
            }

            else
            {
                //Fills current stats from an array
                myHealth = Player.helmet[0];
                myDefence = Player.helmet[1];
                myLS = Player.helmet[2];
                myDamage = Player.helmet[3];
                myAR = Player.helmet[4];
                myCR = Player.helmet[5];

                int lsChance = Random.Next(0, 3);

                //Lifesteal chance
                if (lsChance == 3)

                {

                    newStats[3] = Random.Next((int)(myLS - (myLS / 2)), (int)(myLS + 7));

                }

                //Random stats
                newStats[0] = Random.Next(myHealth - (myHealth / 2), myHealth * 2);
                newStats[1] = Random.Next(myDefence - (myDefence / 2), myDefence * 2);
                newStats[3] = Random.Next(myDamage - (myDamage / 2), myDamage * 2);
                newStats[4] = Random.Next(myAR - (myAR / 2), myAR * 2);
                newStats[5] = Random.Next(myCR - (myCR / 2), myCR * 2);
            }



        }

        private void DisplayGear()
        {

            //Displays all gear stats old and new to compare
            if (gear == "Weapon")
            {
                myGear.Text = $"Lifesteal:{myLS}\nDamage:{myDamage}\nAttack Rate+:{myAR}\nCritical Rate:{myCR}";

                newGear.Text = $"Lifesteal:{newWeap[0]}\nDamage:{newWeap[1]}\nAttack Rate:{newWeap[2]}\nCritical Rate:{newWeap[3]}";
            }

            else if (gear == "Chestplate")
            {
                myGear.Text = $"Health+:{myHealth}\nDefence:{myDefence}\nLifesteal:{myLS}\nDamage:{myDamage}\nAttack Rate+{myAR}\nCritical Rate:{myCR}";

                newGear.Text = $"Health+:{newStats[0]}\nDefence:{newStats[1]}\nLifesteal:{newStats[2]}\nDamage:{newStats[3]}\nAttack Rate+{newStats[4]}\nCritical Rate:{newStats[5]}";
            }

            else
            {
                myGear.Text = $"Health+:{myHealth}\nDefence:{myDefence}\nLifesteal:{myLS}\nDamage:{myDamage}\nAttack Rate+{myAR}\nCritical Rate:{myCR}";

                newGear.Text = $"Health+:{newStats[0]}\nDefence:{newStats[1]}\nLifesteal:{newStats[2]}\nDamage:{newStats[3]}\nAttack Rate+{newStats[4]}\nCritical Rate:{newStats[5]}";

            }

            gearOut.Text = gear;
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            //Replaces player gear with new gear
            if (gear == "Weapon")
            {
                //lifesteal, damage, attackRate, crit
                Array.Clear(Player.weapon, 0, Player.weapon.Length);
                Player.weapon[0] = (int)newLS;
                Player.weapon[1] = newDamage;
                Player.weapon[2] = newAR;
                Player.weapon[3] = newCR;
                Form1.ChangeScreen(this, new Dungeon());
            }

            else if (gear == "Chestplate")
            {
                //health boost, armour, lifesteal, damage,  attackRate, crit
                Array.Clear(Player.chestplate, 0, Player.chestplate.Length);
                Player.chestplate[0] = newStats[0];
                Player.chestplate[1] = newStats[1];
                Player.chestplate[2] = newStats[2];
                Player.chestplate[3] = newStats[3];
                Player.chestplate[4] = newStats[4];
                Player.chestplate[5] = newStats[5];
                Form1.ChangeScreen(this, new Dungeon());
            }

            else
            {
                //health boost, armour, lifesteal, damage,  attackRate, crit
                Array.Clear(Player.helmet, 0, Player.helmet.Length);
                Player.helmet[0] = newStats[0];
                Player.helmet[1] = newStats[1];
                Player.helmet[2] = newStats[2];
                Player.helmet[3] = newStats[3];
                Player.helmet[4] = newStats[4];
                Player.helmet[5] = newStats[5];
                Form1.ChangeScreen(this, new Dungeon());
            }
        }

        private void rerollButton_Click(object sender, EventArgs e)
        {
            if (reroll > 0)
            {
                GenGear();
                DisplayGear();
                reroll--;
                rerollOut.Text = $"{reroll}/3";
            }

            else
            {
                rerollOut.Text = "No more rerolls";
            }
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Dungeon());
        }
    }
}
