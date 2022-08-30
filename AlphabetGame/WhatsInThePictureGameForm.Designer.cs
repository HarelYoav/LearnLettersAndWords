
namespace AlphabetGame
{
    partial class WhatsInThePictureGameForm
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
            this.picWordToGuess = new System.Windows.Forms.PictureBox();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.tmrGuessWordForm = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.gBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWordToGuess)).BeginInit();
            this.gBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWordToGuess
            // 
            this.picWordToGuess.Location = new System.Drawing.Point(271, 150);
            this.picWordToGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picWordToGuess.Name = "picWordToGuess";
            this.picWordToGuess.Size = new System.Drawing.Size(473, 244);
            this.picWordToGuess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWordToGuess.TabIndex = 0;
            this.picWordToGuess.TabStop = false;
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Snow;
            this.btnOption1.ForeColor = System.Drawing.Color.Blue;
            this.btnOption1.Location = new System.Drawing.Point(79, 23);
            this.btnOption1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(100, 28);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Text = "Choice 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Snow;
            this.btnOption2.ForeColor = System.Drawing.Color.Blue;
            this.btnOption2.Location = new System.Drawing.Point(280, 23);
            this.btnOption2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(100, 28);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.Text = "Choice 2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.Snow;
            this.btnOption3.ForeColor = System.Drawing.Color.Blue;
            this.btnOption3.Location = new System.Drawing.Point(473, 23);
            this.btnOption3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(100, 28);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Text = "Choice 3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.Snow;
            this.btnOption4.ForeColor = System.Drawing.Color.Blue;
            this.btnOption4.Location = new System.Drawing.Point(689, 23);
            this.btnOption4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(100, 28);
            this.btnOption4.TabIndex = 4;
            this.btnOption4.Text = "Choice 4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(56, 82);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.Blue;
            this.lblTimeLeft.Location = new System.Drawing.Point(448, 123);
            this.lblTimeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(118, 23);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Time Left: ";
            this.lblTimeLeft.Visible = false;
            // 
            // tmrGuessWordForm
            // 
            this.tmrGuessWordForm.Interval = 1000;
            this.tmrGuessWordForm.Tick += new System.EventHandler(this.tmrGuessWordForm_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Blue;
            this.lblScore.Location = new System.Drawing.Point(63, 162);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(74, 23);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score:";
            // 
            // gBoxButtons
            // 
            this.gBoxButtons.BackColor = System.Drawing.Color.Transparent;
            this.gBoxButtons.Controls.Add(this.btnOption4);
            this.gBoxButtons.Controls.Add(this.btnOption1);
            this.gBoxButtons.Controls.Add(this.btnOption2);
            this.gBoxButtons.Controls.Add(this.btnOption3);
            this.gBoxButtons.Location = new System.Drawing.Point(81, 379);
            this.gBoxButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxButtons.Name = "gBoxButtons";
            this.gBoxButtons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxButtons.Size = new System.Drawing.Size(872, 87);
            this.gBoxButtons.TabIndex = 8;
            this.gBoxButtons.TabStop = false;
            this.gBoxButtons.Visible = false;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(909, 426);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 102);
            this.btnBackToMenu.TabIndex = 10;
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // WhatsInThePictureGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.gBoxButtons);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picWordToGuess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WhatsInThePictureGameForm";
            this.Text = "GuessWordForm";
            ((System.ComponentModel.ISupportInitialize)(this.picWordToGuess)).EndInit();
            this.gBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWordToGuess;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer tmrGuessWordForm;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox gBoxButtons;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}