namespace Jogo_da_Memória
{
    partial class FrmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreditos));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1188, 580);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.Transparent;
            this.cmdSair.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.btnsair;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSair.ForeColor = System.Drawing.Color.Transparent;
            this.cmdSair.Location = new System.Drawing.Point(914, 596);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(252, 110);
            this.cmdSair.TabIndex = 1;
            this.cmdSair.UseVisualStyleBackColor = false;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memória.Properties.Resources.fundoSelecionarFase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 718);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreditos";
            this.Text = "FrmCreditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSair;
    }
}