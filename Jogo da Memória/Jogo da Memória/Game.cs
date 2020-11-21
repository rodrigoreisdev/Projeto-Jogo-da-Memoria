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
        //Inicializando Variaveis
        Random location = new Random();
        List<Point> points = new List<Point>();
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
            label1.Text = "3";

            foreach (PictureBox picture in GamePanel.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }

            foreach (PictureBox picture in GamePanel.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            ScoreTimer.Start();
            CountdownTimer.Start();
            img1.Image =  ;
        }
    }
}
