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
        public static bool turn = false;
        public static int turnNum;
        public static int xWins;
        public static int oWins;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;

            if (btn.Text == "")
            {
                turnNum++;
                turn = !turn;
                string turnStr = "X";
                if (turn == true)
                {
                    turnStr = "O";
                }
                if (turn == false)
                {
                    turnStr = "X";
                }
                turnValue.Text = ("Turn: " + turnStr);
            }
            if (turn && btn.Text == "")
            {
                btn.Text = "X";
            }
            if (turn == false && btn.Text == "")
            {
                btn.Text = "O";
            }
            CheckWinner();
        }
        private void CheckWinner()
        {
            
            ///HORIZONTAL CHECK FOR X
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X"
                || B1.Text == "X" && B2.Text == "X" && B3.Text == "X"
                || C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
            {
                MessageBox.Show("X WINS", "WOOHOO");
                xWins++;
                xPointLabel.Text = xWins.ToString();
                NewGame(this);
            }
            ///HORIZONTAL CHECK FOR O
            if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O"
                || B1.Text == "O" && B2.Text == "O" && B3.Text == "O"
                || C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
            {
                oWins++;
                oPointLabel.Text = oWins.ToString();
                MessageBox.Show("O WINS", "WOOHOO");
                NewGame(this);
            }

            //VERTICAL CHECK FOR X
            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X"
                || A2.Text == "X" && B2.Text == "X" && C2.Text == "X"
                || A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
            {
                xWins++;
                xPointLabel.Text = xWins.ToString();
                MessageBox.Show("X WINS", "WOOHOO");
                NewGame(this);
            }
            //VERTICAL CHECK FOR O
            if (A1.Text == "O" && B1.Text == "O" && C1.Text == "O"
                || A2.Text == "O" && B2.Text == "O" && C2.Text == "O"
                || A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
            {
                oWins++;
                oPointLabel.Text = oWins.ToString();
                MessageBox.Show("O WINS", "WOOHOO");
                NewGame(this);
            }

            //DIAGONAL CHECK FOR X
            if (A1.Text == "X" && B2.Text == "X" && C3.Text == "X"
                || A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
            {
                xWins++;
                xPointLabel.Text = xWins.ToString();
                MessageBox.Show("X WINS", "WOOHOO");
                NewGame(this);
            }
            //DIAGONAL CHECK FOR O
            if (A1.Text == "O" && B2.Text == "O" && C3.Text == "O"
                || A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
            {
                oWins++;
                oPointLabel.Text = oWins.ToString();
                MessageBox.Show("O WINS", "WOOHOO");
                NewGame(this);
            }
            //DRAW!
            if (turnNum > 8)
            {
                MessageBox.Show("Draw!", "Amazing.");
                NewGame(this);
            }
        }

        private void NewGame(Form form)
        {
            turnNum = 0;
            foreach(Control control in form.Controls)
            {
                if (control is Button && control.Text == "X" || control.Text == "O")
                {
                    control.Text = "";
                }
            }
        }

        private void FormKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'n')
            {
                NewGame(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame(this);
        }
    }
}
