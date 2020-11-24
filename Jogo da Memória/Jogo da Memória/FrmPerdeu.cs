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
    public partial class FrmPerdeu : Form
    {
        Personagem p;
        GameClass g;
        public FrmPerdeu(Personagem p, GameClass g)
        {
            InitializeComponent();
            this.p = p;
            this.g = g;
        }

        private void FrmPerdeu_Load(object sender, EventArgs e)
        {
            if (p.Nome == "Ivy")
            {
                pb_Personagem.BackgroundImage = Properties.Resources.pers2;   //Atribuindo no picture box do personagem a foto da ivy
                pb_Mensagem.BackgroundImage = Properties.Resources.masquepena;           //Nome da foto da fala da ivy pra quando perdeu
            }
            else
            {
                pb_Personagem.BackgroundImage = Properties.Resources.pers1;   //Atribuindo no picture box do personagem a foto do Jorgão
                pb_Mensagem.BackgroundImage = Properties.Resources.masquepena;           //Nome da foto da fala do jorge pra quando perdeu
            }
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            FrmSelecionarFase proximo = new FrmSelecionarFase(p, g);
            proximo.ShowDialog();
            Close();
        }
    }
}
