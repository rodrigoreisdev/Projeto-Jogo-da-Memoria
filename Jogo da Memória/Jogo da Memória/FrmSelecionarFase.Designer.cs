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
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.cmdFase3 = new System.Windows.Forms.Button();
            this.cmdFase2 = new System.Windows.Forms.Button();
            this.cmdFase1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelecioneONivel
            // 
            this.buttonSelecioneONivel.BackColor = System.Drawing.Color.Yellow;
            this.buttonSelecioneONivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Controls.Add(this.pb3);
            this.panel1.Controls.Add(this.pb2);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.cmdFase3);
            this.panel1.Controls.Add(this.cmdFase2);
            this.panel1.Controls.Add(this.cmdFase1);
            this.panel1.Location = new System.Drawing.Point(251, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 177);
            this.panel1.TabIndex = 1;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Turquoise;
            this.pb3.BackgroundImage = global::Jogo_da_Memória.Properties.Resources._lock;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(211, 122);
            this.pb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(44, 38);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Turquoise;
            this.pb2.BackgroundImage = global::Jogo_da_Memória.Properties.Resources._lock;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(211, 65);
            this.pb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(44, 38);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Turquoise;
            this.pb1.BackgroundImage = global::Jogo_da_Memória.Properties.Resources._lock;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(211, 12);
            this.pb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(44, 38);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // cmdFase3
            // 
            this.cmdFase3.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase3.Enabled = false;
            this.cmdFase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase3.ForeColor = System.Drawing.Color.Black;
            this.cmdFase3.Location = new System.Drawing.Point(11, 115);
            this.cmdFase3.Name = "cmdFase3";
            this.cmdFase3.Size = new System.Drawing.Size(254, 51);
            this.cmdFase3.TabIndex = 4;
            this.cmdFase3.Text = "Fase 3";
            this.cmdFase3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase3.UseVisualStyleBackColor = false;
            this.cmdFase3.Click += new System.EventHandler(this.cmdFase3_Click);
            // 
            // cmdFase2
            // 
            this.cmdFase2.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase2.Enabled = false;
            this.cmdFase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase2.ForeColor = System.Drawing.Color.Black;
            this.cmdFase2.Location = new System.Drawing.Point(11, 60);
            this.cmdFase2.Name = "cmdFase2";
            this.cmdFase2.Size = new System.Drawing.Size(254, 51);
            this.cmdFase2.TabIndex = 3;
            this.cmdFase2.Text = "Fase 2";
            this.cmdFase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase2.UseVisualStyleBackColor = false;
            this.cmdFase2.Click += new System.EventHandler(this.cmdFase2_Click);
            // 
            // cmdFase1
            // 
            this.cmdFase1.BackColor = System.Drawing.Color.Turquoise;
            this.cmdFase1.Enabled = false;
            this.cmdFase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFase1.ForeColor = System.Drawing.Color.Black;
            this.cmdFase1.Location = new System.Drawing.Point(11, 6);
            this.cmdFase1.Name = "cmdFase1";
            this.cmdFase1.Size = new System.Drawing.Size(254, 51);
            this.cmdFase1.TabIndex = 2;
            this.cmdFase1.Text = "Fase 1";
            this.cmdFase1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFase1.UseVisualStyleBackColor = false;
            this.cmdFase1.Click += new System.EventHandler(this.cmdFase1_Click);
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
            this.Load += new System.EventHandler(this.FrmSelecionarFase_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelecioneONivel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdFase3;
        private System.Windows.Forms.Button cmdFase2;
        private System.Windows.Forms.Button cmdFase1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
    }
}