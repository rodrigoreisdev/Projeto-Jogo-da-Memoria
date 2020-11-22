namespace Jogo_da_Memória
{
    partial class GameDificil
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
            this.components = new System.ComponentModel.Container();
            this.levelValue = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeLeft = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.dupimg8 = new System.Windows.Forms.PictureBox();
            this.dupimg7 = new System.Windows.Forms.PictureBox();
            this.img8 = new System.Windows.Forms.PictureBox();
            this.img7 = new System.Windows.Forms.PictureBox();
            this.img5 = new System.Windows.Forms.PictureBox();
            this.dupimg5 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.dupimg4 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.dupimg3 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.dupimg2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img6 = new System.Windows.Forms.PictureBox();
            this.dupimg1 = new System.Windows.Forms.PictureBox();
            this.dupimg6 = new System.Windows.Forms.PictureBox();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.FlipTime = new System.Windows.Forms.Timer(this.components);
            this.TimeRemaining = new System.Windows.Forms.Timer(this.components);
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg6)).BeginInit();
            this.SuspendLayout();
            // 
            // levelValue
            // 
            this.levelValue.AutoSize = true;
            this.levelValue.BackColor = System.Drawing.Color.Black;
            this.levelValue.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelValue.ForeColor = System.Drawing.SystemColors.Control;
            this.levelValue.Location = new System.Drawing.Point(654, 49);
            this.levelValue.Name = "levelValue";
            this.levelValue.Size = new System.Drawing.Size(28, 33);
            this.levelValue.TabIndex = 25;
            this.levelValue.Text = "1";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Black;
            this.levelLabel.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.levelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLabel.Location = new System.Drawing.Point(566, 49);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(78, 33);
            this.levelLabel.TabIndex = 24;
            this.levelLabel.Text = "Level :";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(596, 185);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(155, 47);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Play Again";
            this.resetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.BackColor = System.Drawing.Color.Black;
            this.timeLeft.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.timeLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLeft.Location = new System.Drawing.Point(710, 131);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(41, 33);
            this.timeLeft.TabIndex = 22;
            this.timeLeft.Text = "60";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Black;
            this.Time.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Time.ForeColor = System.Drawing.SystemColors.Control;
            this.Time.Location = new System.Drawing.Point(565, 131);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(124, 33);
            this.Time.TabIndex = 21;
            this.Time.Text = "Time Left :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(565, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Label";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.BackColor = System.Drawing.Color.Black;
            this.ScoreCounter.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreCounter.Location = new System.Drawing.Point(661, 88);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(28, 33);
            this.ScoreCounter.TabIndex = 19;
            this.ScoreCounter.Text = "0";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Black;
            this.ScoreLabel.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreLabel.Location = new System.Drawing.Point(566, 88);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(89, 33);
            this.ScoreLabel.TabIndex = 18;
            this.ScoreLabel.Text = "Score :";
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel.Controls.Add(this.dupimg8);
            this.GamePanel.Controls.Add(this.dupimg7);
            this.GamePanel.Controls.Add(this.img8);
            this.GamePanel.Controls.Add(this.img7);
            this.GamePanel.Controls.Add(this.img5);
            this.GamePanel.Controls.Add(this.dupimg5);
            this.GamePanel.Controls.Add(this.img4);
            this.GamePanel.Controls.Add(this.dupimg4);
            this.GamePanel.Controls.Add(this.img3);
            this.GamePanel.Controls.Add(this.dupimg3);
            this.GamePanel.Controls.Add(this.img2);
            this.GamePanel.Controls.Add(this.dupimg2);
            this.GamePanel.Controls.Add(this.img1);
            this.GamePanel.Controls.Add(this.img6);
            this.GamePanel.Controls.Add(this.dupimg1);
            this.GamePanel.Controls.Add(this.dupimg6);
            this.GamePanel.Location = new System.Drawing.Point(59, 21);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(460, 491);
            this.GamePanel.TabIndex = 17;
            // 
            // dupimg8
            // 
            this.dupimg8.Location = new System.Drawing.Point(323, 346);
            this.dupimg8.Name = "dupimg8";
            this.dupimg8.Size = new System.Drawing.Size(90, 100);
            this.dupimg8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg8.TabIndex = 55;
            this.dupimg8.TabStop = false;
            this.dupimg8.Tag = "8";
            this.dupimg8.Click += new System.EventHandler(this.dupimg8_Click);
            // 
            // dupimg7
            // 
            this.dupimg7.Location = new System.Drawing.Point(227, 346);
            this.dupimg7.Name = "dupimg7";
            this.dupimg7.Size = new System.Drawing.Size(90, 100);
            this.dupimg7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg7.TabIndex = 54;
            this.dupimg7.TabStop = false;
            this.dupimg7.Tag = "7";
            this.dupimg7.Click += new System.EventHandler(this.dupimg7_Click);
            // 
            // img8
            // 
            this.img8.Location = new System.Drawing.Point(323, 134);
            this.img8.Name = "img8";
            this.img8.Size = new System.Drawing.Size(90, 100);
            this.img8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img8.TabIndex = 53;
            this.img8.TabStop = false;
            this.img8.Tag = "8";
            this.img8.Click += new System.EventHandler(this.img8_Click);
            // 
            // img7
            // 
            this.img7.Location = new System.Drawing.Point(227, 134);
            this.img7.Name = "img7";
            this.img7.Size = new System.Drawing.Size(90, 100);
            this.img7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img7.TabIndex = 52;
            this.img7.TabStop = false;
            this.img7.Tag = "7";
            this.img7.Click += new System.EventHandler(this.img7_Click);
            // 
            // img5
            // 
            this.img5.Location = new System.Drawing.Point(35, 134);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(90, 100);
            this.img5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img5.TabIndex = 51;
            this.img5.TabStop = false;
            this.img5.Tag = "5";
            this.img5.Click += new System.EventHandler(this.img5_Click);
            // 
            // dupimg5
            // 
            this.dupimg5.Location = new System.Drawing.Point(35, 346);
            this.dupimg5.Name = "dupimg5";
            this.dupimg5.Size = new System.Drawing.Size(90, 100);
            this.dupimg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg5.TabIndex = 49;
            this.dupimg5.TabStop = false;
            this.dupimg5.Tag = "5";
            this.dupimg5.Click += new System.EventHandler(this.dupimg5_Click);
            // 
            // img4
            // 
            this.img4.Location = new System.Drawing.Point(323, 28);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(90, 100);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4.TabIndex = 47;
            this.img4.TabStop = false;
            this.img4.Tag = "4";
            this.img4.Click += new System.EventHandler(this.img4_Click);
            // 
            // dupimg4
            // 
            this.dupimg4.Location = new System.Drawing.Point(323, 240);
            this.dupimg4.Name = "dupimg4";
            this.dupimg4.Size = new System.Drawing.Size(90, 100);
            this.dupimg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg4.TabIndex = 45;
            this.dupimg4.TabStop = false;
            this.dupimg4.Tag = "4";
            this.dupimg4.Click += new System.EventHandler(this.dupimg4_Click);
            // 
            // img3
            // 
            this.img3.Location = new System.Drawing.Point(227, 28);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(90, 100);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 43;
            this.img3.TabStop = false;
            this.img3.Tag = "3";
            this.img3.Click += new System.EventHandler(this.img3_Click);
            // 
            // dupimg3
            // 
            this.dupimg3.Location = new System.Drawing.Point(227, 240);
            this.dupimg3.Name = "dupimg3";
            this.dupimg3.Size = new System.Drawing.Size(90, 100);
            this.dupimg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg3.TabIndex = 41;
            this.dupimg3.TabStop = false;
            this.dupimg3.Tag = "3";
            this.dupimg3.Click += new System.EventHandler(this.dupimg3_Click);
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(131, 28);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(90, 100);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 39;
            this.img2.TabStop = false;
            this.img2.Tag = "2";
            this.img2.Click += new System.EventHandler(this.img2_Click);
            // 
            // dupimg2
            // 
            this.dupimg2.Location = new System.Drawing.Point(131, 240);
            this.dupimg2.Name = "dupimg2";
            this.dupimg2.Size = new System.Drawing.Size(90, 100);
            this.dupimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg2.TabIndex = 37;
            this.dupimg2.TabStop = false;
            this.dupimg2.Tag = "2";
            this.dupimg2.Click += new System.EventHandler(this.dupimg2_Click);
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(35, 28);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(90, 100);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 35;
            this.img1.TabStop = false;
            this.img1.Tag = "1";
            this.img1.Click += new System.EventHandler(this.img1_Click);
            // 
            // img6
            // 
            this.img6.Location = new System.Drawing.Point(131, 134);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(90, 100);
            this.img6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img6.TabIndex = 34;
            this.img6.TabStop = false;
            this.img6.Tag = "6";
            this.img6.Click += new System.EventHandler(this.img6_Click);
            // 
            // dupimg1
            // 
            this.dupimg1.Location = new System.Drawing.Point(35, 240);
            this.dupimg1.Name = "dupimg1";
            this.dupimg1.Size = new System.Drawing.Size(90, 100);
            this.dupimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg1.TabIndex = 33;
            this.dupimg1.TabStop = false;
            this.dupimg1.Tag = "1";
            this.dupimg1.Click += new System.EventHandler(this.dupimg1_Click);
            // 
            // dupimg6
            // 
            this.dupimg6.Location = new System.Drawing.Point(131, 346);
            this.dupimg6.Name = "dupimg6";
            this.dupimg6.Size = new System.Drawing.Size(90, 100);
            this.dupimg6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dupimg6.TabIndex = 32;
            this.dupimg6.TabStop = false;
            this.dupimg6.Tag = "6";
            this.dupimg6.Click += new System.EventHandler(this.dupimg6_Click);
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Interval = 6000;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // FlipTime
            // 
            this.FlipTime.Interval = 500;
            this.FlipTime.Tick += new System.EventHandler(this.FlipTime_Tick);
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.Interval = 1000;
            this.TimeRemaining.Tick += new System.EventHandler(this.TimeRemaining_Tick);
            // 
            // GameDificil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 555);
            this.Controls.Add(this.levelValue);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GamePanel);
            this.Name = "GameDificil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameDificil";
            this.Load += new System.EventHandler(this.GameDificil_Load);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dupimg8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupimg6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label levelValue;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox img5;
        private System.Windows.Forms.PictureBox dupimg5;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.PictureBox dupimg4;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox dupimg3;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox dupimg2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img6;
        private System.Windows.Forms.PictureBox dupimg1;
        private System.Windows.Forms.PictureBox dupimg6;
        private System.Windows.Forms.PictureBox dupimg8;
        private System.Windows.Forms.PictureBox dupimg7;
        private System.Windows.Forms.PictureBox img8;
        private System.Windows.Forms.PictureBox img7;
        private System.Windows.Forms.Timer ScoreTimer;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Timer FlipTime;
        private System.Windows.Forms.Timer TimeRemaining;
    }
}