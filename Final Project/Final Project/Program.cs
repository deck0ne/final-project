using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Final_Project
{
    internal class Program
        
    {
        static void Title()
        {
            Console.WriteLine("                              ********************************************");
            Console.WriteLine("                              *                                          *");
            Console.WriteLine("                              *    OBJECT ORIENTED PROGRAM TERM PROJECT  *");
            Console.WriteLine("                              *        INSTRUCTOR  : Mahbub Murshed      *");
            Console.WriteLine("                              *         SUBMITTED BY: Dick Fababi        *");
            Console.WriteLine("                              *                                          *");
            Console.WriteLine("                              ********************************************");
        }
        static void Instruction()
        {
            Console.WriteLine("                              ********************************************");
            Console.WriteLine("                              *                                          *");
            Console.WriteLine("                              *           CONNECT FOUR PROGRAM           *");
            Console.WriteLine("                              *                                          *");
            Console.WriteLine("                              ********************************************");
        }
       class Connect4
        {
            
            private char [,] GameBoard;
            private string PlayerName;

            public Connect4()
            {
                GameBoard = new char[6, 7];
                PlayerName = "";
                Initialize();
            }
            private void Initialize()
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        GameBoard[i, j] = ' ';
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
                        Console.Write(" | " + GameBoard[i, j]);
                    }
                    Console.WriteLine(" | ");
                    Console.WriteLine("---------------");
                }
            }
        }
       class Player1
        {
            public string name;
        }
        class Player2:Player1
        {

        }
        static void Main(string[] args)
        {


            Title();
            Instruction();
            Connect4 p = new Connect4();
            Console.ReadLine();
            bool PlayAgain=false;
            do
            {

            } while (PlayAgain);

        } 
    }
}
