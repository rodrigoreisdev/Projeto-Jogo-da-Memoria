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
        Personagem aux;
        public string DificuldadeGlobal ;
        public FrmSelecionarFase(Personagem personagem , string tempo , string dificuldade)
        {
            InitializeComponent();
            this.aux = personagem;
            this.DificuldadeGlobal = dificuldade;
        }

        private void FrmSelecionarFase_Load(object sender, EventArgs e)
        {
            if (DificuldadeGlobal == facil)
            {
                cmdFase1.Enabled = true;
            }
            if(DificuldadeGlobal == medio)
            {
                cmdFase1.Enabled = true;
                cmdFase2.Enabled = true;
            }
            if(DificuldadeGlobal == dificil)
            {
                cmdFase1.Enabled = true;
                cmdFase2.Enabled = true;
                cmdFase3.Enabled = true;
            }
            if(DificuldadeGlobal == hard)
            {
                cmdFase1.Enabled = true;
                cmdFase2.Enabled = true;
                cmdFase3.Enabled = true;
                cmdFase4.Enabled = true;
            }

        }

        private void cmdFase1_Click(object sender, EventArgs e)
        {
            
            Game game = new Game(aux, 60, facil);
            game.ShowDialog();
            Close();

        }

        private void cmdFase2_Click(object sender, EventArgs e)
        {
            Game game = new Game(aux, 30, media);
            game.ShowDialog();
            Close();
        }

        private void cmdFase3_Click(object sender, EventArgs e)
        {
            Game game = new Game(aux, 100, dificil);
            game.ShowDialog();
            Close();
        }

        private void cmdFase4_Click(object sender, EventArgs e)
        {
            Game game = new Game(aux, 50, hard);
            game.ShowDialog();
            Close();
        }
    }
}
