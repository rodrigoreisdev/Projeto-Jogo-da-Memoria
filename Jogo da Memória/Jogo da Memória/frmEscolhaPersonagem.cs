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
    public partial class frmEscolhaPersonagem : Form
    {
        Personagem personagem = new Personagem();
        GameClass game = new GameClass();
        public frmEscolhaPersonagem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            //Passando o personagem Jorge para selecionar fase
            personagem.Nome = label1.Text;
            //personagem.FalaAleatoria1Jorge = //Picture box feita pelo edmar 1;     
            //personagem.FalaAleatoria2Jorge = //Picture box feita pelo edmar 2;
            //FrmSelecionarFase sf = new FrmSelecionarFase(personagem, 0, "");
            game.Nivel = 1;
            FrmSelecionarFase sf = new FrmSelecionarFase(personagem, game);
            sf.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            //Passando o personagem Jorge para selecionar fase
            personagem.Nome = label2.Text;
            //personagem.FalaAleatoria1Ivy = //Picture box feita pelo edmar 3;
            //personagem.FalaAleatoria2Ivy = //Picture box feita pelo edmar 4;
            //FrmSelecionarFase sf = new FrmSelecionarFase(personagem, 0, "");
            game.Nivel = 1;
            FrmSelecionarFase sf = new FrmSelecionarFase(personagem, game);
            sf.Show();
            this.Close();
        }
    }
}
