namespace Jogo_da_Memória
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
            this.bt_Continuar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Inicio = new System.Windows.Forms.Button();
            this.pb_Mensagem = new System.Windows.Forms.PictureBox();
            this.pb_Personagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mensagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Continuar
            // 
            this.bt_Continuar.Font = new System.Drawing.Font("Milky Nice", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Continuar.Location = new System.Drawing.Point(245, 217);
            this.bt_Continuar.Name = "bt_Continuar";
            this.bt_Continuar.Size = new System.Drawing.Size(174, 54);
            this.bt_Continuar.TabIndex = 8;
            this.bt_Continuar.Text = "Continuar";
            this.bt_Continuar.UseVisualStyleBackColor = true;
            this.bt_Continuar.Click += new System.EventHandler(this.bt_Continuar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bt_Inicio);
            this.panel1.Controls.Add(this.bt_Continuar);
            this.panel1.Controls.Add(this.pb_Mensagem);
            this.panel1.Controls.Add(this.pb_Personagem);
            this.panel1.Location = new System.Drawing.Point(183, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 333);
            this.panel1.TabIndex = 7;
            // 
            // bt_Inicio
            // 
            this.bt_Inicio.Font = new System.Drawing.Font("Milky Nice", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Inicio.Location = new System.Drawing.Point(245, 279);
            this.bt_Inicio.Name = "bt_Inicio";
            this.bt_Inicio.Size = new System.Drawing.Size(174, 54);
            this.bt_Inicio.TabIndex = 9;
            this.bt_Inicio.Text = "Menu";
            this.bt_Inicio.UseVisualStyleBackColor = true;
            this.bt_Inicio.Click += new System.EventHandler(this.bt_Inicio_Click);
            // 
            // pb_Mensagem
            // 
            this.pb_Mensagem.Location = new System.Drawing.Point(236, 78);
            this.pb_Mensagem.Name = "pb_Mensagem";
            this.pb_Mensagem.Size = new System.Drawing.Size(151, 106);
            this.pb_Mensagem.TabIndex = 1;
            this.pb_Mensagem.TabStop = false;
            // 
            // pb_Personagem
            // 
            this.pb_Personagem.Location = new System.Drawing.Point(20, 26);
            this.pb_Personagem.Name = "pb_Personagem";
            this.pb_Personagem.Size = new System.Drawing.Size(171, 262);
            this.pb_Personagem.TabIndex = 0;
            this.pb_Personagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Milky Nice", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parabéns!!";
            // 
            // FrmGanhou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGanhou";
            this.Text = "FrmGanhou";
            this.Load += new System.EventHandler(this.FrmGanhou_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mensagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Continuar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Mensagem;
        private System.Windows.Forms.PictureBox pb_Personagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Inicio;
    }
}