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
        


        }
    }
}
