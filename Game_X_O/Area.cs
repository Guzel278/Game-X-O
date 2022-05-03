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
        public char[,] f = new char[3, 3];

        public Area()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    f[i, j] = '*';
                }
            }
        }

        public void Draw()
        {           
           //┌─1─2─3─┐
           //1 X * * │
           //2 * X * │
           //3 * *X  │
           //└───────┘
            Console.WriteLine($"┌─1─2─3─┐\r\n1 {f[0, 0]} {f[0, 1]} {f[0, 2]} │");
            Console.WriteLine($"2 {f[1, 0]} {f[1, 1]} {f[1, 2]} │");
            Console.WriteLine($"3 {f[2, 0]} {f[2, 1]} {f[2, 2]} │");
            Console.WriteLine("└───────┘");
        }
        public void Set(int x, int y, char z)
        {
            f[x, y] = z;
        }
    }
}
