
namespace AlphabetGame
{
    partial class GamesForm
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
            this.picGuessGame = new System.Windows.Forms.PictureBox();
            this.picBuildGame = new System.Windows.Forms.PictureBox();
            this.picChoosePictureGame = new System.Windows.Forms.PictureBox();
            this.picWordMemoryGame = new System.Windows.Forms.PictureBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGuessGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuildGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoosePictureGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWordMemoryGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picGuessGame
            // 
            this.picGuessGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuessGame.Location = new System.Drawing.Point(604, 106);
            this.picGuessGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGuessGame.Name = "picGuessGame";
            this.picGuessGame.Size = new System.Drawing.Size(264, 166);
            this.picGuessGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuessGame.TabIndex = 0;
            this.picGuessGame.TabStop = false;
            this.picGuessGame.Click += new System.EventHandler(this.picGuessGame_Click);
            // 
            // picBuildGame
            // 
            this.picBuildGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuildGame.Location = new System.Drawing.Point(111, 106);
            this.picBuildGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBuildGame.Name = "picBuildGame";
            this.picBuildGame.Size = new System.Drawing.Size(273, 175);
            this.picBuildGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuildGame.TabIndex = 1;
            this.picBuildGame.TabStop = false;
            this.picBuildGame.Click += new System.EventHandler(this.picBuildGame_Click);
            // 
            // picChoosePictureGame
            // 
            this.picChoosePictureGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picChoosePictureGame.Location = new System.Drawing.Point(604, 304);
            this.picChoosePictureGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picChoosePictureGame.Name = "picChoosePictureGame";
            this.picChoosePictureGame.Size = new System.Drawing.Size(264, 166);
            this.picChoosePictureGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoosePictureGame.TabIndex = 2;
            this.picChoosePictureGame.TabStop = false;
            this.picChoosePictureGame.Click += new System.EventHandler(this.picChoosePictureGame_Click);
            // 
            // picWordMemoryGame
            // 
            this.picWordMemoryGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWordMemoryGame.Location = new System.Drawing.Point(111, 304);
            this.picWordMemoryGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picWordMemoryGame.Name = "picWordMemoryGame";
            this.picWordMemoryGame.Size = new System.Drawing.Size(273, 166);
            this.picWordMemoryGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWordMemoryGame.TabIndex = 3;
            this.picWordMemoryGame.TabStop = false;
            this.picWordMemoryGame.Click += new System.EventHandler(this.picHearWordGame_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(909, 425);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 102);
            this.btnBackToMenu.TabIndex = 9;
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.picWordMemoryGame);
            this.Controls.Add(this.picChoosePictureGame);
            this.Controls.Add(this.picBuildGame);
            this.Controls.Add(this.picGuessGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            ((System.ComponentModel.ISupportInitialize)(this.picGuessGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuildGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoosePictureGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWordMemoryGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGuessGame;
        private System.Windows.Forms.PictureBox picBuildGame;
        private System.Windows.Forms.PictureBox picChoosePictureGame;
        private System.Windows.Forms.PictureBox picWordMemoryGame;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}