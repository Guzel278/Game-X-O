using System;

namespace Game_X_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Area area = new Area();
            //area.Drow();
            //HPlayer hPlayer = new HPlayer(area);          
            //hPlayer.Turn();
            //area.Drow();
            Game game = new Game();
            game.DoGame();

        }
    }
}
