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
    public partial class FrmSelecionarFase : Form
    {
        //Personagem aux;
        //public string DificuldadeGlobal ;
        Personagem p;
        GameClass g;

        //public FrmSelecionarFase(Personagem personagem , string tempo , string dificuldade)
        //{
        //    InitializeComponent();
        //    this.aux = personagem;
        //    this.DificuldadeGlobal = dificuldade;
        //}

        public FrmSelecionarFase(Personagem p, GameClass g)
        {
            InitializeComponent();
            this.p = p;
            this.g = g;

        }

        private void FrmSelecionarFase_Load(object sender, EventArgs e)
        {
            if (g.Nivel == 1)
            {
                cmdFase1.Enabled = true;
                pb1.Visible = false;
            }
            if (g.Nivel == 2)
            {
                cmdFase1.Enabled = true;
                cmdFase2.Enabled = true;
                pb1.Visible = false;
                pb2.Visible = false;
            }
            if (g.Nivel == 3)
            {
                cmdFase1.Enabled = true;
                cmdFase2.Enabled = true;
                cmdFase3.Enabled = true;
                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
            }
            if (g.Nivel == 4)
            {
                cmdFase1.Enabled = true;
                cmdFase2.Enabled = true;
                cmdFase3.Enabled = true;
                cmdFase4.Enabled = true;
                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
                pb4.Visible = false;
            }

        }

        private void cmdFase1_Click(object sender, EventArgs e)
        {

            GameFacil frm = new GameFacil(p, g);
            frm.Show();
            this.Close();

        }

        private void cmdFase2_Click(object sender, EventArgs e)
        {
            //GameMedio frm = new GameMedio(p, g);
            //frm.Show();
            //this.Close();
        }

        private void cmdFase3_Click(object sender, EventArgs e)
        {
            //GameDificil frm = new GameDificil(p, g);
            //frm.Show();
            //this.Close();
        }

        private void cmdFase4_Click(object sender, EventArgs e)
        {
            //Game game = new Game(aux, 50, hard);
            //game.ShowDialog();
            //Close();
        }
    }
}
