
namespace AlphabetGame
{
    partial class LearnWordsForm
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
            this.cmboxChooseLetter = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkboxPlayAuto = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picLetterWWord = new System.Windows.Forms.PictureBox();
            this.picLetterChoose = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrLearnFromWords = new System.Windows.Forms.Timer(this.components);
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLetterWWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLetterChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboxChooseLetter
            // 
            this.cmboxChooseLetter.FormattingEnabled = true;
            this.cmboxChooseLetter.Location = new System.Drawing.Point(52, 79);
            this.cmboxChooseLetter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboxChooseLetter.Name = "cmboxChooseLetter";
            this.cmboxChooseLetter.Size = new System.Drawing.Size(160, 24);
            this.cmboxChooseLetter.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(52, 155);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkboxPlayAuto
            // 
            this.chkboxPlayAuto.AutoSize = true;
            this.chkboxPlayAuto.Location = new System.Drawing.Point(188, 162);
            this.chkboxPlayAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkboxPlayAuto.Name = "chkboxPlayAuto";
            this.chkboxPlayAuto.Size = new System.Drawing.Size(90, 21);
            this.chkboxPlayAuto.TabIndex = 2;
            this.chkboxPlayAuto.Text = "Play Auto";
            this.chkboxPlayAuto.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(787, 375);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 49);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(144, 375);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picLetterWWord
            // 
            this.picLetterWWord.Location = new System.Drawing.Point(299, 180);
            this.picLetterWWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLetterWWord.Name = "picLetterWWord";
            this.picLetterWWord.Size = new System.Drawing.Size(480, 245);
            this.picLetterWWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLetterWWord.TabIndex = 5;
            this.picLetterWWord.TabStop = false;
            this.picLetterWWord.Visible = false;
            // 
            // picLetterChoose
            // 
            this.picLetterChoose.Location = new System.Drawing.Point(317, 68);
            this.picLetterChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLetterChoose.Name = "picLetterChoose";
            this.picLetterChoose.Size = new System.Drawing.Size(417, 62);
            this.picLetterChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLetterChoose.TabIndex = 6;
            this.picLetterChoose.TabStop = false;
            this.picLetterChoose.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(52, 191);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrLearnFromWords
            // 
            this.tmrLearnFromWords.Enabled = true;
            this.tmrLearnFromWords.Tick += new System.EventHandler(this.tmrLearnFromWords_Tick);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(23, 242);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 102);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // LearnWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.picLetterChoose);
            this.Controls.Add(this.picLetterWWord);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.chkboxPlayAuto);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmboxChooseLetter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LearnWordsForm";
            this.Text = "LearnWordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picLetterWWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLetterChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxChooseLetter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkboxPlayAuto;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picLetterWWord;
        private System.Windows.Forms.PictureBox picLetterChoose;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrLearnFromWords;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}