using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square
    {
        int id;
        int multiplier;
        int posX;
        int posY;
        bool finishLine;
        char icon;

        internal Square(int id,int X, int Y, bool finish, char icon, int multiplier)
        {
            this.id = id;
            this.posX = X;
            this.posY = Y;
            this.finishLine = finish;
            this.icon = icon;
            this.multiplier = multiplier;
        }

        static internal void DrawSquare(Square square)
        {
            if ( square.posY % 2 == 0)
            {
                if (square.posX % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
            }
            else
            if (square.posX % 2 != 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }

            for (int i = 0; i < square.multiplier; i++)
            {
                Console.SetCursorPosition((square.posX * square.multiplier) - 1 - square.multiplier + i, square.posY);
                Console.Write(square.icon);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
