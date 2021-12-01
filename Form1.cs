using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        bool point = false;
        public int move = 8;
        public Form1()
        {
            InitializeComponent();
            copter1.BringToFront();
            gravityUP.Enabled = true;
        }

        private void gravityUP_Tick(object sender, EventArgs e)
        {
            if (!copter1.Bounds.IntersectsWith(picground.Bounds))
            {
                copter1.Location = new Point(copter1.Location.X, copter1.Location.Y + move);
                
            }
        }

        private void gravityDwn_Tick(object sender, EventArgs e)
        {
            copter1.Location = new Point(copter1.Location.X, copter1.Location.Y - move);
        }

        private void movementtimer_Tick(object sender, EventArgs e)
        {
            // move the top/bottom/point boxes
            picTop.Location = new Point(picTop.Location.X - move, picTop.Location.Y);
            picBot.Location = new Point(picBot.Location.X - move, picBot.Location.Y);
            picPoint.Location = new Point(picPoint.Location.X - move, picPoint.Location.Y);

            //check and see if one of the pipes has gone off screen
            if (picBot.Location.X <= -50)
            {
                //move them back to the right
                picTop.Location = new Point(picTop.Location.X + 900, picTop.Location.Y);
                picBot.Location = new Point(picBot.Location.X + 900, picBot.Location.Y);
                picPoint.Location = new Point(picPoint.Location.X + 900, picPoint.Location.Y);
                //Reset for the round, user can get another point
                point = false;
            }
            //Check and see if the point has been collected for this round
            if (this.point == false)
            {
                //We have collided with the point picturebox, so add a pipe
                if (copter1.Bounds.IntersectsWith(picPoint.Bounds))
                {
                    // set point to true, only if get 1 point per round
                    point = true;
                    //
                    copter1.GainPoint();
                    //Displaythe point on the GUI
                    label1.Text = copter1.GetScore().ToString();
                }
            }
            //Check for intersect with any pipes
            if (copter1.Bounds.IntersectsWith(picTop.Bounds)|| copter1.Bounds.IntersectsWith(picBot.Bounds))
            {//kill off the copter
                copter1.Kill();
                gravityUP.Stop();
                gravityDwn.Stop();
                movementtimer.Stop();
                btnReset.Visible = true;
                
            }
        }

        private void gameovertimer_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(copter1.Alive())
            {
                gravityUP.Stop();
                gravityDwn.Start();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            gravityUP.Start();
            gravityDwn.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Hide the form this is bad because the process will continue to run in the background
            this.Hide();
            //Create a new form1
            Form f = new Form();
            f.Show();
        }
    }
}
