using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity; 
            pipeFloor.Left -= pipeSpeed;
            pipeFloor2.Left -= pipeSpeed;
            pipUp.Left -= pipeSpeed; 
            scoreLB.Text = "Score: " + score; 

            if (pipeFloor.Left < -150)
            {
                pipeFloor.Left = 800;
                score++;
            }
            
            if (pipeFloor2.Left < -150)
            {
                pipeFloor2.Left = 800;
                score++;
            }
            if (pipUp.Left < -180)
            {
                pipUp.Left = 950;
                score++;
            }

            if (bird.Bounds.IntersectsWith(pipeFloor.Bounds) || bird.Bounds.IntersectsWith(pipeFloor2.Bounds) ||
                bird.Bounds.IntersectsWith(pipUp.Bounds) ||
                bird.Bounds.IntersectsWith(floor.Bounds) || bird.Top < -25
                )
            {
                endGame();
            }


         
            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                
                gravity = -5;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            
            gameTimer.Stop();
            scoreLB.Text += " Game over!!!"; 
        }

        private void scoreLB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
