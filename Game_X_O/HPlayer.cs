using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_X_O
{
    internal class HPlayer : IPlayer
    {
        public const char playerX = 'X';
        private readonly Area area;

        public HPlayer(Area area)
        {
            this.area = area ?? throw new ArgumentNullException(nameof(area));
        }
        public void Turn()
        {
            int x;
            int y;
            bool validate = false;           
            while (!validate)
            {
                Console.WriteLine("enter the x, y coordinate for the step");
                string str = Console.ReadLine();
                string[] v = str.Split(new char[] { ',' });
                if (int.TryParse(v[0], out x) && int.TryParse(v[1], out y))
                {
                    if (Validate(x-1, y-1))
                    {
                        area.Set(x - 1, y - 1, playerX);
                        validate = true;
                    }
                }
            }                                                
        }

        public bool Validate(int x, int y)
        {          
                if (x < 0 || x > 3 || y < 0 || y > 3)
                    return false;
                else if (area.f[x, y] != '*')
                    return false;
                else
                    return true;
        }


    }
}
