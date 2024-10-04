


using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace morpion_nimzarrabi
{
    internal class Program
    {
        static List<Square> squares = new();

        //silkyWay[0, 0] = true; // A1
        //silkyWay[7, 7] = true; // H8

        const int DISTANCEGAUCHE = 2;                             // Distance du plateau de jeu depuis la gauche
        const int DISTANCEHAUT = 1;                               // Distance du plateau de jeu depuis le haut
        const int GRANDPLATEAU = 16;                              // Grandeur du plateau de jeu                                           // character pour le coin au bas à gauche du plateau de jeu
        const int TAILREELPLATEAU = 3;                            // grandeur réel de chaque case du plateau de jeu horizontalement
        
        static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '&' };

        static void Main(string[] args)
        {
            DrawBoard();

            // Affichage du plateau de jeu

        }


        static void ToDo()
        {
            // TODO Put silk on 30 more squares

            DrawBoard();

            // TODO Create a data structure that allow us to remember which square has already been tested

            // TODO Create a data structure that allow us to remember the successful steps

            // TODO Write the recursive function
            // Recursive function that tells if we can reach H8 from the given position
            // The algorithm is in fact simple to spell out (even in french ;)):
            //
            //      Je peux sortir depuis cette case si:
            //          1. Je suis sur H8
            //
            //              ou
            //
            //          2. Je peux sortir depuis une des cases où je peux aller (et où je ne suis pas encore allé)

            // TODO Call the function and show the results

            Console.ReadLine();
        }

        static void DrawBoard()
        {

            int posL = Console.GetCursorPosition().Left + DISTANCEGAUCHE;

            int posT = Console.GetCursorPosition().Top + DISTANCEHAUT;

            for (int i = 0; i < GRANDPLATEAU; i++)
            {
                // +1 so number are centered
                Console.SetCursorPosition(posL + 1, posT);
                Console.Write(alphabet[i]);
                posL = posL + TAILREELPLATEAU;
            }
            posL = posL - (GRANDPLATEAU * TAILREELPLATEAU);
            posT++;

            int finish = new Random().Next(GRANDPLATEAU* GRANDPLATEAU);

            for (int a = 0; a < GRANDPLATEAU; a++)
            {
                for (int b = 0; b < GRANDPLATEAU; b++)
                {
                    squares.Add(new Square(b, posL + b, posT + a, false, ' ', TAILREELPLATEAU));
                    
                }

            }

            foreach (Square square in squares)
            {
                /*
                Square.DrawSquare(square);
                if (square.id < 9)
                {
                    Console.Write("  " + (a + 1));
                }
                else
                {
                    Console.Write(" " + (a + 1));
                }*/
            }

            /*
            for (int a = 0; a < GRANDPLATEAU; a++)
            {
                for (int b = 0; b < GRANDPLATEAU; b++)
                {
                    DrawSquare(posL + b * TAILREELPLATEAU, posT);

                }
   
            }*/


        }
        static void DrawSquare(int L, int T)
        {
            Console.SetCursorPosition(L, T);
            for (int a = 0; a < TAILREELPLATEAU; a++)
            {
                if (T % 2 == 0)
                {
                    if (L % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    }
                }
                else
                if (L % 2 != 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                Console.Write("X");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}