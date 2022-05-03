using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_X_O
{
    public class Game
    {
        public void DoGame()
        {           
            Area area = new Area();
            area.Draw();
            HPlayer hPlayer = new HPlayer(area);
            CPlayer cPlayer = new CPlayer(area);
            while(CheckContinue(area) && CheckWin(area) == '*' )
            {
                hPlayer.Turn();
                cPlayer.Turn();
                area.Draw();                         
            }
            char chckWin = CheckWin(area);
            if (chckWin == 'X')
                Console.WriteLine("player X won");
            else if (chckWin == 'O')
                Console.WriteLine("player O won");
            else
                Console.WriteLine("won a draw");

        }

        public bool CheckContinue(Area area)
        {
            bool found = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (area.f[i, j] == '*')
                    {                       
                       found = true;
                       return true;
                    }
                    if (found)
                        break;
                }
                if (found)
                    break;
            }
            return false;
        }
        public char CheckWin(Area area)
        {
            var f = area.f;
            for (int i = 0, j = 0; i < 3; i++)
            {
                if (f[i, j] == f[i, j + 1] && f[i, j] == f[i, j + 2])
                    return area.f[i, j];          
            }
            for (int j = 0, i = 0; j < 3; j++)
            {
                if (f[i, j] == f[i+1, j] && f[i, j] == f[i+2, j])
                    return area.f[i, j];
            }
            if (f[0, 0] == f[1, 1] &&f[0, 0] == f[2, 2])
                return f[0, 0];
            else if (f[2, 0] == f[1, 1] && f[0, 0] == f[0, 1])
                return f[2, 0];
            
            else
                return '*';

        }
    }
}
