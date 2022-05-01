using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Game_X_O.HPlayer;

namespace Game_X_O
{
    public class Area
    {
        public char[,] field_coordinats = new char[3, 3];

        public Area()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field_coordinats[i, j] = '*';
                }
            }
        }

        public void Drow()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{field_coordinats[i,j]}\t");
                }
                Console.WriteLine();
            }                                  
        }
        public void Set(int x, int y, char z)
        {
            field_coordinats[x, y] = z;
        }
    }
}
