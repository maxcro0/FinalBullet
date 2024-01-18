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
    public partial class Dungeon : UserControl
    {
        public static string job;
        int choseRoom;
        string[] conditions = { "none", "dark", "torch", "curse", "event", "boss", "tense" };
        List<string> newCondition = new List<string>();
        List<string> myCondition = new List<string>();
        List<string> conditions1 = new List<string>();
        List<string> conditions2 = new List<string>();
        List<string> conditions3 = new List<string>();
        List<string> conditions4 = new List<string>();
        List<string> conditions5 = new List<string>();
        List<string> conditions6 = new List<string>();

        public Dungeon()
        {
            InitializeComponent();
            DisplayCondition();

        }
        private void GenCon()
        {
            newCondition.Clear();

            Random random = new Random();
            int tempCon;
            for (int i = 0; i < 3; i++)
            {
                tempCon = random.Next(0, 7);

                if (tempCon < 3)
                {
                    conditions1.Add(conditions[0]);
                }
                else
                {
                    tempCon = random.Next(1, 7);

                    conditions1.Add(conditions[tempCon]);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                tempCon = random.Next(0, 7);

                if (tempCon < 3)
                {
                    conditions2.Add(conditions[0]);
                }
                else
                {
                    tempCon = random.Next(1, 7);

                    conditions2.Add(conditions[tempCon]);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                tempCon = random.Next(0, 7);

                if (tempCon < 3)
                {
                    conditions3.Add(conditions[0]);
                }
                else
                {
                    tempCon = random.Next(1, 7);

                    conditions3.Add(conditions[tempCon]);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                tempCon = random.Next(0, 7);

                if (tempCon < 3)
                {
                    conditions4.Add(conditions[0]);
                }
                else
                {
                    tempCon = random.Next(1, 7);

                    conditions4.Add(conditions[tempCon]);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                tempCon = random.Next(0, 7);

                if (tempCon < 3)
                {
                    conditions5.Add(conditions[0]);
                }
                else
                {
                    tempCon = random.Next(1, 7);

                    conditions5.Add(conditions[tempCon]);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                tempCon = random.Next(0, 7);

                if (tempCon < 3)
                {
                    conditions6.Add(conditions[0]);
                }
                else
                {
                    tempCon = random.Next(1, 7);

                    conditions6.Add(conditions[tempCon]);

                }
            }


        }

        private void DisplayCondition()
        {
            GenCon();

           // for (int i = 0; i < newCondition.Count; i++)
           // {
           //     left1.Text += $"{newCondition[i]} \n";
           //     conditions1.Add(newCondition[i]);
           // }

           //// GenCon();

           // for (int i = 0; i < newCondition.Count; i++)
           // {
           //     right1.Text += $"{newCondition[i]} \n";
           //     conditions2.Add(newCondition[i]);
           // }

            for (int i = 0; i < conditions1.Count; i++)
            {
                left1.Text += $"{conditions1[i]} \n";
                right1.Text += $"{conditions2[i]} \n";
                left2.Text += $"{conditions3[i]} \n";
                left3.Text += $"{conditions4[i]} \n";
                right2.Text += $"{conditions5[i]} \n";
                right3.Text += $"{conditions6[i]} \n";
            }
        }

        private void condSwitch()
        {
            choseRoom = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 6;

        }

        private void left1_Click(object sender, EventArgs e)
        {
            choseRoom = 1;

            if (conditions1.Contains("dark"))
            {
                GameScreencs.dark = true;
            }

            if (conditions1.Contains("curse"))
            {
                GameScreencs.curse = true;
            }

            if (conditions1.Contains("event"))
            {
                GameScreencs.eve = true;
            }

            if (conditions1.Contains("tense"))
            {
                GameScreencs.tense = true;
            }

            if (conditions1.Contains("torch"))
            {
                GameScreencs.torch = true;
            }

            for (int i = 0 ; i < conditions1.Count; i++)
            {
                myCondition.Add(conditions1[i]);
            }
            Form1.ChangeScreen(this, new GameScreencs());
        }
    }

}
