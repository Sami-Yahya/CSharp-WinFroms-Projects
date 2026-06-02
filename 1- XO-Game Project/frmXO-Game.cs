using System;
using System.Drawing;
using System.Windows.Forms;
using XO_Game_Project.Properties;

namespace XO_Game_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.Text = $"X = {e.X} , Y = {e.Y}";
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen whitePen = new Pen(White);
            whitePen.Width = 10;

            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }
        
        private readonly Random _rnd = new Random();

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        string Player1Name = "Player 1";
        string Player2Name = "Player 2";

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }

        private bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        private void CheckWinner()
        {
            //checked rows
            //check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal
            //check Diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = Player1Name;
                    break;

                case enWinner.Player2:
                    lblWinner.Text = Player2Name;
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableAllButtons();
        }

        private void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = Player2Name;
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = Player1Name;
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                if (GameStatus.GameOver == false) //it checks that there is no a winner in the last choice
                {
                    GameStatus.GameOver = true;
                    GameStatus.Winner = enWinner.Draw;
                    EndGame();
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);

            if (btnComputerTurn.Enabled == false && GameStatus.PlayCount != 9)
            {
                btnComputerTurn.Enabled = true;
            }

            /* 
            // if you want the computer play its turn automatically without pressing on its button!

            if (PlayerTurn == enPlayer.Player2)
            {
                btnComputerTurn.PerformClick();
            } 
            */
        }

        private void DisableAllButtons()
        {
            for (byte i = 1; i <= 9; i++)
            {
                this.Controls["button" + i].Enabled = false;
            }

            btnComputerTurn.Enabled = false;
        }

        private void EnableAllButtons()
        {
            for (byte i = 1; i <= 9; i++)
            {
                this.Controls["button" + i].Enabled = true;
            }

            btnComputerTurn.Enabled = false; //default status for this button is Disable
        }

        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void RestartGame()
        {
            for (byte i = 1; i <= 9; i++)
            {
                ResetButton((Button)this.Controls["button" + i]);
            }


            EnableAllButtons();
            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = Player1Name;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }


        private void ChooseRandomButton()
        {
            Button rndButton;
            int index;

            do
            {
                index = _rnd.Next(1, 10);
                rndButton = (Button)this.Controls["button" + index];

            } while (rndButton.Tag.ToString() != "?");

            rndButton.PerformClick();
        }

        private bool CheckOWinMove(Button btn1, Button btn2, Button ChosenButton)
        {
            if (ChosenButton.Tag.ToString() != "?")
                return false;

            if (btn1.Tag.ToString() == "O" && btn2.Tag.ToString() == "O")
            {
                ChosenButton.PerformClick();
                return true;
            }

            return false;
        }

        private bool CheckXBlockMove(Button btn1, Button btn2, Button ChosenButton)
        {
            if (ChosenButton.Tag.ToString() != "?")
                return false;

            if (btn1.Tag.ToString() == "X" && btn2.Tag.ToString() == "X")
            {
                ChosenButton.PerformClick();
                return true;
            }

            return false;
        }

        private bool CheckAllCombinations(Func<Button, Button, Button, bool> checkFunc)
        {
            // Diagonals
            if (checkFunc(button1, button5, button9)) return true;
            if (checkFunc(button3, button5, button7)) return true;
            if (checkFunc(button9, button5, button1)) return true;
            if (checkFunc(button7, button5, button3)) return true;

            // Middle diagonal
            if (checkFunc(button1, button9, button5)) return true;
            if (checkFunc(button3, button7, button5)) return true;

            // Rows
            if (checkFunc(button1, button2, button3)) return true;
            if (checkFunc(button4, button5, button6)) return true;
            if (checkFunc(button7, button8, button9)) return true;
            if (checkFunc(button3, button2, button1)) return true;
            if (checkFunc(button6, button5, button4)) return true;
            if (checkFunc(button9, button8, button7)) return true;

            // Cols
            if (checkFunc(button1, button4, button7)) return true;
            if (checkFunc(button2, button5, button8)) return true;
            if (checkFunc(button3, button6, button9)) return true;
            if (checkFunc(button7, button4, button1)) return true;
            if (checkFunc(button8, button5, button2)) return true;
            if (checkFunc(button9, button6, button3)) return true;

            // Middle rows
            if (checkFunc(button1, button3, button2)) return true;
            if (checkFunc(button4, button6, button5)) return true;
            if (checkFunc(button7, button9, button8)) return true;

            // Middle cols
            if (checkFunc(button1, button7, button4)) return true;
            if (checkFunc(button2, button8, button5)) return true;
            if (checkFunc(button3, button9, button6)) return true;

            return false;
        }

        private void HardLevel()
        {
            // First: Can computer win?
            if (CheckAllCombinations(CheckOWinMove))
                return;

            // Second: Can computer block the player?
            if (CheckAllCombinations(CheckXBlockMove))
                return;

            // None of above: Play randomly
            ChooseRandomButton();
        }

        void ComputerTurn()
        {
            if (rbComputer.Checked == true)
            {
                if (rbEasy.Checked == true)
                {
                    ChooseRandomButton();
                }

                if (rbHard.Checked == true)
                {
                    HardLevel();
                }
            }
        }

        private void rbComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComputer.Checked)
            {
                gbLevel.Visible = true;
                btnComputerTurn.Visible = true;
            }

            Player1Name = "You";
            Player2Name = "Computer";
            RestartGame();
        }

        private void rbYou_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYourself.Checked)
            {
                gbLevel.Visible = false;
                btnComputerTurn.Visible = false;
            }

            Player1Name = "Player 1";
            Player2Name = "Player 2";
            RestartGame();
        }

        private void btnComputerTurn_Click(object sender, EventArgs e)
        {
            ComputerTurn();
            btnComputerTurn.Enabled = false;
        }

    }
}
