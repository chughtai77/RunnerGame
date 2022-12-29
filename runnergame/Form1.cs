using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runnergame
{
    public partial class Form1 : Form
    {


        bool jump = false;
        int jumpspeed;
        int force = 12;
        int score = 0;
        int obstaclespeed = 10;
        int cloudspeed = 10;
         Random rand = new Random();
        int currentposition;
        bool isGameOver = false;


        public Form1()
        {
            InitializeComponent();

            GamePlayAgain();
        }


        //This is main game where all instruction of game will be writtn here.
        //about jump of character and translate animation of objects (cars) and score and
        //restart game also call here.
        private void MyGameInterval(object sender, EventArgs e)
        {

            trex.Top += jumpspeed;

            txtScore.Text = "Score: " + score;

            if (jump == true && force < 0) {
            
                jump = false;
            }

            if (jump == true)
            {

                jumpspeed = -35;
                force -= 10;
            }
            else {
                jumpspeed = 12;
            }

            if (trex.Top > 303 && jump == false) {
                force = 32;
                trex.Top = 304;
                jumpspeed= 0;
            }

        }

        private void downKey(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space && jump == false) {

                jump = true;
            }

        }

        private void upKey(object sender, KeyEventArgs e)
        {
            if (jump == true)
            {
                jump = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true) {
                GamePlayAgain();
            }
        }


        // when we need to reset the game we call this function to play again  
        private void GamePlayAgain() {

            force = 12;
            jumpspeed = 0; 
            jump= false;
            score = 0;
            obstaclespeed= 10;
            txtScore.Text = "Score: "+ score;
            trex.Image = Properties.Resources.sonic2c;
            isGameOver= false;
            trex.Top = 304;



              //Setting the position of cars (Obstacles) out
              //    of the frame so when game start it will move farwad to the charachter

            //At this stage this is not accurate we will check after translate from right to left these car
            foreach (Control x in this.Controls) {

                if (x is PictureBox && (string)x.Tag == "obstacle") {

                   currentposition = this.ClientSize.Width + rand.Next(10, 10) + (x.Width * 1);

                    x.Left = currentposition; 
                
                }
            }
            gameTimer.Start();
           

        }
    }
}
