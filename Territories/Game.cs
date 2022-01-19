using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class Game
    {

        Player p1 = new Player('A');

        Player p2 = new Player('B');
        public Game()
        {
            Board board = new Board();

            run();

            board.paint();

        }

        private void run()
        {

            while(!Wincheck(p1) && !Wincheck(p2))
            {

            }

        }

        private bool Wincheck(Player p)
        {
            bool won = false;

            return won;
        }
    }
}
