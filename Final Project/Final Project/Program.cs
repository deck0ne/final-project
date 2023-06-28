using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Final_Project
{
    internal class Program

    {
        public class Title
        {
            /*
            public Title()
            {
                Console.WriteLine("                              ********************************************");
                Console.WriteLine("                              *                                          *");
                Console.WriteLine("                              *    OBJECT ORIENTED PROGRAM TERM PROJECT  *");
                Console.WriteLine("                              *        INSTRUCTOR  : Mahbub Murshed      *");
                Console.WriteLine("                              *         SUBMITTED BY: Dick Fababi        *");
                Console.WriteLine("                              *                                          *");
                Console.WriteLine("                              ********************************************");
            }
            */
            public virtual void smallTitle()
            {
                Console.WriteLine("Fababi");
            }



        }

        public class Instruction : Title
        {
            public override void smallTitle()
            {
                Console.WriteLine("                              ********************************************");
                Console.WriteLine("                              *                                          *");
                Console.WriteLine("                              *    OBJECT ORIENTED PROGRAM TERM PROJECT  *");
                Console.WriteLine("                              *        INSTRUCTOR  : Mahbub Murshed      *");
                Console.WriteLine("                              *         SUBMITTED BY: Dick Fababi        *");
                Console.WriteLine("                              *                                          *");
                Console.WriteLine("                              ********************************************");


                Console.WriteLine("                              ********************************************");
                Console.WriteLine("                              *                                          *");
                Console.WriteLine("                              *            Connect Four Game             *");
                Console.WriteLine("                              *              Press Any Key               *");
                Console.WriteLine("                              *                                          *");
                Console.WriteLine("                              ********************************************");
            }

        }

        class ConnectFour
        {
            private char[,] board;
            private int Player;

            public ConnectFour()
            {
                board = new char[6, 7];
                Player = 1;
                Initialize();
            }

            public void Play(Player1 namePlayer, Player1 namePlayer2)
            {
                bool gameover = false;
                int row, column;


                while (!gameover)
                {
                    BoardLayout();

                    if (Player == 1)
                        Console.Write("Player: " + namePlayer.name + ", choose a column 1-7 : ");
                    else
                        Console.Write("Player: " + namePlayer2.name + ", choose a column 1-7 : ");



                    column = Convert.ToInt32(Console.ReadLine()) - 1;


                    row = PlayersMove(column);

                    if (CheckWin(row, column))
                    {
                        BoardLayout();
                        if (Player == 1)
                            Console.Write("Player " + namePlayer.name + " wins!");
                        else
                            Console.Write("Player " + namePlayer2.name + " wins!");
                        gameover = true;
                    }
                    else if (IsBoardFull())
                    {
                        BoardLayout();
                        Console.WriteLine("It's a draw!");
                        gameover = true;
                    }

                    Player = (Player == 1) ? 2 : 1;
                }
            }

            private void Initialize()
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        board[i, j] = ' ';
                    }
                }
            }

            private void BoardLayout()
            {
                Console.Clear();

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write("| " + board[i, j]);
                    }

                    Console.WriteLine("| ");
                    Console.WriteLine("----------------------");

                }
                Console.WriteLine("-1--2--3--4--5--6--7--");
            }


            private int PlayersMove(int column)
            {
                int row = 5;

                while (row >= 0)
                {
                    if (board[row, column] == ' ')
                    {
                        board[row, column] = Player == 1 ? 'X' : 'O';
                        break;
                    }

                    row--;
                }

                return row;
            }

            private bool CheckWin(int row, int column)
            {
                char symbol = Player == 1 ? 'X' : 'O';

                // Check vertical
                int count = 1;
                count += WinPattern(row, column, -1, 0);
                count += WinPattern(row, column, 1, 0);
                if (count >= 4)
                    return true;

                // Check horizontal
                count = 1;
                count += WinPattern(row, column, 0, -1);
                count += WinPattern(row, column, 0, 1);
                if (count >= 4)
                    return true;

                // Check diagonal /
                count = 1;
                count += WinPattern(row, column, -1, -1);
                count += WinPattern(row, column, 1, 1);
                if (count >= 4)
                    return true;

                // Check diagonal \
                count = 1;
                count += WinPattern(row, column, -1, 1);
                count += WinPattern(row, column, 1, -1);
                if (count >= 4)
                    return true;

                return false;
            }

            private int WinPattern(int row, int column, int rowStep, int colStep)
            {
                int count = 0;
                char symbol = Player == 1 ? 'X' : 'O';

                int newRow = row + rowStep;
                int newCol = column + colStep;

                while (newRow >= 0 && newRow < 6 && newCol >= 0 && newCol < 7 && board[newRow, newCol] == symbol)
                {
                    count++;
                    newRow += rowStep;
                    newCol += colStep;
                }

                return count;
            }

            private bool IsBoardFull()
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (board[i, j] == ' ')
                            return false;
                    }
                }
                return true;
            }
        } 

        class Player1
        {
            public string name;

            public Player1(string Name)
            {
                name = Name;
            }

        }


        static void Main(string[] args)
        {


            Title theInstruction = new Instruction();
            string playername;
            string playername2;

            bool PlayAgain = false;
            ConnectFour PresentGame = new ConnectFour();

            theInstruction.smallTitle();
            Console.WriteLine("\n \n \n \n");
            Console.Write("        Please input 1st player name: ");
            playername = Console.ReadLine();

            Player1 player = new Player1(playername);

            Console.Write("        Please input 2nd player name: ");
            playername2 = Console.ReadLine();
            Player1 player2 = new Player1(playername2);

            do
            {
                PresentGame.Play(player, player2);
            } while (PlayAgain);



        }

    }
}
