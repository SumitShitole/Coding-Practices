namespace TicTacToe
{
    partial class TicTacToeForm
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
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 47);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(83, 75);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.tileClicked);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 128);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(83, 75);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.tileClicked);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 209);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(83, 75);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.tileClicked);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(101, 209);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(83, 75);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.tileClicked);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(101, 128);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(83, 75);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.tileClicked);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(101, 47);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(83, 75);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.tileClicked);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(190, 209);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(83, 75);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.tileClicked);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(190, 128);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(83, 75);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.tileClicked);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(190, 47);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(83, 75);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.tileClicked);
            // 
            // NGButton
            // 
            this.NGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGButton.Location = new System.Drawing.Point(12, 309);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(83, 37);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            // 
            // RButton
            // 
            this.RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButton.Location = new System.Drawing.Point(101, 309);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(83, 37);
            this.RButton.TabIndex = 10;
            this.RButton.Text = "Reset";
            this.RButton.UseVisualStyleBackColor = true;
            // 
            // EButton
            // 
            this.EButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.Location = new System.Drawing.Point(190, 309);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(83, 37);
            this.EButton.TabIndex = 11;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = true;
            // 
            // XWin
            // 
            this.XWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.XWin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XWin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.XWin.Location = new System.Drawing.Point(12, 9);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(83, 23);
            this.XWin.TabIndex = 12;
            this.XWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OWin
            // 
            this.OWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OWin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OWin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OWin.Location = new System.Drawing.Point(101, 9);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(83, 23);
            this.OWin.TabIndex = 13;
            this.OWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Draw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Draw.Location = new System.Drawing.Point(190, 9);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(83, 23);
            this.Draw.TabIndex = 14;
            this.Draw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 358);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toc by Sumit";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draw;
    }
}

