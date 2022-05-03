using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_X_O
{
    internal class CPlayer : IPlayer
    {
        public const char playerO = 'O';
        private readonly Area area;

        public CPlayer(Area area)
        {
            this.area = area ?? throw new ArgumentNullException(nameof(area));
        }

        public void Turn()
        {
            Search();
            //area.Drow();
        }

        public void Search()
        {
            bool set_O = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(area.f[i, j] == '*')
                    {
                       // area.field_coordinats[i, j] = playerO;
                        area.Set(i,j,playerO);
                        set_O= true;
                        break;
                    }
                    if (set_O)
                        break;                  
                }
                if (set_O)
                    break;
            }
        }

    }
}
