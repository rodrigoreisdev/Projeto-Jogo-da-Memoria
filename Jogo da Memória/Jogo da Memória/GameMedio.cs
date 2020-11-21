using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória
{
    public partial class GameMedio : Form
    {
        //Initialise Variables 
        Random location = new Random(); //Changes Location randomly 
        List<Point> points = new List<Point>(); // To Store Location of Images
        PictureBox FlippedImage1;
        PictureBox FlippedImage2;
        int FlippedCount = 0;
        int LevelUp = 30;
        int TimeLevel = 60;
        int Score = 0;

        public GameMedio()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
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
            img1.Image = Properties.Resources.img1;
            dupimg1.Image = Properties.Resources.img1;
            img2.Image = Properties.Resources.img2;
            dupimg2.Image = Properties.Resources.img2;
            img3.Image = Properties.Resources.img3;
            dupimg3.Image = Properties.Resources.img3;
            img4.Image = Properties.Resources.img4;
            dupimg4.Image = Properties.Resources.img4;
            img5.Image = Properties.Resources.img5;
            dupimg5.Image = Properties.Resources.img5;
            img6.Image = Properties.Resources.img6;
            dupimg6.Image = Properties.Resources.img6; 
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resetting all values
            resetButton.BackColor = Color.Transparent;
            resetButton.Text = "Play Again";
            ScoreCounter.Text = "0";
            timeLeft.Text = "60";
            levelValue.Text = "1";
            //Restarting the game
            Game_Load(sender, e);
        }

        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            ScoreTimer.Stop();
            foreach (PictureBox picture in GamePanel.Controls)
            {   //Switching all cards back to cover mode
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.cover;
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
            if (timer == 0)
            {
                TimeRemaining.Stop();
                MessageBox.Show("You Scored " + ScoreCounter.Text + " at level : " + levelValue.Text);
                ScoreCounter.Text = "0";
                resetButton.BackColor = Color.Red;
                resetButton.Text = "Play Again?";
            }
        }

        private void changeLevel()
        {
            //Increment level of the game by increasing required score and decreasing Time Limit
            Score += Convert.ToInt32(ScoreCounter.Text);
            MessageBox.Show("Next Level!");
            GameDificil gameDificil = new GameDificil();
            gameDificil.ShowDialog();
            if (Convert.ToInt32(ScoreCounter.Text) >= LevelUp)
            {
                ScoreCounter.Text = "0";
                TimeLevel -= 5;
                timeLeft.Text = Convert.ToString(TimeLevel);
                levelValue.Text = Convert.ToString(Convert.ToInt32(levelValue.Text) + 1);
                LevelUp += 5;
                if (TimeLevel <= 15)
                {
                    MessageBox.Show("Thanks for Playing! You've completed the game");
                    Application.Exit();
                }
                Game_Load(this, null);
            }
            else
            {
                MessageBox.Show("Game Over! You didn't score enough to go to the next level. Total Score -> " + Score);
                resetButton.BackColor = Color.Red;
                resetButton.Text = "Play Again?";
            }
            Close();
        }

        #region Cartas
        private void img1_Click(object sender, EventArgs e)
        {
            img1.Image = Properties.Resources.img1;
            checkImages(img1, dupimg1);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            img2.Image = Properties.Resources.img2;
            checkImages(img2, dupimg2);
        }

        private void img3_Click(object sender, EventArgs e)
        {
            img3.Image = Properties.Resources.img3;
            checkImages(img3, dupimg3);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            img4.Image = Properties.Resources.img4;
            checkImages(img4, dupimg4);
        }

        private void img5_Click(object sender, EventArgs e)
        {
            img5.Image = Properties.Resources.img5;
            checkImages(img5, dupimg5);
        }

        private void img6_Click(object sender, EventArgs e)
        {
            img6.Image = Properties.Resources.img6;
            checkImages(img6, dupimg6);
        }

        private void dupimg1_Click(object sender, EventArgs e)
        {
            dupimg1.Image = Properties.Resources.img1;
            checkImages(dupimg1, img1);
        }

        private void dupimg2_Click(object sender, EventArgs e)
        {
            dupimg2.Image = Properties.Resources.img2;
            checkImages(dupimg2, img2);
        }

        private void dupimg3_Click(object sender, EventArgs e)
        {
            dupimg3.Image = Properties.Resources.img3;
            checkImages(dupimg3, img3);
        }

        private void dupimg4_Click(object sender, EventArgs e)
        {
            dupimg4.Image = Properties.Resources.img4;
            checkImages(dupimg4, img4);
        }

        private void dupimg5_Click(object sender, EventArgs e)
        {
            dupimg5.Image = Properties.Resources.img5;
            checkImages(dupimg5, img5);
        }

        private void dupimg6_Click(object sender, EventArgs e)
        {
            dupimg6.Image = Properties.Resources.img6;
            checkImages(dupimg6, img6);
        }
        #endregion

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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10); //Score Increment if there is a correct match
                }
                else
                {
                    FlipTime.Start();
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 5); //Score Decrement if there is a wrong match
                }

            }

            if (FlippedCount == 6)
            {   //if all images are flipped over then reset the count value and call changeLevel() to check and go to the next level
                FlippedCount = 0;
                changeLevel();
            }
        }

        private void FlipTime_Tick(object sender, EventArgs e)
        {
            //Timer to flip back images to cover image
            FlipTime.Stop();
            FlippedImage1.Image = Properties.Resources.cover;
            FlippedImage2.Image = Properties.Resources.cover;
            FlippedImage1 = null;
            FlippedImage2 = null;
        }
    }
}
