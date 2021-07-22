using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int[] Board = new int[9];

        int Difficulty = 0;

        int Turn = -1;

        int LastMove = -1;

        bool EnableBot = false;

        int X = 0;
        int O = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void NewGame()
        {
            for (int i = 0; i < 9; i++)
                Board[i] = 0;
            LastMove = -1;
            EnableBot = false;

            Turn = 1;
            NextTurn();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.UseVisualStyleBackColor = true;
            button2.UseVisualStyleBackColor = true;
            button3.UseVisualStyleBackColor = true;
            button4.UseVisualStyleBackColor = true;
            button5.UseVisualStyleBackColor = true;
            button6.UseVisualStyleBackColor = true;
            button7.UseVisualStyleBackColor = true;
            button8.UseVisualStyleBackColor = true;
            button9.UseVisualStyleBackColor = true;

        }

        private void pVsAIMediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "1P vs AI(Normal)";
            Difficulty = 0;
            NewGame();
        }

        private void pVsAIHardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "1P vs AI(Hard)";
            Difficulty = 1;
            NewGame();
        }

        private void pVs2PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "1P vs 2P";
            Difficulty = 2;
            NewGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[0] == 0)
            {
                LastMove = 0;
                Board[0] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[1] == 0)
            {
                LastMove = 1;
                Board[1] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[2] == 0)
            {
                LastMove = 2;
                Board[2] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[3] == 0)
            {
                LastMove = 3;
                Board[3] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[4] == 0)
            {
                LastMove = 4;
                Board[4] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[5] == 0)
            {
                LastMove = 5;
                Board[5] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[6] == 0)
            {
                LastMove = 6;
                Board[6] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[7] == 0)
            {
                LastMove = 7;
                Board[7] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Turn == 0 || EnableBot)
                return;
            if (Board[8] == 0)
            {
                LastMove = 8;
                Board[8] = Turn;
                ChangeButtonContent(LastMove);
                NextTurn();
                RunBot();
            }
        }

        void NextTurn()
        {
            int Status = CheckStatus();
            if (Status == 2)
            {
                if (Turn == -1)
                {
                    Turn = 1;
                    label1.Text = "𐩒 turn";
                }
                else
                {
                    if (Difficulty != 3 && LastMove == -1)
                    {
                        Turn = -1;
                        label1.Text = "Start new game";
                    }
                    else
                    {
                        Turn = -1;
                        label1.Text = "🗙 turn";
                    }
                }
            }
            else
            {
                if (Status == -1)
                {
                    X++;
                    label2.Text = "🗙: " + X.ToString();
                }
                else if (Status == 1)
                {
                    O++;
                    label3.Text = "◯: " + O.ToString();
                }
                Turn = 0;
                label1.Text = "Game Over";
            }
        }

        int CheckStatus()
        {
            if (Board[0] != 0 && Board[0] == Board[1] && Board[1] == Board[2])
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Green;
                return Board[0];
            }
            else if (Board[3] != 0 && Board[3] == Board[4] && Board[4] == Board[5])
            {
                button4.BackColor = button5.BackColor = button6.BackColor = Color.Green;
                return Board[3];
            }
            else if (Board[6] != 0 && Board[6] == Board[7] && Board[7] == Board[8])
            {
                button7.BackColor = button8.BackColor = button9.BackColor = Color.Green;
                return Board[6];
            }


            else if (Board[0] != 0 && Board[0] == Board[3] && Board[3] == Board[6])
            {
                button1.BackColor = button4.BackColor = button7.BackColor = Color.Green;
                return Board[0];
            }
            else if (Board[1] != 0 && Board[1] == Board[4] && Board[4] == Board[7])
            {
                button2.BackColor = button5.BackColor = button8.BackColor = Color.Green;
                return Board[1];
            }
            else if (Board[2] != 0 && Board[2] == Board[5] && Board[5] == Board[8])
            {
                button3.BackColor = button6.BackColor = button9.BackColor = Color.Green;
                return Board[2];
            }


            else if (Board[0] != 0 && Board[0] == Board[4] && Board[4] == Board[8])
            {
                button1.BackColor = button5.BackColor = button9.BackColor = Color.Green;
                return Board[0];
            }
            else if (Board[2] != 0 && Board[2] == Board[4] && Board[4] == Board[6])
            {
                button3.BackColor = button5.BackColor = button7.BackColor = Color.Green;
                return Board[2];
            }


            else if (Board[0] != 0 && Board[1] != 0 && Board[2] != 0 && Board[3] != 0 && Board[4] != 0 && Board[5] != 0 && Board[6] != 0 && Board[7] != 0 && Board[8] != 0)
            {
                return 0;
            }

            return 2;
        }


        void RunBot()
        {
            if (Difficulty == 2 || Turn == 0)
                return;
            EnableBot = true;

            if (Difficulty == 0)
            {
                RunNormalBot();
            }
            else if (Difficulty == 1)
            {
                RunHardBot();
            }
        }

        void RunNormalBot()
        {
            int Opponent;
            if (Turn == -1) Opponent = 1;
            else Opponent = -1;

            if (LastMove == -1)
            {
                LastMove = RandomPosition();
            }
            else
            {
                FindBestMove(Opponent);
                FindBestMove(Turn);
                if (Board[LastMove] != 0) LastMove = RandomPosition();
            }

            Board[LastMove] = Turn;
            ChangeButtonContent(LastMove);
            EnableBot = false;
            NextTurn();
        }

        void RunHardBot()
        {
            int Opponent;
            if (Turn == -1) Opponent = 1;
            else Opponent = -1;

            if (LastMove == -1)
            {
                if (Board[4] == 0)
                {
                    LastMove = 4;
                }
            }
            else if (Board[LastMove] != 0)
            {
                FindBestMove(Opponent);
                FindBestMove(Turn);
                if (Board[LastMove] != 0)
                {
                    if (LastMove == 4)
                    {
                        if (Board[0] == 0)
                        {
                            LastMove = 0;
                        }
                        else if (Board[2] == 0)
                        {
                            LastMove = 2;
                        }
                        else if (Board[6] == 0)
                        {
                            LastMove = 6;
                        }
                        else if (Board[8] == 0)
                        {
                            LastMove = 8;
                        }
                        else LastMove = RandomPosition();
                    }
                    else if (LastMove == 0 || LastMove == 2 || LastMove == 6 || LastMove == 8)
                    {
                        if (Board[4] == 0)
                        {
                            LastMove = 4;
                        }
                        else if (Board[0] == 0 && Board[8] == Opponent)
                        {
                            LastMove = 0;
                        }
                        else if (Board[2] == 0 && Board[6] == Opponent)
                        {
                            LastMove = 2;
                        }
                        else if (Board[6] == 0 && Board[2] == Opponent)
                        {
                            LastMove = 6;
                        }
                        else if (Board[8] == 0 && Board[0] == Opponent)
                        {
                            LastMove = 8;
                        }
                        else if ((Board[0] == Opponent && Board[8] == Opponent) || (Board[2] == Opponent && Board[6] == Opponent))
                        {
                            if (Board[1] == 0)
                            {
                                LastMove = 1;
                            }
                            else if (Board[3] == 0)
                            {
                                LastMove = 3;
                            }
                            else if (Board[5] == 0)
                            {
                                LastMove = 5;
                            }
                            else if (Board[7] == 0)
                            {
                                LastMove = 7;
                            }
                        }
                        else if (Board[0] == 0)
                        {
                            LastMove = 0;
                        }
                        else if (Board[2] == 0)
                        {
                            LastMove = 2;
                        }
                        else if (Board[6] == 0)
                        {
                            LastMove = 6;
                        }
                        else if (Board[8] == 0)
                        {
                            LastMove = 8;
                        }
                        else LastMove = RandomPosition();
                    }
                    else if (LastMove == 1 || LastMove == 3 || LastMove == 5 || LastMove == 7)
                    {
                        if (Board[4] == 0)
                        {
                            LastMove = 4;
                        }
                        else if (Board[0] == 0 && Board[1] == Opponent && Board[3] == Opponent)
                        {
                            LastMove = 0;
                        }
                        else if (Board[2] == 0 && Board[1] == Opponent && Board[5] == Opponent)
                        {
                            LastMove = 2;
                        }
                        else if (Board[6] == 0 && Board[3] == Opponent && Board[7] == Opponent)
                        {
                            LastMove = 6;
                        }
                        else if (Board[8] == 0 && Board[5] == Opponent && Board[7] == Opponent)
                        {
                            LastMove = 8;
                        }
                        else if (Board[0] == 0 && ((Board[1] == Opponent) || (Board[3] == Opponent)))
                        {
                            LastMove = 0;
                        }
                        else if (Board[2] == 0 && ((Board[1] == Opponent) || (Board[5] == Opponent)))
                        {
                            LastMove = 2;
                        }
                        else if (Board[6] == 0 && ((Board[3] == Opponent) || (Board[7] == Opponent)))
                        {
                            LastMove = 6;
                        }
                        else if (Board[8] == 0 && ((Board[5] == Opponent) || (Board[7] == Opponent)))
                        {
                            LastMove = 8;
                        }
                        else if (Board[0] == 0)
                        {
                            LastMove = 0;
                        }
                        else if (Board[2] == 0)
                        {
                            LastMove = 2;
                        }
                        else if (Board[6] == 0)
                        {
                            LastMove = 6;
                        }
                        else if (Board[8] == 0)
                        {
                            LastMove = 8;
                        }
                        else if (Board[1] == 0)
                        {
                            LastMove = 1;
                        }
                        else if (Board[3] == 0)
                        {
                            LastMove = 3;
                        }
                        else if (Board[5] == 0)
                        {
                            LastMove = 5;
                        }
                        else if (Board[7] == 0)
                        {
                            LastMove = 7;
                        }
                        else LastMove = RandomPosition();
                    }
                }
            }

            Board[LastMove] = Turn;
            ChangeButtonContent(LastMove);
            EnableBot = false;
            NextTurn();
        }

        void FindBestMove(int turn)
        {
            if (Board[0] == 0 && ((Board[1] == turn && Board[2] == turn) || (Board[3] == turn && Board[6] == turn) || (Board[4] == turn && Board[8] == turn)))
                LastMove = 0;
            else if (Board[1] == 0 && ((Board[0] == turn && Board[2] == turn) || (Board[4] == turn && Board[7] == turn)))
                LastMove = 1;
            else if (Board[2] == 0 && ((Board[0] == turn && Board[1] == turn) || (Board[5] == turn && Board[8] == turn) || (Board[4] == turn && Board[6] == turn)))
                LastMove = 2;
            else if (Board[3] == 0 && ((Board[0] == turn && Board[6] == turn) || (Board[4] == turn && Board[5] == turn)))
                LastMove = 3;
            else if (Board[4] == 0 && ((Board[0] == turn && Board[8] == turn) || (Board[2] == turn && Board[6] == turn) || (Board[1] == turn && Board[7] == turn) || (Board[3] == turn && Board[5] == turn)))
                LastMove = 4;
            else if (Board[5] == 0 && ((Board[2] == turn && Board[8] == turn) || (Board[3] == turn && Board[4] == turn)))
                LastMove = 5;
            else if (Board[6] == 0 && ((Board[0] == turn && Board[3] == turn) || (Board[7] == turn && Board[8] == turn) || (Board[2] == turn && Board[4] == turn)))
                LastMove = 6;
            else if (Board[7] == 0 && ((Board[1] == turn && Board[4] == turn) || (Board[6] == turn && Board[8] == turn)))
                LastMove = 7;
            else if (Board[8] == 0 && ((Board[2] == turn && Board[5] == turn) || (Board[6] == turn && Board[7] == turn) || (Board[0] == turn && Board[4] == turn)))
                LastMove = 8;
        }

        int RandomPosition()
        {
            int Count = 0;
            for (var i = 0; i <= 8; i++)
            {
                if (Board[i] == 0)
                {
                    Count++;
                }
            }
            Random rnd = new Random();
            int Random = rnd.Next(1, Count);

            Count = 0;
            for (var i = 0; i <= 8; i++)
            {
                if (Board[i] == 0)
                {
                    Count++;
                    if (Count == Random)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        void ChangeButtonContent(int Position)
        {
            if (Board[Position] == -1)
            {
                switch (Position)
                {
                    case (0): button1.Text = "🗙"; break;
                    case (1): button2.Text = "🗙"; break;
                    case (2): button3.Text = "🗙"; break;
                    case (3): button4.Text = "🗙"; break;
                    case (4): button5.Text = "🗙"; break;
                    case (5): button6.Text = "🗙"; break;
                    case (6): button7.Text = "🗙"; break;
                    case (7): button8.Text = "🗙"; break;
                    case (8): button9.Text = "🗙"; break;
                }
            }
            else if (Board[Position] == 1)
            {
                switch (Position)
                {
                    case (0): button1.Text = "𐩒"; break;
                    case (1): button2.Text = "𐩒"; break;
                    case (2): button3.Text = "𐩒"; break;
                    case (3): button4.Text = "𐩒"; break;
                    case (4): button5.Text = "𐩒"; break;
                    case (5): button6.Text = "𐩒"; break;
                    case (6): button7.Text = "𐩒"; break;
                    case (7): button8.Text = "𐩒"; break;
                    case (8): button9.Text = "𐩒"; break;
                }
            }
            else
            {
                switch (Position)
                {
                    case (0): button1.Text = null; break;
                    case (1): button2.Text = null; break;
                    case (2): button3.Text = null; break;
                    case (3): button4.Text = null; break;
                    case (4): button5.Text = null; break;
                    case (5): button6.Text = null; break;
                    case (6): button7.Text = null; break;
                    case (7): button8.Text = null; break;
                    case (8): button9.Text = null; break;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Difficulty == 2 || LastMove != -1)
                return;

            RunBot();
        }
    }
}
