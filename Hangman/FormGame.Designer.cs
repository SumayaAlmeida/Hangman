
namespace Hangman
{
    partial class FormGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGuesses = new System.Windows.Forms.TextBox();
            this.buttonLetter = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttoN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUESS THE WORD";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxWord.Location = new System.Drawing.Point(336, 65);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ReadOnly = true;
            this.textBoxWord.Size = new System.Drawing.Size(418, 41);
            this.textBoxWord.TabIndex = 1;
            this.textBoxWord.Text = "Hangman Game - Press Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(336, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUESSES REMAINING";
            // 
            // textBoxGuesses
            // 
            this.textBoxGuesses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuesses.Location = new System.Drawing.Point(522, 123);
            this.textBoxGuesses.Name = "textBoxGuesses";
            this.textBoxGuesses.ReadOnly = true;
            this.textBoxGuesses.Size = new System.Drawing.Size(70, 33);
            this.textBoxGuesses.TabIndex = 4;
            this.textBoxGuesses.Text = "test";
            // 
            // buttonLetter
            // 
            this.buttonLetter.Location = new System.Drawing.Point(83, 284);
            this.buttonLetter.Name = "buttonLetter";
            this.buttonLetter.Size = new System.Drawing.Size(56, 29);
            this.buttonLetter.TabIndex = 5;
            this.buttonLetter.Text = "A";
            this.buttonLetter.UseVisualStyleBackColor = true;
            this.buttonLetter.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(144, 284);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(56, 29);
            this.buttonB.TabIndex = 6;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(266, 284);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(56, 29);
            this.buttonD.TabIndex = 8;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(205, 284);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(56, 29);
            this.buttonC.TabIndex = 7;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(449, 284);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(56, 29);
            this.buttonG.TabIndex = 11;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(388, 284);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(56, 29);
            this.buttonF.TabIndex = 10;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(327, 284);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(56, 29);
            this.buttonE.TabIndex = 9;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttoN
            // 
            this.buttoN.Location = new System.Drawing.Point(449, 319);
            this.buttoN.Name = "buttoN";
            this.buttoN.Size = new System.Drawing.Size(56, 29);
            this.buttoN.TabIndex = 18;
            this.buttoN.Text = "N";
            this.buttoN.UseVisualStyleBackColor = true;
            this.buttoN.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(388, 319);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(56, 29);
            this.buttonM.TabIndex = 17;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(327, 319);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(56, 29);
            this.buttonL.TabIndex = 16;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(266, 319);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(56, 29);
            this.buttonK.TabIndex = 15;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(205, 319);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(56, 29);
            this.buttonJ.TabIndex = 14;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(144, 319);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(56, 29);
            this.buttonI.TabIndex = 13;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(83, 319);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(56, 29);
            this.buttonH.TabIndex = 12;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(327, 388);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(56, 29);
            this.buttonZ.TabIndex = 30;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(266, 388);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(56, 29);
            this.buttonY.TabIndex = 29;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(205, 388);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(56, 29);
            this.buttonX.TabIndex = 28;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(144, 388);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(56, 29);
            this.buttonW.TabIndex = 27;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(83, 388);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(56, 29);
            this.buttonV.TabIndex = 26;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(449, 353);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(56, 29);
            this.buttonU.TabIndex = 25;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(388, 353);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(56, 29);
            this.buttonT.TabIndex = 24;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(327, 353);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(56, 29);
            this.buttonS.TabIndex = 23;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(266, 353);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(56, 29);
            this.buttonR.TabIndex = 22;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(205, 353);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(56, 29);
            this.buttonQ.TabIndex = 21;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(144, 353);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(56, 29);
            this.buttonP.TabIndex = 20;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(83, 353);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(56, 29);
            this.buttonO.TabIndex = 19;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(598, 284);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 56);
            this.buttonStart.TabIndex = 31;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(598, 361);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(120, 56);
            this.buttonAnswer.TabIndex = 32;
            this.buttonAnswer.Text = "ANSWER";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttoN);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonLetter);
            this.Controls.Add(this.textBoxGuesses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "HANGMAN GAME";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGuesses;
        private System.Windows.Forms.Button buttonLetter;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttoN;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAnswer;
    }
}

