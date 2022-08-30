
namespace AlphabetGame
{
    partial class MainForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAddWords = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnLearnLetters = new System.Windows.Forms.Button();
            this.tmrMainForm = new System.Windows.Forms.Timer(this.components);
            this.btnOkName = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.chkboxAgree = new System.Windows.Forms.CheckBox();
            this.gBoxFirstLogin = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.chkSaveData = new System.Windows.Forms.CheckBox();
            this.lblGuessWordScore = new System.Windows.Forms.Label();
            this.lblChooseRightPicScore = new System.Windows.Forms.Label();
            this.lblBuildWordScore = new System.Windows.Forms.Label();
            this.lblMemoryGameScore = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.gBoxFirstLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(90, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 46);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "User Name:";
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(90, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAddWords
            // 
            this.btnAddWords.Location = new System.Drawing.Point(506, 269);
            this.btnAddWords.Name = "btnAddWords";
            this.btnAddWords.Size = new System.Drawing.Size(163, 106);
            this.btnAddWords.TabIndex = 3;
            this.btnAddWords.UseVisualStyleBackColor = true;
            this.btnAddWords.Visible = false;
            this.btnAddWords.Click += new System.EventHandler(this.btnAddWords_Click);
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(292, 269);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(163, 106);
            this.btnGames.TabIndex = 4;
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Visible = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnLearnLetters
            // 
            this.btnLearnLetters.Location = new System.Drawing.Point(75, 269);
            this.btnLearnLetters.Name = "btnLearnLetters";
            this.btnLearnLetters.Size = new System.Drawing.Size(163, 106);
            this.btnLearnLetters.TabIndex = 5;
            this.btnLearnLetters.UseVisualStyleBackColor = true;
            this.btnLearnLetters.Visible = false;
            this.btnLearnLetters.Click += new System.EventHandler(this.btnLearnLetters_Click);
            // 
            // tmrMainForm
            // 
            this.tmrMainForm.Enabled = true;
            this.tmrMainForm.Tick += new System.EventHandler(this.tmrMainForm_Tick);
            // 
            // btnOkName
            // 
            this.btnOkName.Location = new System.Drawing.Point(247, 202);
            this.btnOkName.Name = "btnOkName";
            this.btnOkName.Size = new System.Drawing.Size(64, 23);
            this.btnOkName.TabIndex = 6;
            this.btnOkName.Text = "Ok";
            this.btnOkName.UseVisualStyleBackColor = true;
            this.btnOkName.Click += new System.EventHandler(this.btnOkName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 206);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Enter Your Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(140, 204);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(34, 38);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(156, 13);
            this.lblWelcomeMessage.TabIndex = 9;
            this.lblWelcomeMessage.Text = "Welcome message for first login";
            // 
            // chkboxAgree
            // 
            this.chkboxAgree.AutoSize = true;
            this.chkboxAgree.Location = new System.Drawing.Point(37, 157);
            this.chkboxAgree.Name = "chkboxAgree";
            this.chkboxAgree.Size = new System.Drawing.Size(54, 17);
            this.chkboxAgree.TabIndex = 10;
            this.chkboxAgree.Text = "Agree";
            this.chkboxAgree.UseVisualStyleBackColor = true;
            // 
            // gBoxFirstLogin
            // 
            this.gBoxFirstLogin.Controls.Add(this.lblWelcomeMessage);
            this.gBoxFirstLogin.Controls.Add(this.btnOkName);
            this.gBoxFirstLogin.Controls.Add(this.txtFirstName);
            this.gBoxFirstLogin.Controls.Add(this.chkboxAgree);
            this.gBoxFirstLogin.Controls.Add(this.lblFirstName);
            this.gBoxFirstLogin.Location = new System.Drawing.Point(187, 12);
            this.gBoxFirstLogin.Name = "gBoxFirstLogin";
            this.gBoxFirstLogin.Size = new System.Drawing.Size(482, 241);
            this.gBoxFirstLogin.TabIndex = 11;
            this.gBoxFirstLogin.TabStop = false;
            this.gBoxFirstLogin.Text = "First Login";
            this.gBoxFirstLogin.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 179);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcomeName.Location = new System.Drawing.Point(20, 27);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(128, 19);
            this.lblWelcomeName.TabIndex = 14;
            this.lblWelcomeName.Text = "Welcome name";
            this.lblWelcomeName.Visible = false;
            // 
            // chkSaveData
            // 
            this.chkSaveData.AutoSize = true;
            this.chkSaveData.BackColor = System.Drawing.Color.Transparent;
            this.chkSaveData.Location = new System.Drawing.Point(28, 218);
            this.chkSaveData.Name = "chkSaveData";
            this.chkSaveData.Size = new System.Drawing.Size(77, 17);
            this.chkSaveData.TabIndex = 15;
            this.chkSaveData.Text = "Save Data";
            this.chkSaveData.UseVisualStyleBackColor = false;
            this.chkSaveData.Visible = false;
            // 
            // lblGuessWordScore
            // 
            this.lblGuessWordScore.AutoSize = true;
            this.lblGuessWordScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessWordScore.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblGuessWordScore.ForeColor = System.Drawing.Color.Blue;
            this.lblGuessWordScore.Location = new System.Drawing.Point(21, 76);
            this.lblGuessWordScore.Name = "lblGuessWordScore";
            this.lblGuessWordScore.Size = new System.Drawing.Size(88, 14);
            this.lblGuessWordScore.TabIndex = 16;
            this.lblGuessWordScore.Text = "Guess The Word:";
            this.lblGuessWordScore.Visible = false;
            // 
            // lblChooseRightPicScore
            // 
            this.lblChooseRightPicScore.AutoSize = true;
            this.lblChooseRightPicScore.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseRightPicScore.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblChooseRightPicScore.ForeColor = System.Drawing.Color.Blue;
            this.lblChooseRightPicScore.Location = new System.Drawing.Point(21, 96);
            this.lblChooseRightPicScore.Name = "lblChooseRightPicScore";
            this.lblChooseRightPicScore.Size = new System.Drawing.Size(109, 14);
            this.lblChooseRightPicScore.TabIndex = 16;
            this.lblChooseRightPicScore.Text = "ChooseRight Picture:";
            this.lblChooseRightPicScore.Visible = false;
            // 
            // lblBuildWordScore
            // 
            this.lblBuildWordScore.AutoSize = true;
            this.lblBuildWordScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildWordScore.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblBuildWordScore.ForeColor = System.Drawing.Color.Blue;
            this.lblBuildWordScore.Location = new System.Drawing.Point(21, 119);
            this.lblBuildWordScore.Name = "lblBuildWordScore";
            this.lblBuildWordScore.Size = new System.Drawing.Size(63, 14);
            this.lblBuildWordScore.TabIndex = 16;
            this.lblBuildWordScore.Text = "Build Word:";
            this.lblBuildWordScore.Visible = false;
            // 
            // lblMemoryGameScore
            // 
            this.lblMemoryGameScore.AutoSize = true;
            this.lblMemoryGameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoryGameScore.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblMemoryGameScore.ForeColor = System.Drawing.Color.Blue;
            this.lblMemoryGameScore.Location = new System.Drawing.Point(21, 141);
            this.lblMemoryGameScore.Name = "lblMemoryGameScore";
            this.lblMemoryGameScore.Size = new System.Drawing.Size(84, 14);
            this.lblMemoryGameScore.TabIndex = 16;
            this.lblMemoryGameScore.Text = "Memory Game:";
            this.lblMemoryGameScore.Visible = false;
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.BackColor = System.Drawing.Color.Transparent;
            this.lblUserScore.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.ForeColor = System.Drawing.Color.Blue;
            this.lblUserScore.Location = new System.Drawing.Point(21, 54);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(111, 13);
            this.lblUserScore.TabIndex = 17;
            this.lblUserScore.Text = "Your Games Score";
            this.lblUserScore.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblMemoryGameScore);
            this.Controls.Add(this.lblBuildWordScore);
            this.Controls.Add(this.lblChooseRightPicScore);
            this.Controls.Add(this.lblGuessWordScore);
            this.Controls.Add(this.chkSaveData);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBoxFirstLogin);
            this.Controls.Add(this.btnLearnLetters);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnAddWords);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUserName);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gBoxFirstLogin.ResumeLayout(false);
            this.gBoxFirstLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAddWords;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnLearnLetters;
        private System.Windows.Forms.Timer tmrMainForm;
        private System.Windows.Forms.Button btnOkName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.CheckBox chkboxAgree;
        private System.Windows.Forms.GroupBox gBoxFirstLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.CheckBox chkSaveData;
        private System.Windows.Forms.Label lblGuessWordScore;
        private System.Windows.Forms.Label lblChooseRightPicScore;
        private System.Windows.Forms.Label lblBuildWordScore;
        private System.Windows.Forms.Label lblMemoryGameScore;
        private System.Windows.Forms.Label lblUserScore;
    }
}

