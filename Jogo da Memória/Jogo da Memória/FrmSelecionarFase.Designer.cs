namespace Jogo_da_Memória
{
    partial class FrmSelecionarFase
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
            this.buttonSelecioneONivel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdFase4 = new System.Windows.Forms.Button();
            this.cmdFase3 = new System.Windows.Forms.Button();
            this.cmdFase2 = new System.Windows.Forms.Button();
            this.cmdFase1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelecioneONivel
            // 
            this.buttonSelecioneONivel.BackColor = System.Drawing.Color.Yellow;
            this.buttonSelecioneONivel.Font = new System.Drawing.Font("Milky Nice", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecioneONivel.ForeColor = System.Drawing.Color.Red;
            this.buttonSelecioneONivel.Location = new System.Drawing.Point(251, 76);
            this.buttonSelecioneONivel.Name = "buttonSelecioneONivel";
            this.buttonSelecioneONivel.Size = new System.Drawing.Size(277, 65);
            this.buttonSelecioneONivel.TabIndex = 0;
            this.buttonSelecioneONivel.Text = "Nível";
            this.buttonSelecioneONivel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.cmdFase4);
            this.panel1.Controls.Add(this.cmdFase3);
            this.panel1.Controls.Add(this.cmdFase2);
            this.panel1.Controls.Add(this.cmdFase1);
            this.panel1.Location = new System.Drawing.Point(251, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 231);
            this.panel1.TabIndex = 1;
            // 
            // cmdFase4
            // 
            this.cmdFase4.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase4.Font = new System.Drawing.Font("Milky Nice", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase4.ForeColor = System.Drawing.Color.Black;
            this.cmdFase4.Location = new System.Drawing.Point(11, 171);
            this.cmdFase4.Name = "cmdFase4";
            this.cmdFase4.Size = new System.Drawing.Size(254, 51);
            this.cmdFase4.TabIndex = 5;
            this.cmdFase4.Text = "Fase 4";
            this.cmdFase4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase4.UseVisualStyleBackColor = false;
            // 
            // cmdFase3
            // 
            this.cmdFase3.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase3.Font = new System.Drawing.Font("Milky Nice", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase3.ForeColor = System.Drawing.Color.Black;
            this.cmdFase3.Location = new System.Drawing.Point(11, 115);
            this.cmdFase3.Name = "cmdFase3";
            this.cmdFase3.Size = new System.Drawing.Size(254, 51);
            this.cmdFase3.TabIndex = 4;
            this.cmdFase3.Text = "Fase 3";
            this.cmdFase3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase3.UseVisualStyleBackColor = false;
            // 
            // cmdFase2
            // 
            this.cmdFase2.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase2.Font = new System.Drawing.Font("Milky Nice", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase2.ForeColor = System.Drawing.Color.Black;
            this.cmdFase2.Location = new System.Drawing.Point(11, 60);
            this.cmdFase2.Name = "cmdFase2";
            this.cmdFase2.Size = new System.Drawing.Size(254, 51);
            this.cmdFase2.TabIndex = 3;
            this.cmdFase2.Text = "Fase 2";
            this.cmdFase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase2.UseVisualStyleBackColor = false;
            // 
            // cmdFase1
            // 
            this.cmdFase1.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase1.Font = new System.Drawing.Font("Milky Nice", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase1.ForeColor = System.Drawing.Color.Black;
            this.cmdFase1.Location = new System.Drawing.Point(11, 6);
            this.cmdFase1.Name = "cmdFase1";
            this.cmdFase1.Size = new System.Drawing.Size(254, 51);
            this.cmdFase1.TabIndex = 2;
            this.cmdFase1.Text = "Fase 1";
            this.cmdFase1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase1.UseVisualStyleBackColor = false;
            // 
            // FrmSelecionarFase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.fundoSelecionarFase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSelecioneONivel);
            this.Name = "FrmSelecionarFase";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelecioneONivel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdFase4;
        private System.Windows.Forms.Button cmdFase3;
        private System.Windows.Forms.Button cmdFase2;
        private System.Windows.Forms.Button cmdFase1;
    }
}