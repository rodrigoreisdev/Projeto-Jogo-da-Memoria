﻿namespace Jogo_da_Memória
{
    partial class FrmGanhou
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Mensagem = new System.Windows.Forms.PictureBox();
            this.pb_Personagem = new System.Windows.Forms.PictureBox();
            this.bt_Continuar = new System.Windows.Forms.Button();
            this.bt_Inicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mensagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Personagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pb_Mensagem);
            this.panel1.Controls.Add(this.pb_Personagem);
            this.panel1.Location = new System.Drawing.Point(491, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 286);
            this.panel1.TabIndex = 1;
            // 
            // pb_Mensagem
            // 
            this.pb_Mensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Mensagem.Location = new System.Drawing.Point(188, 45);
            this.pb_Mensagem.Name = "pb_Mensagem";
            this.pb_Mensagem.Size = new System.Drawing.Size(151, 106);
            this.pb_Mensagem.TabIndex = 1;
            this.pb_Mensagem.TabStop = false;
            // 
            // pb_Personagem
            // 
            this.pb_Personagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Personagem.Location = new System.Drawing.Point(13, 89);
            this.pb_Personagem.Name = "pb_Personagem";
            this.pb_Personagem.Size = new System.Drawing.Size(167, 165);
            this.pb_Personagem.TabIndex = 0;
            this.pb_Personagem.TabStop = false;
            // 
            // bt_Continuar
            // 
            this.bt_Continuar.BackColor = System.Drawing.Color.Turquoise;
            this.bt_Continuar.FlatAppearance.BorderSize = 0;
            this.bt_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Continuar.Font = new System.Drawing.Font("Milky Nice", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Continuar.ForeColor = System.Drawing.Color.Black;
            this.bt_Continuar.Location = new System.Drawing.Point(497, 471);
            this.bt_Continuar.Name = "bt_Continuar";
            this.bt_Continuar.Size = new System.Drawing.Size(174, 54);
            this.bt_Continuar.TabIndex = 2;
            this.bt_Continuar.Text = "Continuar";
            this.bt_Continuar.UseVisualStyleBackColor = false;
            this.bt_Continuar.Click += new System.EventHandler(this.bt_Continuar_Click);
            // 
            // bt_Inicio
            // 
            this.bt_Inicio.BackColor = System.Drawing.Color.Turquoise;
            this.bt_Inicio.FlatAppearance.BorderSize = 0;
            this.bt_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Inicio.Font = new System.Drawing.Font("Milky Nice", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Inicio.Location = new System.Drawing.Point(679, 471);
            this.bt_Inicio.Name = "bt_Inicio";
            this.bt_Inicio.Size = new System.Drawing.Size(174, 54);
            this.bt_Inicio.TabIndex = 2;
            this.bt_Inicio.Text = "Voltar";
            this.bt_Inicio.UseVisualStyleBackColor = false;
            this.bt_Inicio.Click += new System.EventHandler(this.bt_Inicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.novo_parabens;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(492, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.Turquoise;
            this.cmdSair.FlatAppearance.BorderSize = 0;
            this.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSair.Font = new System.Drawing.Font("Milky Nice", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.ForeColor = System.Drawing.Color.Black;
            this.cmdSair.Location = new System.Drawing.Point(497, 471);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(174, 54);
            this.cmdSair.TabIndex = 5;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = false;
            this.cmdSair.Visible = false;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click_1);
            // 
            // FrmGanhou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.fundoSelecionarFase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 618);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Inicio);
            this.Controls.Add(this.bt_Continuar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGanhou";
            this.Text = "FrmGanhou";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGanhou_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mensagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Personagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Mensagem;
        private System.Windows.Forms.PictureBox pb_Personagem;
        private System.Windows.Forms.Button bt_Continuar;
        private System.Windows.Forms.Button bt_Inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdSair;
    }
}