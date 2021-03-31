namespace Hangman_Lite
{
    partial class HangmanLite
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
            this.imgHangman = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHangman
            // 
            this.imgHangman.Image = global::Hangman_Lite.Properties.Resources.Hangmanblank;
            this.imgHangman.Location = new System.Drawing.Point(64, 102);
            this.imgHangman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgHangman.Name = "imgHangman";
            this.imgHangman.Size = new System.Drawing.Size(453, 362);
            this.imgHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangman.TabIndex = 0;
            this.imgHangman.TabStop = false;
            this.imgHangman.Click += new System.EventHandler(this.imgHangman_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(236, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 44);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome To Hangman";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(283, 63);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(338, 18);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Enter letters to reveal the word. You have 3 strikes.";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuesses.Location = new System.Drawing.Point(621, 151);
            this.lblGuesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(152, 24);
            this.lblGuesses.TabIndex = 3;
            this.lblGuesses.Text = "Guessed Letters";
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(64, 534);
            this.lblWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(711, 84);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "label4";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.ItemHeight = 18;
            this.lstGuessedLetters.Location = new System.Drawing.Point(607, 193);
            this.lstGuessedLetters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(200, 202);
            this.lstGuessedLetters.TabIndex = 5;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(700, 420);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(87, 30);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(627, 423);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(64, 22);
            this.txtGuess.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Firebrick;
            this.lblResult.Location = new System.Drawing.Point(380, 490);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(137, 28);
            this.lblResult.TabIndex = 8;
            // 
            // HangmanLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 658);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgHangman);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HangmanLite";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.HangmanLite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHangman;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblResult;
    }
}

