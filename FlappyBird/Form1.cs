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
        int gravity = 15;
        int score = 0;



        public Form1()

        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GaneTimeEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;  
            scoreText.Text = "Score" + score;


            if (pipeBottom.Left < -60)
            {
                pipeBottom.Left = 500;
                score++;
                if ((score % 2) == 0)
                {
                    pipeSpeed++;
                }
                
            }
            if (pipeTop.Left < -60)
            {
                pipeTop.Left = 500;
            }

            

            if (FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || 
                FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
                FlappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endgame();
            }

            if (FlappyBird.Top < -150)
            {
                endgame();
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endgame()
        {
            gameTimer.Stop();
            scoreText.Text += "fim de jogo!";
        }

    }

}
