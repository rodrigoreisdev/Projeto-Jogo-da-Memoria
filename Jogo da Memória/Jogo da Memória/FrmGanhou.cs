﻿using System;
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
        Personagem p;
        GameClass g;
        public FrmGanhou(Personagem p, GameClass g)
        {
            InitializeComponent();
            this.p = p;
            this.g = g;
        }

        private void FrmGanhou_Load(object sender, EventArgs e)
        {
            g.Nivel++;
            if (p.Nome == "Ivy")
            {
                pb_Personagem.BackgroundImage = Properties.Resources.pers2;   //Atribuindo no picture box do personagem a foto da ivy
                pb_Mensagem.BackgroundImage = Properties.Resources.venceu;           //Nome da foto da fala da ivy pra quando ganhou
            }
            else
            {
                pb_Personagem.BackgroundImage = Properties.Resources.pers1;   //Atribuindo no picture box do personagem a foto do Jorgão
                pb_Mensagem.BackgroundImage = Properties.Resources.venceu;           //Nome da foto da fala do jorge pra quando ganhar
            }
            if (g.Nivel == 4)
            {
                bt_Continuar.Visible = false;
                bt_Continuar.Enabled = false;
                cmdSair.Visible = true;
                bt_Inicio.Visible = false;

            }
        }

        private void bt_Continuar_Click(object sender, EventArgs e)
        {
            if(g.Nivel==2)
            {
                GameMedio frm = new GameMedio(p,g);
                frm.Show();
                this.Close();
            }
            if (g.Nivel == 3)
            {
                GameDificil frm = new GameDificil(p,g);
                frm.Show();
                this.Close();

            }

        }

        private void bt_Inicio_Click(object sender, EventArgs e)
        {
            FrmSelecionarFase proximo = new FrmSelecionarFase(p, g);
            proximo.Show();
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Close();
        }

        private void cmdSair_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
