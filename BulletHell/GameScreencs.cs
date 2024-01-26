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
    public partial class GameScreencs : UserControl
    {
        public static int points = 0;
        public static int graze = 0;
        int bombamm = 3;
        double healthBar = 500;
        double healthRatio;
        string healthbarText;
        int maxHealth;
        int myMaxHP;
        string moveDirection = "right";
        public static bool win = false;

        Player me;
        Enemy1 boss;
        ProjectileCircle projectile;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush blueBrush = new SolidBrush(Color.SlateBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        public static bool col = false;
        bool goLeft = true;
        bool goUp = false;
        bool shooting = false;
        bool bombing = false;
        int bombTimer = 0;
        bool justDied;
        List<ProjectileCircle> projectiles = new List<ProjectileCircle>();
        List<StringProjectile> friendProjectiles = new List<StringProjectile>();
        List<Enemy1> enemies = new List<Enemy1>();
        int attack1Timer = 0;
        int attack2Timer = 0;
        int attack3Timer = 0;
        int invulTimer = 0;
        int shotTimer = 0;
        bool phase1 = true;
        bool phase2 = false;
        bool phase3 = false;
        bool phase3initial = false;
        Point[] arrow;
        public Point phase2attack1;
        public Point phase2attack2;
        public static bool dark;
        public static bool curse;
        public static bool eve;
        public static bool tense;
        public static bool torch;
        Random random = new Random();
        int tempMove;
        string ranMove;
        public static int ranMovetime = 300;


        private void label1_Click(object sender, EventArgs e)
        {

        }



        List<ProjectileCircle> Projectile = new List<ProjectileCircle>();


        public GameScreencs()
        {
            // Initializing Me, Boss, Boss arrow, Phase 2 points, Health ratio
            InitializeComponent();

            me = new Player(270, 300, 4, 4, Dungeon.job);
            myMaxHP = me.health;
            boss = new Enemy1(270, 30, 2, 2, "slime");
            arrow = new Point[] { new Point(boss.x, 445), new Point(boss.xCenter, 435), new Point(boss.x + boss.width, 445) };
            phase2attack1 = new Point(45, 35);
            phase2attack2 = new Point(405, 35);
            healthRatio = healthBar / boss.health;
            points = 0;
            graze = 0;
            maxHealth = boss.health;
            win = false;
            gameTimer.Start();





        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Movement keys down
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    upArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
                case Keys.ShiftKey:
                    me.ySpeed = 2;
                    me.xSpeed = 2;
                    break;
                case Keys.Space:
                    shooting = true;
                    break;
                case Keys.V:
                    if (bombing == false)
                    {
                        if (bombamm > 0 && bombTimer >= 20)
                        {
                            bombing = true;
                            bombamm--;

                        }
                    }
                    break;






            }
        }

        private void deleteProjectiles()
        {
            // Deletes each projectile if off screen
            foreach (ProjectileCircle p in projectiles)
            {
                if (p.x < -5)
                {
                    projectiles.Remove(p);
                    break;
                }

                if (p.x > 355)
                {
                    projectiles.Remove(p);
                    break;
                }

                if (p.y < 0)
                {
                    projectiles.Remove(p);
                    break;
                }

                if (p.y > 675)
                {
                    projectiles.Remove(p);
                    break;
                }

            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // First phase timer and Bomb timer
            attack1Timer++;
            bombTimer++;
            ranMovetime++;
            RandomMove();
            moveCheck();
            boss.Move(ranMove);
            healthLabel.Text = me.health + "";

            if (attack1Timer > 20)
            {
                projectiles.AddRange(boss.attack1());
                attack1Timer = 0;
            }

            //Checks if lives are gone
            if (me.health <= 0)
            {
                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new Gameover());
            }

            //Checks if you just died and adds to the invulnerability window if you did
            if (justDied == true)
            {
                invulTimer++;
            }

            //After a second, you are no longer invulnerable
            if (invulTimer == 3)
            {
                invulTimer = 0;
                justDied = false;
            }





            //You Win
            if (boss.health <= 0)
            {

                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new ItemGain());

            }

            //Player movement based on movement bools
            if (leftArrowDown && me.x - 8 > 0)
            {
                me.Move("left");
            }
            else if (rightArrowDown && me.x < this.Width - me.size - 10)
            {
                me.Move("right");
            }

            if (upArrowDown && me.y > 20)
            {
                me.Move("up");
            }
            else if (downArrowDown && me.y < 460 - 87 - me.size)
            {
                me.Move("down");
            }

            //Checks if you are pressing space
            if (shooting == true)
            {
                shotTimer++;
                if (shotTimer == (int)(6 - (Player.attackRate / 100)))
                {
                    StringProjectile p = new StringProjectile(me.x + me.size / 2, me.y, 20, 20, 3, 5);
                    friendProjectiles.Add(p);
                    shotTimer = 0;
                }
            }

            //Checks if you are bombing 
            if (bombing == true)
            {

                projectiles.Clear();
                bombing = false;
            }



            //Moves each projectile and checks collisions
            foreach (ProjectileCircle p in projectiles)
            {
                p.Move();

                if (justDied == false)
                {

                    if (p.Collision(me))
                    {
                        me.health -= p.damage;
                        justDied = true;
                    }
                }

            }



            //Moves your shots up and checks for collisions with boss
            foreach (StringProjectile p in friendProjectiles)
            {
                p.Move("up");
                if (p.Collision(boss))
                {
                    boss.health -= me.damage;

                    //Lifesteal code
                    if (me.health < myMaxHP)
                    {
                        me.health += (int)(me.damage * (me.lifesteal / 100));
                    }

                    if (me.health > myMaxHP)
                    {
                        me.health = myMaxHP;
                    }

                }
            }

            arrow = new Point[] { new Point(boss.x, 445), new Point(boss.xCenter, 435), new Point(boss.x + boss.width, 445) };


            Refresh();
        }

        private void GameScreencs_Load(object sender, EventArgs e)
        {

        }

        private void RandomMove()
        {


            //Moves the boss randomly on the screen
            if (ranMovetime > 100)
            {
                tempMove = random.Next(0, 4);

                if (tempMove == 0)
                {
                    ranMove = "left";
                }

                else if (tempMove == 1)
                {
                    ranMove = "right";
                }

                else if (tempMove == 2)
                {
                    ranMove = "up";
                }

                else
                {
                    ranMove = "down";
                }

                ranMovetime = 0;
            }

        }




        private void moveCheck()
        {
            //Checks if boss in the boundries and forces them the othe way
            if (boss.x < 0)
            {
                ranMove = "right";
            }

            else if (boss.y < 0)

            {
                ranMove = "down";
            }

            else if (boss.y + boss.height > 290)
            {
                ranMove = "up";
            }

            else if (boss.x + boss.width > 500)
            {
                ranMove = "left";
            }
        }



        private void GameScreencs_Paint(object sender, PaintEventArgs e)
        {

            //Shows player life
            //livesOut.Text = me.lives + "";


            // Shows Health Bar

            healthbarText = ($"{boss.health} / {maxHealth}");
            e.Graphics.FillRectangle(grayBrush, 0, 20, 650, 20);
            e.Graphics.FillRectangle(redBrush, 0, 25, (int)(boss.health * healthRatio), 10);
            e.Graphics.DrawString(healthbarText, new Font("Arial", 10), whiteBrush, 230, 20);

            //Shows Bomb
            //bombsOut.Text = bombamm + "";

            //Shows Points
            points = graze * 7 + (bombamm * 100);
            //pointsOut.Text = points + "";

            //Shows Graze
            //grazeOut.Text = graze + "";

            //Draws boss position arrow
            e.Graphics.FillPolygon(whiteBrush, arrow);

            //Draws Me
            if (justDied == true)
            {
                e.Graphics.FillEllipse(yellowBrush, me.x, me.y, me.size, me.size);
            }

            //Changes player color if not invulnerable
            else
            {
                e.Graphics.FillEllipse(redBrush, me.x, me.y, me.size, me.size);
            }


            //Show Boss
            e.Graphics.FillEllipse(yellowBrush, boss.x, boss.y, boss.height, boss.width);

            //Draws enemy projectiles
            foreach (ProjectileCircle p in projectiles)
            {
                e.Graphics.FillEllipse(blueBrush, p.x, p.y, p.size, p.size);
            }

            //Draws our shots
            foreach (StringProjectile p in friendProjectiles)
            {
                e.Graphics.FillRectangle(whiteBrush, p.x, p.y, p.width, p.height);

            }

            healthLabel.Text = me.health + "";


        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //Movement keys up
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    upArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
                case Keys.ShiftKey:
                    me.ySpeed = 5;
                    me.xSpeed = 5;
                    break;
                case Keys.Space:
                    shooting = false;
                    break;


            }
        }

    }
}
