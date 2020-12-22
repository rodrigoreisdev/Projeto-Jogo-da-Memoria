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
            this.cmdCreditos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdJogar
            // 
            this.cmdJogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdJogar.BackColor = System.Drawing.Color.Transparent;
            this.cmdJogar.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btnjogar;
            this.cmdJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdJogar.FlatAppearance.BorderSize = 0;
            this.cmdJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdJogar.Location = new System.Drawing.Point(292, 253);
            this.cmdJogar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdJogar.Name = "cmdJogar";
            this.cmdJogar.Size = new System.Drawing.Size(252, 115);
            this.cmdJogar.TabIndex = 0;
            this.cmdJogar.UseVisualStyleBackColor = false;
            this.cmdJogar.Click += new System.EventHandler(this.cmdJogar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSair.BackColor = System.Drawing.Color.Transparent;
            this.cmdSair.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btnsair;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.FlatAppearance.BorderSize = 0;
            this.cmdSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSair.Location = new System.Drawing.Point(665, 467);
            this.cmdSair.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(166, 81);
            this.cmdSair.TabIndex = 1;
            this.cmdSair.UseVisualStyleBackColor = false;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdComoJogar
            // 
            this.cmdComoJogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdComoJogar.BackColor = System.Drawing.Color.Transparent;
            this.cmdComoJogar.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btcomojogar;
            this.cmdComoJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdComoJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdComoJogar.FlatAppearance.BorderSize = 0;
            this.cmdComoJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdComoJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdComoJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComoJogar.Location = new System.Drawing.Point(108, 388);
            this.cmdComoJogar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdComoJogar.Name = "cmdComoJogar";
            this.cmdComoJogar.Size = new System.Drawing.Size(166, 81);
            this.cmdComoJogar.TabIndex = 2;
            this.cmdComoJogar.UseVisualStyleBackColor = false;
            this.cmdComoJogar.Click += new System.EventHandler(this.cmdComoJogar_Click);
            // 
            // cmdCreditos
            // 
            this.cmdCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCreditos.BackColor = System.Drawing.Color.Transparent;
            this.cmdCreditos.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btnCredito;
            this.cmdCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCreditos.FlatAppearance.BorderSize = 0;
            this.cmdCreditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdCreditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCreditos.Location = new System.Drawing.Point(540, 388);
            this.cmdCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCreditos.Name = "cmdCreditos";
            this.cmdCreditos.Size = new System.Drawing.Size(166, 81);
            this.cmdCreditos.TabIndex = 3;
            this.cmdCreditos.UseVisualStyleBackColor = false;
            this.cmdCreditos.Click += new System.EventHandler(this.cmdCreditos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.memorizado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 559);
            this.Controls.Add(this.cmdCreditos);
            this.Controls.Add(this.cmdComoJogar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdJogar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdJogar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdComoJogar;
        private System.Windows.Forms.Button cmdCreditos;
    }
}

