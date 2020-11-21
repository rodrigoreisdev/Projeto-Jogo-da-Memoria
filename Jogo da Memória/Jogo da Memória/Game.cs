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
    public partial class Game : Form
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

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            label1.Text = "3"; //Label Displaying the time before cards are flipped to Cover mode
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
    }
}
