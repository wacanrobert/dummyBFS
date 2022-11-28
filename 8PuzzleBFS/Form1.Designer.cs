namespace _8PuzzleBFS
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
            this.pnl = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNoOfMoves = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.button9);
            this.pnl.Controls.Add(this.button8);
            this.pnl.Controls.Add(this.button7);
            this.pnl.Controls.Add(this.button6);
            this.pnl.Controls.Add(this.button5);
            this.pnl.Controls.Add(this.button4);
            this.pnl.Controls.Add(this.button3);
            this.pnl.Controls.Add(this.button2);
            this.pnl.Controls.Add(this.button1);
            this.pnl.Location = new System.Drawing.Point(224, 8);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(339, 433);
            this.pnl.TabIndex = 9;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(214, 261);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 78);
            this.button9.TabIndex = 27;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(130, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 78);
            this.button8.TabIndex = 26;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(46, 261);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 78);
            this.button7.TabIndex = 25;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(214, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 78);
            this.button6.TabIndex = 24;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 78);
            this.button5.TabIndex = 23;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 78);
            this.button4.TabIndex = 22;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 78);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 78);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 78);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNoOfMoves
            // 
            this.lblNoOfMoves.AutoSize = true;
            this.lblNoOfMoves.Location = new System.Drawing.Point(597, 63);
            this.lblNoOfMoves.Name = "lblNoOfMoves";
            this.lblNoOfMoves.Size = new System.Drawing.Size(44, 16);
            this.lblNoOfMoves.TabIndex = 10;
            this.lblNoOfMoves.Text = "label1";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(632, 201);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 23);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(632, 239);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 23);
            this.btnSolve.TabIndex = 12;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblNoOfMoves);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblNoOfMoves;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSolve;
    }
}

