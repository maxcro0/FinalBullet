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
        public int health;
        public int bomb = 3;
        public int xCenter;
        public int yCenter;
        public string job;

        public Player(int _x, int _y, int _xSpeed, int _ySpeed, string _job)
        {
            //More variables 
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            xCenter = x + size / 2;
            yCenter = y + size / 2;
            job = _job;

            if (job == "mage")
            {
                health = 200;
            }

            if (job == "warrior")
            {
                health = 400;
            }

            else
            {
                health = 250;
            }

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
