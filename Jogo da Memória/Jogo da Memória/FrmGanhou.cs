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
    public partial class FrmGanhou : Form
    {
        Personagem aux;
        public FrmGanhou(Personagem personagem, string Dificuldade)
        {
            InitializeComponent();
            this.aux = personagem;
            this.DificuldadeGlobal = Dificuldade;
        }

        private void FrmGanhou_Load(object sender, EventArgs e)
        {
            if (aux.Nome == "Ivy")
            {
                pb_Personagem.Image = Properties.Resources.pers2;   //Atribuindo no picture box do personagem a foto da ivy
                pb_Mensagem.Image = Properties.Resources.           //Nome da foto da fala da ivy pra quando ganhou
            }
            else
            {
                pb_Personagem.Image = Properties.Resources.pers1;   //Atribuindo no picture box do personagem a foto do Jorgão
                pb_Mensagem.Image = Properties.Resources.           //Nome da foto da fala do jorge pra quando ganhar
            }
        }

        private void bt_Continuar_Click(object sender, EventArgs e)
        {
            FrmSelecionarFase proximo = new FrmSelecionarFase(aux,null,DificuldadeGlobal);
            proximo.ShowDialog();
            Close();
        }

        private void bt_Inicio_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
        }
    }
}
