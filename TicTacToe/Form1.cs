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
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }

        Player currentPlayer;

        List<Button> btns;
        Random rand = new Random();
        int playerWins = 0;
        int computerWins = 0;
        int draw = 0;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void PClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            currentPlayer = Player.X;
            btn.Text = currentPlayer.ToString();
            btn.Enabled = false;
            btn.BackColor = System.Drawing.Color.Green;
            btns.Remove(btn);
            counter++;
            Check();
            CPUmoves.Start();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (btns.Count > 0)
            {
                int index = rand.Next(btns.Count);
                btns[index].Enabled = false;

                currentPlayer = Player.O;
                btns[index].Text = currentPlayer.ToString();
                btns[index].BackColor = System.Drawing.Color.Red;
                btns.RemoveAt(index);
                counter++;
                Check();
                CPUmoves.Stop();

            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadbuttons()
        {
            btns = new List<Button> { NorthWest, North, NorthEast, West, Center, East, SouthWest, South, SouthEast };
        }
        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "-";
                    ((Button)X).BackColor = default(Color);
                }


            }

            loadbuttons();
        }



        private void Check()
        {
            if (NorthWest.Text == "X" && North.Text == "X" && NorthEast.Text == "X"
                || West.Text == "X" && Center.Text == "X" && East.Text == "X"
                || SouthWest.Text == "X" && South.Text == "X" && SouthEast.Text == "X"
                || NorthWest.Text == "X" && West.Text == "X" && SouthWest.Text == "X"
                || North.Text == "X" && Center.Text == "X" && South.Text == "X"
                || NorthEast.Text == "X" && East.Text == "X" && SouthEast.Text == "X"
                || NorthWest.Text == "X" && Center.Text == "X" && SouthEast.Text == "X"
                || NorthEast.Text == "X" && Center.Text == "X" && SouthWest.Text == "X")
            {
                CPUmoves.Stop();
                MessageBox.Show("Player Wins");
                playerWins++;
                Pwin.Text = "Player Win(s)- " + playerWins;
                counter = 0;
                resetGame();
            }

            else if (NorthWest.Text == "O" && North.Text == "O" && NorthEast.Text == "O"
                || West.Text == "O" && Center.Text == "O" && East.Text == "O"
                || SouthWest.Text == "O" && South.Text == "O" && SouthEast.Text == "O"
                || NorthWest.Text == "O" && West.Text == "O" && SouthWest.Text == "O"
                || North.Text == "O" && Center.Text == "O" && South.Text == "O"
                || NorthEast.Text == "O" && East.Text == "O" && SouthEast.Text == "O"
                || NorthWest.Text == "O" && Center.Text == "O" && SouthEast.Text == "O"
                || NorthEast.Text == "O" && Center.Text == "O" && SouthWest.Text == "O")
            {
                CPUmoves.Stop();
                MessageBox.Show("Computer Wins");
                computerWins++;
                Cwin.Text = "CPU Win(s)- " + computerWins;
                counter = 0;
                resetGame();
            }

            if (counter == 9)
            {
                CPUmoves.Stop();
                MessageBox.Show("Draw");
                draw++;
                Dwin.Text = "Draw(s)- " + draw;
                resetGame();
            }
            
        }

        private void Dwin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pwin_Click(object sender, EventArgs e)
        {

        }
    }
}

