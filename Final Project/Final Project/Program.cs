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
            public void BoardLayout()
            {
                Console.Clear();

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write("| " + GameBoard[i, j]);
                    }

                    Console.WriteLine("| ");
                    Console.WriteLine("----------------------");

                }
                Console.WriteLine("-1--2--3--4--5--6--7--");
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
            
            Console.ReadLine();
            bool PlayAgain=false;
            do
            {
                Connect4 connect4 = new Connect4(); 
            } while (PlayAgain);

        } 
    }
}
