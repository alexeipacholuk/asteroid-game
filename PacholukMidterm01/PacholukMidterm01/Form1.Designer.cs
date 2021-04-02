
namespace PacholukMidterm01
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.asteroid01 = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.asteroid02 = new System.Windows.Forms.PictureBox();
            this.asteroid03 = new System.Windows.Forms.PictureBox();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.hiScoreLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid03)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // asteroid01
            // 
            this.asteroid01.BackColor = System.Drawing.Color.Transparent;
            this.asteroid01.Image = global::PacholukMidterm01.Properties.Resources.asteroid01;
            this.asteroid01.Location = new System.Drawing.Point(12, 162);
            this.asteroid01.Name = "asteroid01";
            this.asteroid01.Size = new System.Drawing.Size(89, 81);
            this.asteroid01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asteroid01.TabIndex = 1;
            this.asteroid01.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.Color.Transparent;
            this.ufo.Image = global::PacholukMidterm01.Properties.Resources.spaceship;
            this.ufo.Location = new System.Drawing.Point(131, 739);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(89, 81);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 0;
            this.ufo.TabStop = false;
            // 
            // asteroid02
            // 
            this.asteroid02.BackColor = System.Drawing.Color.Transparent;
            this.asteroid02.Image = global::PacholukMidterm01.Properties.Resources.asteroid01;
            this.asteroid02.Location = new System.Drawing.Point(348, 402);
            this.asteroid02.Name = "asteroid02";
            this.asteroid02.Size = new System.Drawing.Size(89, 81);
            this.asteroid02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asteroid02.TabIndex = 1;
            this.asteroid02.TabStop = false;
            // 
            // asteroid03
            // 
            this.asteroid03.BackColor = System.Drawing.Color.Transparent;
            this.asteroid03.Image = global::PacholukMidterm01.Properties.Resources.asteroid01;
            this.asteroid03.Location = new System.Drawing.Point(616, 739);
            this.asteroid03.Name = "asteroid03";
            this.asteroid03.Size = new System.Drawing.Size(89, 81);
            this.asteroid03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asteroid03.TabIndex = 1;
            this.asteroid03.TabStop = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.gameOverLabel.Location = new System.Drawing.Point(117, 281);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(481, 84);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(164, 37);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "SCORE:  ";
            // 
            // hiScoreLabel
            // 
            this.hiScoreLabel.AutoSize = true;
            this.hiScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hiScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiScoreLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.hiScoreLabel.Location = new System.Drawing.Point(117, 399);
            this.hiScoreLabel.Name = "hiScoreLabel";
            this.hiScoreLabel.Size = new System.Drawing.Size(278, 42);
            this.hiScoreLabel.TabIndex = 2;
            this.hiScoreLabel.Text = "HIGH SCORE: ";
            this.hiScoreLabel.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(117, 565);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(202, 62);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(117, 671);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(116, 62);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "QUIT";
            this.quitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 965);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.hiScoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.asteroid03);
            this.Controls.Add(this.asteroid02);
            this.Controls.Add(this.asteroid01);
            this.Controls.Add(this.ufo);
            this.Name = "Form1";
            this.Text = "Asteroid Field";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.asteroid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.PictureBox asteroid01;
        private System.Windows.Forms.PictureBox asteroid02;
        private System.Windows.Forms.PictureBox asteroid03;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label hiScoreLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button quitButton;
    }
}

