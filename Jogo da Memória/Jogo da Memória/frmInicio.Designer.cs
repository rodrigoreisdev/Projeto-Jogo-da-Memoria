namespace Jogo_da_Memória
{
    partial class frmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdJogar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdComoJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdJogar
            // 
            this.cmdJogar.BackColor = System.Drawing.Color.Transparent;
            this.cmdJogar.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btnjogar;
            this.cmdJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdJogar.FlatAppearance.BorderSize = 0;
            this.cmdJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdJogar.Location = new System.Drawing.Point(539, 382);
            this.cmdJogar.Name = "cmdJogar";
            this.cmdJogar.Size = new System.Drawing.Size(378, 177);
            this.cmdJogar.TabIndex = 0;
            this.cmdJogar.UseVisualStyleBackColor = false;
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.Transparent;
            this.cmdSair.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btnsair;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.FlatAppearance.BorderSize = 0;
            this.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSair.Location = new System.Drawing.Point(803, 736);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(210, 98);
            this.cmdSair.TabIndex = 1;
            this.cmdSair.UseVisualStyleBackColor = false;
            // 
            // cmdComoJogar
            // 
            this.cmdComoJogar.BackColor = System.Drawing.Color.Transparent;
            this.cmdComoJogar.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btcomojogar;
            this.cmdComoJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdComoJogar.FlatAppearance.BorderSize = 0;
            this.cmdComoJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComoJogar.Location = new System.Drawing.Point(388, 736);
            this.cmdComoJogar.Name = "cmdComoJogar";
            this.cmdComoJogar.Size = new System.Drawing.Size(210, 98);
            this.cmdComoJogar.TabIndex = 2;
            this.cmdComoJogar.UseVisualStyleBackColor = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 876);
            this.Controls.Add(this.cmdComoJogar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdJogar);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdJogar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdComoJogar;
    }
}

