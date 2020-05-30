using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        int TurnOfPlayer = 2;
        int turns = 0;
        int Player1Score = 0;
        int Player2Score = 0;
        int DrawScore = 0;

        private void tileClicked(object sender, EventArgs e)
        {
            Button clickedTile = (Button)sender;
            if (clickedTile.Text == "")
            {
                if (TurnOfPlayer % 2 == 0)
                {
                    clickedTile.Text = "X";
                    TurnOfPlayer++; turns++;
                }
                else
                {
                    clickedTile.Text = "O";
                    TurnOfPlayer++; turns++;
                }
            }
            if(CheckDraw())
            {
                MessageBox.Show("Tie Game!");
                DrawScore++;
                NewGame();
            }
            if (CheckWinner()) { 
                if(clickedTile.Text == "X")
                {
                    MessageBox.Show("Player 'X' won!");
                    Player1Score++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show("Player 'O' won!");
                    Player2Score++;
                    NewGame();
                }
            }
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            XWin.Text = "X : " + Player1Score;
            OWin.Text = "O : " + Player2Score;
            Draw.Text = "Draw : " + DrawScore;
        }

        private void NewGame()
        {
            TurnOfPlayer = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X : " + Player1Score;
            OWin.Text = "O : " + Player2Score;
            Draw.Text = "Draw : " + DrawScore;
        }

        bool CheckDraw()
        {
            if (turns == 9 && !CheckWinner())
                return true;
            else
                return false;
            
        }
        bool CheckWinner()
        {
            if((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;

            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;

            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != ""))
                return true;
            else 
                return false;
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            TicTacToeForm.ActiveForm.Close();
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            Player1Score = Player2Score = DrawScore = 0;
            NewGame();
        }
    }
}
