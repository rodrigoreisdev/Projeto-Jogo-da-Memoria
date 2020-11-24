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
    public partial class frmInicio : Form
    {
        //frmComoJogar cj;
        frmEscolhaPersonagem ep;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdComoJogar_Click(object sender, EventArgs e) {
            //cj = new frmComoJogar();
        }

        private void cmdJogar_Click(object sender, EventArgs e) {
            //GameFacil gameizi = new GameFacil();
            //gameizi.ShowDialog();
            ep = new frmEscolhaPersonagem();
            ep.ShowDialog();
        }
    }
}
