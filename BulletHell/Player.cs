using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Player
    {
        //Constructor stuff and variables
        public int size = 6;
        public int x, y, xSpeed, ySpeed;
        public int baseHealth;
        public int health;
        public int bomb = 3;
        public int xCenter;
        public int yCenter;
        public string job;
        public int damage;
        public static int attackRate;
        public int critRate;
        public int defence;
        public float lifesteal;
        public static int rawValue;
        List<string> playConditons = new List<string>();

        public int testVar = -1;

        //health boost, armour, lifesteal, damage,  attackRate, crit
        public static int[] helmet = { 100, 100, 0, 100, 100, 100};
        public static int[] chestplate = { 100, 100, 0, 100, 100, 100 };
        //lifesteal, damage, attackRate, crit
        public static int[] weapon = { 0, 10, 10, 10 };

        public Player(int _x, int _y, int _xSpeed, int _ySpeed, string _job)
        {
            //Changes base health based on class
            if (job == "Mage")
            {
                baseHealth = 200;
            }

            if (job == "Warrior")
            {
                baseHealth = 300;
            }

            else
            {
                baseHealth = 250;
            }

            //Calculates new stats based on stat boosts
            health = baseHealth + helmet[0] + chestplate[0];
            defence = helmet[1] + chestplate[1];
            lifesteal = helmet[2] + chestplate[2] + weapon[0];
            damage = 10 + helmet[3] + chestplate[3] + weapon[1];
            attackRate = 100 + helmet[4] + chestplate[4] + weapon[2];
            critRate = helmet[5] + chestplate[5] + weapon[3];

            //Adding stats together and dividing them for the boss to scale on
            rawValue = Convert.ToInt32(damage + attackRate + critRate + lifesteal + (health - baseHealth)/5);

            //More variables 
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            xCenter = x + size / 2;
            yCenter = y + size / 2;
            job = _job;

            
            

        }
        public void Move(string direction)
        {
            //Using a string, moves the player
            if (direction == "left")
            {
                x -= xSpeed;
            }
            else if (direction == "right")
            {
                x += xSpeed;
            }

            if (direction == "up")
            {
                y -= ySpeed;
            }
            else if (direction == "down")
            {
                y += ySpeed;
            }



        }


    }
}
