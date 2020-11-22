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
        Personagem aux;
        public FrmPerdeu(Personagem personagem, string Dificuldade)
        {
            InitializeComponent();
            this.DificuldadeGlobal = Dificuldade;
            this.aux = personagem;
        }
        private void FrmPerdeu_Load(object sender, EventArgs e)
        {
            if (aux.Nome == "Ivy")
            {
                pb_Personagem.Image = Properties.Resources.pers2;   //Atribuindo no picture box do personagem a foto da ivy
                pb_Mensagem.Image = Properties.Resources.           //Nome da foto da fala da ivy pra quando perdeu
            }
            else
            {
                pb_Personagem.Image = Properties.Resources.pers1;   //Atribuindo no picture box do personagem a foto do Jorgão
                pb_Mensagem.Image = Properties.Resources.           //Nome da foto da fala do jorge pra quando perdeu
            }
        }


        private void bt_Menu_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
        }

        private void bt_Retry_Click(object sender, EventArgs e)
        {
            FrmSelecionarFase selecionarFase = new FrmSelecionarFase(aux, null, DificuldadeGlobal);
            selecionarFase.ShowDialog();
            Close();
        }
    }
}
