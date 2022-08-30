
namespace AlphabetGame
{
    partial class ChoosePicureGameForm
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
            this.picGuess1 = new System.Windows.Forms.PictureBox();
            this.picGuess2 = new System.Windows.Forms.PictureBox();
            this.picGuess3 = new System.Windows.Forms.PictureBox();
            this.picGuess4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picGuess1
            // 
            this.picGuess1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuess1.Location = new System.Drawing.Point(195, 130);
            this.picGuess1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGuess1.Name = "picGuess1";
            this.picGuess1.Size = new System.Drawing.Size(284, 180);
            this.picGuess1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuess1.TabIndex = 0;
            this.picGuess1.TabStop = false;
            this.picGuess1.Visible = false;
            this.picGuess1.Click += new System.EventHandler(this.picGuess1_Click);
            // 
            // picGuess2
            // 
            this.picGuess2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuess2.Location = new System.Drawing.Point(568, 130);
            this.picGuess2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGuess2.Name = "picGuess2";
            this.picGuess2.Size = new System.Drawing.Size(284, 180);
            this.picGuess2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuess2.TabIndex = 0;
            this.picGuess2.TabStop = false;
            this.picGuess2.Visible = false;
            this.picGuess2.Click += new System.EventHandler(this.picGuess2_Click);
            // 
            // picGuess3
            // 
            this.picGuess3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuess3.Location = new System.Drawing.Point(195, 329);
            this.picGuess3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGuess3.Name = "picGuess3";
            this.picGuess3.Size = new System.Drawing.Size(284, 180);
            this.picGuess3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuess3.TabIndex = 0;
            this.picGuess3.TabStop = false;
            this.picGuess3.Visible = false;
            this.picGuess3.Click += new System.EventHandler(this.picGuess3_Click);
            // 
            // picGuess4
            // 
            this.picGuess4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuess4.Location = new System.Drawing.Point(568, 329);
            this.picGuess4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGuess4.Name = "picGuess4";
            this.picGuess4.Size = new System.Drawing.Size(284, 180);
            this.picGuess4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuess4.TabIndex = 0;
            this.picGuess4.TabStop = false;
            this.picGuess4.Visible = false;
            this.picGuess4.Click += new System.EventHandler(this.picGuess4_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 41);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(236, 176);
            this.picResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(573, 295);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 3;
            this.picResult.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Blue;
            this.lblScore.Location = new System.Drawing.Point(40, 130);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(79, 23);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: ";
            this.lblScore.Visible = false;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(904, 421);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 102);
            this.btnBackToMenu.TabIndex = 9;
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // ChoosePicureGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picGuess4);
            this.Controls.Add(this.picGuess3);
            this.Controls.Add(this.picGuess2);
            this.Controls.Add(this.picGuess1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChoosePicureGameForm";
            this.Text = "ChoosePicureGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.picGuess1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGuess1;
        private System.Windows.Forms.PictureBox picGuess2;
        private System.Windows.Forms.PictureBox picGuess3;
        private System.Windows.Forms.PictureBox picGuess4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}