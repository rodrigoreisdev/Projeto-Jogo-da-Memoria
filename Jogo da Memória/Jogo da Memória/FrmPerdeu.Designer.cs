namespace Jogo_da_Memória
{
    partial class FrmPerdeu
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
            this.bt_Retry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Menu = new System.Windows.Forms.Button();
            this.pb_Mensagem = new System.Windows.Forms.PictureBox();
            this.pb_Personagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mensagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Retry
            // 
            this.bt_Retry.Font = new System.Drawing.Font("Milky Nice", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Retry.Location = new System.Drawing.Point(245, 213);
            this.bt_Retry.Name = "bt_Retry";
            this.bt_Retry.Size = new System.Drawing.Size(174, 54);
            this.bt_Retry.TabIndex = 5;
            this.bt_Retry.Text = "もう一度";
            this.bt_Retry.UseVisualStyleBackColor = true;
            this.bt_Retry.Click += new System.EventHandler(this.bt_Retry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bt_Menu);
            this.panel1.Controls.Add(this.bt_Retry);
            this.panel1.Controls.Add(this.pb_Mensagem);
            this.panel1.Controls.Add(this.pb_Personagem);
            this.panel1.Location = new System.Drawing.Point(214, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 333);
            this.panel1.TabIndex = 4;
            // 
            // bt_Menu
            // 
            this.bt_Menu.Font = new System.Drawing.Font("Milky Nice", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Menu.Location = new System.Drawing.Point(245, 273);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(174, 54);
            this.bt_Menu.TabIndex = 6;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // pb_Mensagem
            // 
            this.pb_Mensagem.Location = new System.Drawing.Point(235, 64);
            this.pb_Mensagem.Name = "pb_Mensagem";
            this.pb_Mensagem.Size = new System.Drawing.Size(173, 113);
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
            this.label1.Location = new System.Drawing.Point(286, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ahh, que pena !";
            // 
            // FrmPerdeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPerdeu";
            this.Text = "FrmPerdeu";
            this.Load += new System.EventHandler(this.FrmPerdeu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mensagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Retry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Mensagem;
        private System.Windows.Forms.PictureBox pb_Personagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Menu;
    }
}