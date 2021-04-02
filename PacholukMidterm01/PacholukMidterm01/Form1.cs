using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Alex Pacholuk
//3-27-21

//This program simulates flying through an asteroid field.
//It speeds up as time goes on and stores the high score
//in a txt file. Score is related to time alive.
//The goal is to create a simple game that works with 
//txt files to read and write high scores.
//Use the arrow keys to move left and right.
//the app uses the timer tool for updating position and score.
//
namespace PacholukMidterm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameOverLabel.Visible = false;
            restartButton.Visible = false;
            quitButton.Visible = false;

        }

        //txt file path
        //CHANGE THIS BEFORE RUNNING ON DIFFERENT SYSTEM
        string fileName = "D:/VisualStudioProjects/Midterm/PacholukMidterm01/HighScore.txt";

        //asteroid speed
        int asteroidSpeed = 1;

        //time & score
        int ticks = 0;

        //timer for moving on screen elements
        private void timer1_Tick(object sender, EventArgs e)
        {
            //add to ticks
            ticks += 1;

            //if ticks is multiple of 1000
            if(ticks==1000||ticks==2000||ticks==3000||ticks==4000||ticks==5000)
            {
                asteroidSpeed += 1;
            }
            else if(ticks==6000||ticks==7000||ticks==8000||ticks==9000||ticks==10000)
            {
                asteroidSpeed += 2;
            }

            //Store highest time in text file &
            //Also speed up game everytime 
            asteroid(asteroidSpeed);

            //update score
            scoreLabel.Text = "SCORE: " + ticks;

            //check for game over
            gameOver();

            if (gameOverLabel.Visible == true)
            {
                //if new high score is true
                if (newHighScore(fileName) == true)
                {
                    replaceHighScore(fileName, ticks);
                }
            }
        }



        //replaces high score in txt file
        private void replaceHighScore(string fileName, int ticks)
        {
            //display new high score
            hiScoreLabel.Text = "HIGH SCORE: " + ticks.ToString();

            //rewrite txt file with new score
            File.WriteAllText(fileName, ticks.ToString());
        }


        //checks for new high score
        private Boolean newHighScore(string fileName)
        {
            try
            {
                string oldScore = File.ReadAllText(fileName);

                if (ticks > int.Parse(oldScore))
                {
                    return true;
                }
                else
                {
                    hiScoreLabel.Text = "HIGH SCORE: " + oldScore;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file");
                return false;
            }
        }


        //Move asteroids
        private void asteroid(int asteroidSpeed)
        {
            //new random
            Random rnd = new Random();

            //move asteroid 1 if below screen
            if (asteroid01.Top >= 600)
            {
                //bring asteroid to top and randomly place along x axis
                asteroid01.Top = 0;
                asteroid01.Left = rnd.Next(0, 480);
            }
            else
            {
                asteroid01.Top += asteroidSpeed;
            }

            //move asteroid 2 if below screen
            if (asteroid02.Top >= 600)
            {
                //bring asteroid to top and randomly place along x axis
                asteroid02.Top = 0;
                asteroid02.Left = rnd.Next(0, 480);
            }
            else
            {
                asteroid02.Top += asteroidSpeed;
            }

            //move asteroid 3 if below screen
            if (asteroid03.Top >= 600)
            {
                //bring asteroid to top and randomly place along x axis
                asteroid03.Top = 0;
                asteroid03.Left = rnd.Next(0, 480);
            }
            else
            {
                asteroid03.Top += asteroidSpeed;
            }

        }



        //Key down event
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveLength = 10;
            int frameMin = 0;
            int frameMax = 500;
            //if left key down
            if (e.KeyCode == Keys.Left)
            {
                //if inbounds
                if (ufo.Left > frameMin)
                {
                    //move left by moveLength
                    ufo.Left += -moveLength;
                }
            }
            //if right key down
            if (e.KeyCode == Keys.Right)
            {
                //if inbounds
                if (ufo.Right < (frameMax-20))
                {
                    //move rigth by moveLength
                    ufo.Left += moveLength;
                }
            }
        }

        //Game Over
        private void gameOver()
        {
            //if ufo intersects with asteroid
            if (ufo.Bounds.IntersectsWith(asteroid01.Bounds)
                ||ufo.Bounds.IntersectsWith(asteroid02.Bounds)
                ||ufo.Bounds.IntersectsWith(asteroid03.Bounds))
            {

                //make game over labels/buttons visible
                gameOverLabel.Visible = true;
                hiScoreLabel.Visible = true;
                restartButton.Visible = true;
                quitButton.Visible = true;
                timer1.Enabled = false;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //close game
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            //Restart game
            Application.Restart();
        }
    }
}
