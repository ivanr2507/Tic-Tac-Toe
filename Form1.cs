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
        /// <summary>
        /// when game buttons are clicked...
        /// </summary>
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string turnStr = "X";//initialize turnstring for the turn tracker
            if (turn && btn.Text == "") //if X's turn, and space empty
            {
                turnNum++;
                turn = !turn;
                btn.Text = "X";
                turnStr = "O";
            }
            if (turn == false && btn.Text == "")
            {
                turnNum++; //iterate turn counter
                turn = !turn;
                btn.Text = "O";
                turnStr = "X";
            }
            turnValue.Text = ("Turn: " + turnStr);
            CheckWinner();
        }
        private void CheckWinner()
        {
            /////////////
            ///O check///
            /////////////
            if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O"
                || B1.Text == "O" && B2.Text == "O" && B3.Text == "O"
                || C1.Text == "O" && C2.Text == "O" && C3.Text == "O"
                //vertical//
                || A1.Text == "O" && B1.Text == "O" && C1.Text == "O"
                || A2.Text == "O" && B2.Text == "O" && C2.Text == "O"
                || A3.Text == "O" && B3.Text == "O" && C3.Text == "O"
                //diagonal//
                || A1.Text == "O" && B2.Text == "O" && C3.Text == "O"
                || A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
            {
                oWins++;
                oPointLabel.Text = oWins.ToString();
                MessageBox.Show("O WINS", "WOOHOO");
                NewGame(this);
            }
            /////////////
            ///X CHECK///
            /////////////
            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X"
                || A2.Text == "X" && B2.Text == "X" && C2.Text == "X"
                || A3.Text == "X" && B3.Text == "X" && C3.Text == "X"
                //horizontal//
                || A1.Text == "X" && A2.Text == "X" && A3.Text == "X"
                || B1.Text == "X" && B2.Text == "X" && B3.Text == "X"
                || C1.Text == "X" && C2.Text == "X" && C3.Text == "X"
                //diagonal//
                || A1.Text == "X" && B2.Text == "X" && C3.Text == "X"
                || A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
            {
                xWins++;
                xPointLabel.Text = xWins.ToString();
                MessageBox.Show("X WINS", "WOOHOO");
                NewGame(this);
            }
            ///DRAW!///
            if (turnNum > 8)
            {
                MessageBox.Show("Draw!", "Amazing.");
                NewGame(this);
            }
        }

        /// <summary>
        /// RESTARTS GAME, ITERATES OVER EVERY CONTROL AND 
        /// CHANGES GAME BUTTONS TO BLANK
        /// </summary>
        /// <param name="form"></param>
        private void NewGame(Form form)
        {
            turnNum = 0;
            foreach(Control control in form.Controls)
            {
                //if control is a button and is not the control buttons!
                if (control is Button 
                    && control.Text != "[N]ew" && control.Text != "[R]eset") 
                {
                    control.Text = "";
                }
            }
        }
        private void resetPoints(Form form)
        {
            xWins = 0;
            oWins = 0;
            oPointLabel.Text = oWins.ToString();
            xPointLabel.Text = xWins.ToString();

            NewGame(this);
        }
        private void FormKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'n') // starts new game when user presses 'n'
            {
                NewGame(this);
            }
            if (e.KeyChar == 'r') // reset game
            {
                //resets points
                resetPoints(this);
            }
        }
        private void button1_Click(object sender, EventArgs e)//new button
        {
            NewGame(this);
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            resetPoints(this);
        }
    }
}
