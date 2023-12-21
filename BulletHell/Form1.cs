﻿/// Author: Maxwell Croft
/// Purpose : To (hopefully) make a hard bullethell game
/// Date: 2023, 11, 16



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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //open menu screen when the program starts
            ChangeScreen(this, new Menu());
        }

        /// <summary>
        /// Opens a new screen and closes previous screen if one exists
        /// </summary>
        /// <param name="sender">Either the form or a UserControl: (this)</param>
        /// <param name="next">The UserControl to open: new UserControl()</param>
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender
                f = current.FindForm();                     //find Form UserControl is on
                f.Controls.Remove(current);                 //remove current UserControl
            }

            // add the new UserControl to the middle of the screen and focus on it
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
