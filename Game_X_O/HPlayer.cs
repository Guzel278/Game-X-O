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
            Console.WriteLine("enter the x coordinate for the step");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y coordinate for the step");
            int y = int.Parse(Console.ReadLine());
            if (Validate(x-1, y-1))
                area.Set(x-1, y-1, playerX);
            else
            {
                Console.WriteLine("please enter other coordinates");
                Turn();
            }
               
        }

        public bool Validate(int x, int y)
        {
            if (x < 0 || x > 3 || y < 0 || y > 3)
                return false;
            else if (area.field_coordinats[x,y] != '*')
               return false;
            else
                return true;
        }


    }
}
