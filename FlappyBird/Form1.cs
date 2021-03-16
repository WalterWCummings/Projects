using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvt(object sender, EventArgs e)
        {
            FlappyBirdChar.Top += gravity;
            pipeup.Left -= pipeSpeed;
            pipedown.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeup.Left < -150)
            {
                pipeup.Left = 800;
                score++;
            }
            if (pipedown.Left < -180)
            {
                pipedown.Left = 950;
                score++;
            }

            if (FlappyBirdChar.Bounds.IntersectsWith(pipeup.Bounds) || 
                FlappyBirdChar.Bounds.IntersectsWith(pipedown.Bounds) ||
                FlappyBirdChar.Bounds.IntersectsWith(Ground.Bounds) || FlappyBirdChar.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }

           
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!";
            

        }
       

      
    }
}  
