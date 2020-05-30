using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            XWin.Text = "X : " + Player1Score;
            OWin.Text = "O : " + Player2Score;
            Draw.Text = "Draw : " + DrawScore;
        }
    }
}
