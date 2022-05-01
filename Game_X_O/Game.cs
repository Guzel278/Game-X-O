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
            area.Drow();
            HPlayer hPlayer = new HPlayer(area);
            CPlayer cPlayer = new CPlayer(area);
            while(CheckContinue(area))
            {
                hPlayer.Turn();
                cPlayer.Turn();
                area.Drow();                         
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
                    if (area.field_coordinats[i, j] == '*')
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
            for (int i = 0, j = 0; i < 3; i++)
            {
                if (area.field_coordinats[i, j] == area.field_coordinats[i, j + 1] && area.field_coordinats[i, j] == area.field_coordinats[i, j + 2])
                    return area.field_coordinats[i, j];          
            }
            for (int j = 0, i = 0; j < 3; j++)
            {
                if (area.field_coordinats[i, j] == area.field_coordinats[i+1, j] && area.field_coordinats[i, j] == area.field_coordinats[i+2, j])
                    return area.field_coordinats[i, j];
            }
            if (area.field_coordinats[0, 0] == area.field_coordinats[1, 1] && area.field_coordinats[0, 0] == area.field_coordinats[2, 2])
                return area.field_coordinats[0, 0];
            else if (area.field_coordinats[2, 0] == area.field_coordinats[1, 1] && area.field_coordinats[0, 0] == area.field_coordinats[0, 1])
                return area.field_coordinats[2, 0];
            
            else
                return '*';

        }
    }
}
