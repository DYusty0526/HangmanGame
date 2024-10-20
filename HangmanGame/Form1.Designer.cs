namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Word = new Label();
            btn_New = new Button();
            btn_Submit = new Button();
            txtBox_Guess = new TextBox();
            lbl_Guesses = new Label();
            lbl_Incorrect = new Label();
            lbl_Round = new Label();
            lbl_WinS = new Label();
            SuspendLayout();
            // 
            // lbl_Word
            // 
            lbl_Word.AutoSize = true;
            lbl_Word.Location = new Point(167, 152);
            lbl_Word.Name = "lbl_Word";
            lbl_Word.Size = new Size(26, 20);
            lbl_Word.TabIndex = 0;
            lbl_Word.Text = "lbl";
            // 
            // btn_New
            // 
            btn_New.Location = new Point(167, 400);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(106, 29);
            btn_New.TabIndex = 1;
            btn_New.Text = "NewGame";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(167, 337);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(106, 29);
            btn_Submit.TabIndex = 2;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // txtBox_Guess
            // 
            txtBox_Guess.Location = new Point(140, 225);
            txtBox_Guess.Name = "txtBox_Guess";
            txtBox_Guess.Size = new Size(165, 27);
            txtBox_Guess.TabIndex = 3;
            // 
            // lbl_Guesses
            // 
            lbl_Guesses.AutoSize = true;
            lbl_Guesses.Location = new Point(341, 9);
            lbl_Guesses.Name = "lbl_Guesses";
            lbl_Guesses.Size = new Size(93, 20);
            lbl_Guesses.TabIndex = 4;
            lbl_Guesses.Text = "Guesses Left:";
            // 
            // lbl_Incorrect
            // 
            lbl_Incorrect.AutoSize = true;
            lbl_Incorrect.Location = new Point(248, 44);
            lbl_Incorrect.Name = "lbl_Incorrect";
            lbl_Incorrect.Size = new Size(128, 20);
            lbl_Incorrect.TabIndex = 5;
            lbl_Incorrect.Text = "Incorrect Guesees:";
            // 
            // lbl_Round
            // 
            lbl_Round.AutoSize = true;
            lbl_Round.Location = new Point(12, 9);
            lbl_Round.Name = "lbl_Round";
            lbl_Round.Size = new Size(55, 20);
            lbl_Round.TabIndex = 6;
            lbl_Round.Text = "Round:";
            // 
            // lbl_WinS
            // 
            lbl_WinS.AutoSize = true;
            lbl_WinS.Location = new Point(12, 44);
            lbl_WinS.Name = "lbl_WinS";
            lbl_WinS.Size = new Size(79, 20);
            lbl_WinS.TabIndex = 7;
            lbl_WinS.Text = "WinStreak:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(lbl_WinS);
            Controls.Add(lbl_Round);
            Controls.Add(lbl_Incorrect);
            Controls.Add(lbl_Guesses);
            Controls.Add(txtBox_Guess);
            Controls.Add(btn_Submit);
            Controls.Add(btn_New);
            Controls.Add(lbl_Word);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Word;
        private Button btn_New;
        private Button btn_Submit;
        private TextBox txtBox_Guess;
        private Label lbl_Guesses;
        private Label lbl_Incorrect;
        private Label lbl_Round;
        private Label lbl_WinS;
    }
}