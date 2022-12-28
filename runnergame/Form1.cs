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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MyGameInterval(object sender, EventArgs e)
        {


        }

        private void downKey(object sender, KeyEventArgs e)
        {

        }

        private void upKey(object sender, KeyEventArgs e)
        {

        }

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
            foreach (Control x in this.Controls) {

                if (x is PictureBox && (string)x.Tag == "obstacle") {

                    currentposition = this.ClientSize.Width + rand.Next(10, 10) + (x.Width * 1);

                    x.Left = currentposition; 
                
                }
            }

           

        }
    }
}
