using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Dgame_Windowsforms_WEUWEB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        Random rnd = new Random();
        bool jumping = false;
        int jumpSpeed = 17;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position;
        bool isGameOver = false;

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -30;
                force -= 2;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (player.Top > 325 && jumping == false)
            {
                force = 12;
                player.Top = 326;
                jumpSpeed = 0;
            }

            if (score >= 10)
            {
                obstacleSpeed = 20;
            }
            else if (score >= 50)
            {
                obstacleSpeed = 25;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle" && score > -1)
                {
                    x.Left -= obstacleSpeed;


                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 500) + (x.Width * 15) + 100;

                        score++;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        txtScore.Text += " Press R to restart the game! ";
                        isGameOver = true;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "hole" && score > 20)
                {
                    x.Enabled = true;
                    x.Visible = true;
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 500) + (x.Width * 20);
                        score++;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        txtScore.Text += " Press R to restart the game! ";
                        isGameOver = true;
                    }
                }
            }

        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 20;
            txtScore.Text = "Score: " + score;
            player.Image = Properties.Resources.tumblr_mafg8kpjQZ1rfjowdo1_r1_500;
            isGameOver = false;
            player.Top = 326;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rnd.Next(500, 800) + (x.Width * 10 + 100);

                    x.Left = position;
                }
            }


            gameTimer.Start();
        }

    }

}
