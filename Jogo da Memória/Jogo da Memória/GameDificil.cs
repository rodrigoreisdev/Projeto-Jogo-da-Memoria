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
    public partial class GameDificil : Form
    {
        Personagem p;
        GameClass g;
        public GameDificil(Personagem p, GameClass g)
        {
            InitializeComponent();
            this.p = p;
            this.g = g;
        }

        //Initialise Variables 
        Random location = new Random(); //Changes Location randomly 
        List<Point> points = new List<Point>(); // To Store Location of Images
        PictureBox FlippedImage1;
        PictureBox FlippedImage2;
        int FlippedCount = 0;
        int LevelUp = 20;
        int TimeLevel = 60;
        int Score = 0;

        private void GameDificil_Load(object sender, EventArgs e)
        {
            if (p.Nome == "Ivy")
                pbPersonagem.BackgroundImage = Properties.Resources.pers2;
            else
                pbPersonagem.BackgroundImage = Properties.Resources.pers1;

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
            img1.Image = Properties.Resources.L;
            dupimg1.Image = Properties.Resources.L;
            img2.Image = Properties.Resources.M;
            dupimg2.Image = Properties.Resources.M;
            img3.Image = Properties.Resources.O;
            dupimg3.Image = Properties.Resources.O;
            img4.Image = Properties.Resources.Q;
            dupimg4.Image = Properties.Resources.Q;
            img5.Image = Properties.Resources.R;
            dupimg5.Image = Properties.Resources.R;
            img6.Image = Properties.Resources.S;
            dupimg6.Image = Properties.Resources.S;
            img7.Image = Properties.Resources.T;
            dupimg7.Image = Properties.Resources.T;
            img8.Image = Properties.Resources.U;
            dupimg8.Image = Properties.Resources.U;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resetting all values
            resetButton.BackColor = Color.Transparent;
            resetButton.Text = "Recomeçar";
            ScoreCounter.Text = "0";
            timeLeft.Text = "60";
            levelValue.Text = "3";
            //Restarting the game
            GameDificil_Load(sender, e);
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

        private void changeLevel()
        {
            //Increment level of the game by increasing required score and decreasing Time Limit
            Score += Convert.ToInt32(ScoreCounter.Text);
            MessageBox.Show("Proximo Nivel");
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
                GameDificil_Load(this, null);
            }
            else
            {
                MessageBox.Show("Game Over! You didn't score enough to go to the next level. Total Score -> " + Score);
                resetButton.BackColor = Color.Red;
                resetButton.Text = "Recomeçar";
            }
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
                    //ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 5); //Score Decrement if there is a wrong match
                }

            }

            if (FlippedCount == 8)
            {   //if all images are flipped over then reset the count value and call changeLevel() to check and go to the next level
                FlippedCount = 0;
                //changeLevel();
                TimeRemaining.Stop();
                FrmGanhou frm = new FrmGanhou(p, g);
                frm.ShowDialog();
            }
        }

        #region Cartas

        private void img1_Click(object sender, EventArgs e)
        {
            img1.Image = Properties.Resources.L;
            checkImages(img1, dupimg1);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            img2.Image = Properties.Resources.M;
            checkImages(img2, dupimg2);
        }

        private void img3_Click(object sender, EventArgs e)
        {
            img3.Image = Properties.Resources.O;
            checkImages(img3, dupimg3);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            img4.Image = Properties.Resources.Q;
            checkImages(img4, dupimg4);
        }

        private void img5_Click(object sender, EventArgs e)
        {
            img5.Image = Properties.Resources.R;
            checkImages(img5, dupimg5);
        }

        private void img6_Click(object sender, EventArgs e)
        {
            img6.Image = Properties.Resources.S;
            checkImages(img6, dupimg6);
        }

        private void img7_Click(object sender, EventArgs e)
        {
            img7.Image = Properties.Resources.T;
            checkImages(img7, dupimg7);
        }

        private void img8_Click(object sender, EventArgs e)
        {
            img8.Image = Properties.Resources.U;
            checkImages(img8, dupimg8);
        }

        private void dupimg1_Click(object sender, EventArgs e)
        {
            dupimg1.Image = Properties.Resources.L;
            checkImages(dupimg1, img1);
        }

        private void dupimg2_Click(object sender, EventArgs e)
        {
            dupimg2.Image = Properties.Resources.M;
            checkImages(dupimg2, img2);
        }

        private void dupimg3_Click(object sender, EventArgs e)
        {
            dupimg3.Image = Properties.Resources.O;
            checkImages(dupimg3, img3);
        }

        private void dupimg4_Click(object sender, EventArgs e)
        {
            dupimg4.Image = Properties.Resources.Q;
            checkImages(dupimg4, img4);
        }

        private void dupimg5_Click(object sender, EventArgs e)
        {
            dupimg5.Image = Properties.Resources.R;
            checkImages(dupimg5, img5);
        }

        private void dupimg6_Click(object sender, EventArgs e)
        {
            dupimg6.Image = Properties.Resources.S;
            checkImages(dupimg6, img6);
        }

        private void dupimg7_Click(object sender, EventArgs e)
        {
            dupimg7.Image = Properties.Resources.T;
            checkImages(dupimg7, img7);
        }

        private void dupimg8_Click(object sender, EventArgs e)
        {
            dupimg8.Image = Properties.Resources.U;
            checkImages(dupimg8, img8);
        }

        #endregion

        private void TimeRemaining_Tick(object sender, EventArgs e)
        {
            //Timer to show how much time is left to complete the level
            int timer = Convert.ToInt32(timeLeft.Text);
            timer -= 1;
            timeLeft.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                TimeRemaining.Stop();
                FrmPerdeu frm = new FrmPerdeu(p, g);
                frm.ShowDialog();
                //MessageBox.Show("Sua Pontuação " + ScoreCounter.Text /*+ " at level : " + levelValue.Text*/);
                ScoreCounter.Text = "0";
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
    }
}
