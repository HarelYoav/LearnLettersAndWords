
namespace AlphabetGame
{
    partial class AddWordForm
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
            this.lblEnterWord = new System.Windows.Forms.Label();
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.picBoxUpload = new System.Windows.Forms.PictureBox();
            this.btnPhotoUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnVoiceUpload = new System.Windows.Forms.Button();
            this.lblVoiceFile = new System.Windows.Forms.Label();
            this.AddWordFormTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlaySound = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblNewWordInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterWord
            // 
            this.lblEnterWord.AutoSize = true;
            this.lblEnterWord.Location = new System.Drawing.Point(48, 98);
            this.lblEnterWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterWord.Name = "lblEnterWord";
            this.lblEnterWord.Size = new System.Drawing.Size(80, 17);
            this.lblEnterWord.TabIndex = 0;
            this.lblEnterWord.Text = "Enter Word";
            // 
            // txtAddWord
            // 
            this.txtAddWord.Location = new System.Drawing.Point(153, 95);
            this.txtAddWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(132, 22);
            this.txtAddWord.TabIndex = 1;
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWord.Enabled = false;
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnAddWord.ForeColor = System.Drawing.Color.Snow;
            this.btnAddWord.Location = new System.Drawing.Point(52, 458);
            this.btnAddWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(176, 46);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Add ";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // picBoxUpload
            // 
            this.picBoxUpload.Location = new System.Drawing.Point(51, 302);
            this.picBoxUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxUpload.Name = "picBoxUpload";
            this.picBoxUpload.Size = new System.Drawing.Size(234, 124);
            this.picBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpload.TabIndex = 3;
            this.picBoxUpload.TabStop = false;
            // 
            // btnPhotoUpload
            // 
            this.btnPhotoUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnPhotoUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnPhotoUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPhotoUpload.Location = new System.Drawing.Point(52, 266);
            this.btnPhotoUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhotoUpload.Name = "btnPhotoUpload";
            this.btnPhotoUpload.Size = new System.Drawing.Size(135, 28);
            this.btnPhotoUpload.TabIndex = 4;
            this.btnPhotoUpload.Text = "Upload Photo";
            this.btnPhotoUpload.UseVisualStyleBackColor = false;
            this.btnPhotoUpload.Click += new System.EventHandler(this.btnPhotoUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnVoiceUpload
            // 
            this.btnVoiceUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoiceUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoiceUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVoiceUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoiceUpload.Location = new System.Drawing.Point(153, 155);
            this.btnVoiceUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoiceUpload.Name = "btnVoiceUpload";
            this.btnVoiceUpload.Size = new System.Drawing.Size(109, 28);
            this.btnVoiceUpload.TabIndex = 5;
            this.btnVoiceUpload.Text = "Upload Voice";
            this.btnVoiceUpload.UseVisualStyleBackColor = false;
            this.btnVoiceUpload.Click += new System.EventHandler(this.btnVoiceUpload_Click);
            // 
            // lblVoiceFile
            // 
            this.lblVoiceFile.AutoSize = true;
            this.lblVoiceFile.Location = new System.Drawing.Point(49, 156);
            this.lblVoiceFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoiceFile.Name = "lblVoiceFile";
            this.lblVoiceFile.Size = new System.Drawing.Size(71, 17);
            this.lblVoiceFile.TabIndex = 6;
            this.lblVoiceFile.Text = "File Name";
            // 
            // AddWordFormTimer
            // 
            this.AddWordFormTimer.Enabled = true;
            this.AddWordFormTimer.Tick += new System.EventHandler(this.AddWordFormTimer_Tick);
            // 
            // btnPlaySound
            // 
            this.btnPlaySound.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlaySound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaySound.Enabled = false;
            this.btnPlaySound.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnPlaySound.ForeColor = System.Drawing.Color.Snow;
            this.btnPlaySound.Location = new System.Drawing.Point(153, 191);
            this.btnPlaySound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaySound.Name = "btnPlaySound";
            this.btnPlaySound.Size = new System.Drawing.Size(109, 28);
            this.btnPlaySound.TabIndex = 7;
            this.btnPlaySound.Text = "Play Sound";
            this.btnPlaySound.UseVisualStyleBackColor = false;
            this.btnPlaySound.Click += new System.EventHandler(this.btnPlaySound_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(903, 425);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 102);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblNewWordInstruction
            // 
            this.lblNewWordInstruction.AutoSize = true;
            this.lblNewWordInstruction.Location = new System.Drawing.Point(295, 98);
            this.lblNewWordInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewWordInstruction.Name = "lblNewWordInstruction";
            this.lblNewWordInstruction.Size = new System.Drawing.Size(90, 17);
            this.lblNewWordInstruction.TabIndex = 9;
            this.lblNewWordInstruction.Text = "(Only letters)";
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblNewWordInstruction);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnPlaySound);
            this.Controls.Add(this.lblVoiceFile);
            this.Controls.Add(this.btnVoiceUpload);
            this.Controls.Add(this.btnPhotoUpload);
            this.Controls.Add(this.picBoxUpload);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.lblEnterWord);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddWordForm";
            this.Text = "AddWordForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterWord;
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.PictureBox picBoxUpload;
        private System.Windows.Forms.Button btnPhotoUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnVoiceUpload;
        private System.Windows.Forms.Label lblVoiceFile;
        private System.Windows.Forms.Timer AddWordFormTimer;
        private System.Windows.Forms.Button btnPlaySound;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblNewWordInstruction;
    }
}