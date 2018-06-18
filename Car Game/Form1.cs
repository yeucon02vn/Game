using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Game
{
    public partial class Form1 : Form
    {

        int carSpeed = 5;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        bool carUp;
        bool carDown;
        int trafficSpeed = 5;
        int Score = 0;
        //int HighScore = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }



        public void Reset()
        {
            cup.Visible = false; // hide the cup image
            start.Enabled = false; // disable the button when game is running
            explosion.Visible = false; // hide the explosion image
            trafficSpeed = 5; // set the traffic back to default
            roadSpeed = 5; // set the road speed back to default
            Score = 0; // reset score to 0
            main.Left = 229; // reset main left
            main.Top = 516; // reset main top
            carLeft = false; // reset the moving left to false
            carRight = false; // reset the moving right to false
            carUp = false;
            carDown = false;
            // move the AI to default position this will be off the screen
            vatcan1.Left = 389;
            vatcan1.Top = -120;
            vatcan2.Left = 223;
            vatcan2.Top = -168;
            vatcan3.Left = 54;
            vatcan3.Top = -185;

            //reset the road to their default position
            roadTrack2.Left = 0;
            roadTrack2.Top = 0;
            roadTrack1.Left = 0;
            roadTrack1.Top = 416;

            //start the timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score++;
            distance.Text = "" + Score;
            roadTrack2.Top += roadSpeed;
            roadTrack1.Top += roadSpeed;


            if (roadTrack2.Top > 570)
            {
                roadTrack2.Top = -570;
            }
            if (roadTrack1.Top > 570)
            {
                roadTrack1.Top = -570;
            }


            if (carLeft)
            {
                main.Left -= carSpeed;
            }
            if (carRight)
            {
                main.Left += carSpeed;
            }
            if (carUp)
            {
                main.Top -= carSpeed;
            }
            if (carDown)
            {
                main.Top += carSpeed;
            }


            if (main.Left < 10)
            {
                carLeft = false;
            }
            if (main.Left + main.Width > KhungChoi.Width - 15)
            {
                carRight = false;
            }
            if (main.Top < 1)
            {
                carUp = false;
            }
            if (main.Top + main.Height > KhungChoi.Height - 10)
            {
                carDown = false;
            }


            vatcan1.Top += trafficSpeed;
            vatcan2.Top += trafficSpeed;
            vatcan3.Top += trafficSpeed;


            //respawn the AIs and change the their images
            if (vatcan1.Top > KhungChoi.Height)
            {
                DoiXe1(); // change the AI car images once they left the scene
                vatcan1.Left = rnd.Next(12, 110); // random numbers where they appear on the left
                vatcan1.Top = rnd.Next(100, 250) * -1; // random numbers where they appear on top
            }
            if (vatcan2.Top > KhungChoi.Height)
            {
                DoiXe2(); // change the AI car images once they left the scene
                vatcan2.Left = rnd.Next(172, 274); // random numbers where they appear on the left
                vatcan2.Top = rnd.Next(100, 250) * -1; // random numbers where they appear on top
            }
            if (vatcan3.Top > KhungChoi.Height)
            {
                DoiXe3(); // change the AI car images once they left the scene
                vatcan3.Left = rnd.Next(342, 432); // random numbers where they appear on the left
                vatcan3.Top = rnd.Next(100, 250) * -1; // random numbers where they appear on top
            }

            // end of respawning the AIs and image changing
            // hit test the main and AI
            //below if statement is checking multiple conditions
            // if main hits vatcan1 OR main hits vatcan2
            if (main.Bounds.IntersectsWith(vatcan1.Bounds) || main.Bounds.IntersectsWith(vatcan2.Bounds) || main.Bounds.IntersectsWith(vatcan3.Bounds))
            {
                gameOver(); // this will run when the main hits an AI object
            }
            // end of hit testing the main.
            // speed up the traffic
            // below we are checking for multiple conditions
            // if score is above 100 AND below 500
            if (Score > 100 && Score < 500)
            {
                trafficSpeed = 6;
                roadSpeed = 7;
            }
            // if score is above 500 AND below 1000
            else if (Score > 500 && Score < 1000)
            {
                trafficSpeed = 7;
                roadSpeed = 8;
            }
            // if score is above 1200
            else if (Score > 1200)
            {
                trafficSpeed = 9;
                roadSpeed = 10;
            }
            // end of the traffic speeding up
        }
       
        private void stopCar(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                carUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                carDown = false;
            }
        }

        private void gameOver()
        {
            cup.Visible = true; // change the cup to visible
            timer1.Stop(); // stop the timer
            start.Enabled = true; // enable the button so we can use it now
                                  //showing the explosion image on top of the car image
            explosion.Visible = true; // make the image visible
            main.Controls.Add(explosion); // add the explosion image on top of the main image
            explosion.Location = new Point(-8, 5); // we are moving the image so its suitably positioned
            explosion.BackColor = Color.Transparent; // change the background to transparent
            explosion.BringToFront();// bring to front of the main image
                                     // final score cup
                                     // if the main score less than a 1000 we give them a bronze
            if (Score < 1000)
            {
                cup.Image = Properties.Resources.bronze;
            }
            // if main scored more than 2000 then give them a silver
            if (Score > 2000)
            {
                cup.Image = Properties.Resources.silver;
            }
            // if main scored more than 3500 then give them a gold cup
            if (Score > 3500)
            {
                cup.Image = Properties.Resources.gold;
            }
        }
        public void DoiXe1()
        {

        }
        public void DoiXe2()
        {

        }
        public void DoiXe3()
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            Reset();
            // panel1.Enabled = false;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pause.Hide();
            play.Show();
        }

        private void play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            pause.Show();
            play.Hide();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left  && main.Left > 10)
            {
                carLeft = true;
                return true; //for the active control to see the keypress, return false
            }
            else if (keyData == Keys.Right && main.Left + main.Width < KhungChoi.Width - 15)
            {
                carRight = true;
                return true; 
            }
            else if (keyData == Keys.Up && main.Top > 0)
            {
                carUp = true;
                return true;
            }
            else if (keyData == Keys.Down && main.Top + main.Height < KhungChoi.Height - 10)
            {
                carDown = true;
                return true; 
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }


}
