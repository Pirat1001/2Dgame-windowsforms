using System.Security.Cryptography.X509Certificates;

namespace _2D_game_with_windowsform
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        bool jumping = false;
        int jumpSpeed = 17;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position;
        bool isGameOver = false;
        int obstacleMargin = 100;
        int xPosition = 0;

        public Form2() => GameReset();
        
        

        private void MainGameTimer(object sender, EventArgs e)
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
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;


                    if (x.Left < -100)
                    {
                        xPosition = this.ClientSize.Width + rnd.Next(200, 500) + (x.Width * 15) + 100;

                        if (x is PictureBox && (string)x.Tag == "obstacle" && (string)x.Name == "obstacle1")
                        {
                            x.Left = xPosition;
                        }

                        if (x is PictureBox && (string)x.Tag == "obstacle" && (string)x.Name == "obstacle2")
                        {
                            x.Left = xPosition + (obstacleMargin);
                        }

                        if (x is PictureBox && (string)x.Tag == "obstacle" && (string)x.Name == "obstacle3")
                        {
                            x.Left = xPosition + (obstacleMargin * 2 + 100);
                        }


                        //                     if(x == obstacle1 && x.Left >(obstacle2.Left- obstacleMargin) && x.Left < (obstacle2.Left + obstacleMargin))
                        //                   {
                        //                        x.Left += 200;
                        //                   }
                        //                   else if(x == obstacle1 && x.Left > (obstacle3.Left - obstacleMargin) && x.Left < (obstacle3.Left + obstacleMargin))
                        //                   {
                        //                      x.Left += 200;
                        //                   }
                        //                   else if(x == obstacle2 && x.Left > (obstacle1.Left - obstacleMargin) && x.Left < (obstacle1.Left + obstacleMargin))
                        //                   {
                        //                       x.Left += 200;
                        //                   }
                        //                   else if(x == obstacle2 && x.Left > (obstacle3.Left - obstacleMargin) && x.Left < (obstacle3.Left + obstacleMargin))
                        //                   {
                        //                       x.Left += 200;
                        //                   }
                        //                   else if(x == obstacle3 && x.Left > (obstacle1.Left - obstacleMargin) && x.Left < (obstacle1.Left + obstacleMargin))
                        //                   {
                        //                       x.Left += 200;
                        //                  }
                        ///                  else if(x == obstacle3 && x.Left > (obstacle2.Left - obstacleMargin) && x.Left < (obstacle2.Left + obstacleMargin))
                        //                   {
                        //                       x.Left += 200;
                        //                   }
                        //                   else
                        //                   {
                        //                     x.Left -= 1;
                        //               }

                        //f(obstacle1.Left + 100 <= x.Left && obstacle2.Left + 100 <= x.Left && obstacle3.Left + 100 <= x.Left && obstacle1.Left - 100 >= x.Left && obstacle2.Left - 100 >= x.Left && obstacle3.Left - 100 >= x.Left)
                        //{
                        //    x.Left += 1;
                        //}
                        //else if(obstacle1.Left + 100 >= x.Left || obstacle2.Left + 100 >= x.Left || obstacle3.Left + 100 >= x.Left)
                        //{
                        //    x.Left += 100;
                        //} 
                        //else if(obstacle1.Left - 100 <= x.Left || obstacle2.Left - 100 <= x.Left || obstacle3.Left - 100 <= x.Left)
                        //{
                        //    x.Left -= 100;
                        //}

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

            foreach (Control x in this.Controls)
            {
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

                    if (x is PictureBox && (string)x.Tag == "obstacle" && (string)x.Name == "obstacle1")
                    {
                        x.Left = position;
                    }

                    if (x is PictureBox && (string)x.Tag == "obstacle" && (string)x.Name == "obstacle2")
                    {
                        x.Left = position + (obstacleMargin);
                    }

                    if (x is PictureBox && (string)x.Tag == "obstacle" && (string)x.Name == "obstacle3")
                    {
                        x.Left = position + (obstacleMargin * 2 + 100);
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "hole" && score > 20)
                {
                    position = this.ClientSize.Width + rnd.Next(500, 800) + (x.Width * 13 + 100);

                    x.Left = position;
                }
            }


            gameTimer.Start();
        }

    }
}