﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_da_Memória
{
    public partial class GameFacil : Form
    {
        Personagem p;
        GameClass g;

        //Initialise Variables 
        Random location = new Random(); //Changes Location randomly 
        List<Point> points = new List<Point>(); // To Store Location of Images
        PictureBox FlippedImage1;
        PictureBox FlippedImage2;
        int FlippedCount = 0;
        int LevelUp = 30;
        int TimeLevel = 60;
        int Score = 0;

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.audio1);
            simpleSound.Play();
        }
        public GameFacil(Personagem p, GameClass g)
        {
            InitializeComponent();
            this.p = p;
            this.g = g;
        }

        private void GameFacil_Load(object sender, EventArgs e)
        {
            playSimpleSound();
            if (p.Nome == "Ivy")
                pbPersoagem.BackgroundImage = Properties.Resources.pers2;
            else
                pbPersoagem.BackgroundImage = Properties.Resources.pers1;

            label1.Text = "6"; //Label Displaying the time before cards are flipped to Cover mode
            foreach (PictureBox picture in GamePanel.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in GamePanel.Controls)
            {  //Randomisation of Images
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            ScoreTimer.Start();
            CountdownTimer.Start();
            img1.Image = Properties.Resources.A;
            dupimg1.Image = Properties.Resources.A;
            img2.Image = Properties.Resources.B;
            dupimg2.Image = Properties.Resources.B;
            img3.Image = Properties.Resources.C;
            dupimg3.Image = Properties.Resources.C;
            img4.Image = Properties.Resources.D;
            dupimg4.Image = Properties.Resources.D;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resetting all values
            resetButton.BackColor = Color.Transparent;
            resetButton.Text = "Recomeçar";
            ScoreCounter.Text = "0";
            timeLeft.Text = "60";
            levelValue.Text = "1";
            //Restarting the game
            GameFacil_Load(sender, e);
        }

        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            ScoreTimer.Stop();
            foreach (PictureBox picture in GamePanel.Controls)
            {   //Switching all cards back to cover mode
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.cover1;
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            //Countdown timer for image display in the beginning of the game
            int timer = Convert.ToInt32(label1.Text);
            timer -= 1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                label1.Visible = false;
                CountdownTimer.Stop();
                TimeRemaining.Start();
            }
        }

        private void TimeRemaining_Tick(object sender, EventArgs e)
        {
            //Timer to show how much time is left to complete the level
            int timer = Convert.ToInt32(timeLeft.Text);
            timer -= 1;
            timeLeft.Text = Convert.ToString(timer);
            if (timer == 50)
                persfala.BackgroundImage = Properties.Resources.ivy_voce_consegue;
            if (timer == 30)
                persfala.BackgroundImage = Properties.Resources.ivy_ainda_da_tempo;
            if (timer == 0)
            {
                TimeRemaining.Stop();
                FrmPerdeu frm = new FrmPerdeu(p, g);
                frm.Show();
                //MessageBox.Show("Pontuação: " + ScoreCounter.Text /*+ " at level : " + levelValue.Text*/);
                ScoreCounter.Text = "0";
                this.Close();
            }
        }


        private void changeLevel()
        {
            //Increment level of the game by increasing required score and decreasing Time Limit
            Score += Convert.ToInt32(ScoreCounter.Text);
            MessageBox.Show("Proximo Nivel");
            //GameMedio gameMedio = new GameMedio();
            //gameMedio.ShowDialog();
            if (Convert.ToInt32(ScoreCounter.Text) >= LevelUp)
            {
                ScoreCounter.Text = "0";
                //TimeLevel -= 5;
                //timeLeft.Text = Convert.ToString(TimeLevel);
                //levelValue.Text = Convert.ToString(Convert.ToInt32(levelValue.Text) + 1);
                //LevelUp += 5;
                //if (TimeLevel <= 15)
                //{
                //    MessageBox.Show("Thanks for Playing! You've completed the game");
                //    Application.Exit();
                //}
                GameFacil_Load(this, null);
            }
            else
            {
                MessageBox.Show("Game Over! You didn't score enough to go to the next level. Total Score -> " + Score);
                resetButton.BackColor = Color.Red;
                resetButton.Text = "Play Again?";
            }
            Close();
        }

        private void checkImages(PictureBox pic1, PictureBox pic2)
        {
            //Check if images are the same in both the PictureBoxes

            if (FlippedImage1 == null)
            {
                FlippedImage1 = pic1;
            }
            else if (FlippedImage1 != null && FlippedImage2 == null)
            {
                if (FlippedImage1 != pic1)
                    FlippedImage2 = pic1;
            }
            if (FlippedImage1 != null && FlippedImage2 != null)
            {
                if (FlippedImage1.Tag == FlippedImage2.Tag)
                {
                    FlippedImage1 = null;   //Reassigning to null for the next set of values
                    FlippedImage2 = null;   //Same as above
                    pic2.Enabled = false;   //To avoid clicking the image
                    pic1.Enabled = false;   //Same as above
                    ++FlippedCount;         //To check if the game is over by checking if all images have been flipped
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 1); //Score Increment if there is a correct match
                }
                else
                {
                    FlipTime.Start();
                   // ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 5); //Score Decrement if there is a wrong match
                }

            }
            if (FlippedCount == 2)
                persfala.BackgroundImage = Properties.Resources.quase_la_ivy;

            if (FlippedCount == 4)
            {   //if all images are flipped over then reset the count value and call changeLevel() to check and go to the next level
                FlippedCount = 0;
                //changeLevel();
                TimeRemaining.Stop();
                FrmGanhou frm = new FrmGanhou(p,g);
                frm.Show();
                this.Close();
            }
        }

        private void FlipTime_Tick(object sender, EventArgs e)
        {
            //Timer to flip back images to cover image
            FlipTime.Stop();
            FlippedImage1.Image = Properties.Resources.cover1;
            FlippedImage2.Image = Properties.Resources.cover1;
            FlippedImage1 = null;
            FlippedImage2 = null;
        }

        #region Cartas

        private void img1_Click(object sender, EventArgs e)
        {
            img1.Image = Properties.Resources.A;
            checkImages(img1, dupimg1);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            img2.Image = Properties.Resources.B;
            checkImages(img2, dupimg2);
        }

        private void img3_Click(object sender, EventArgs e)
        {
            img3.Image = Properties.Resources.C;
            checkImages(img3, dupimg3);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            img4.Image = Properties.Resources.D;
            checkImages(img4, dupimg4);
        }

        private void dupimg1_Click(object sender, EventArgs e)
        {
            dupimg1.Image = Properties.Resources.A;
            checkImages(dupimg1, img1);
        }

        private void dupimg2_Click(object sender, EventArgs e)
        {
            dupimg2.Image = Properties.Resources.B;
            checkImages(dupimg2, img2);
        }

        private void dupimg3_Click(object sender, EventArgs e)
        {
            dupimg3.Image = Properties.Resources.C;
            checkImages(dupimg3, img3);
        }

        private void dupimg4_Click(object sender, EventArgs e)
        {
            dupimg4.Image = Properties.Resources.D;
            checkImages(dupimg4, img4);
        }
        #endregion
    }
}
