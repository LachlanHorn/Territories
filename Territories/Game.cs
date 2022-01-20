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

        Board board = new Board();
        public Game()
        {
            board.paint();
            run();

            

        }

        private void run()
        {

            while(!Wincheck(p1) && !Wincheck(p2))
            {
                p1.place(board);
                board.paint();
                
                p2.place(board);
                board.paint();
            }

        }

        private bool Wincheck(Player p)
        {
            bool won = false;

            int charcount = 0;

            for (int x = 0; x < board.board.GetLength(0); x++)
            {

                for (int y = 0; y < board.board.GetLength(1); y++)
                {
                    
                    if(board.board[x,y].Team == p.Team)
                    {
                        charcount++;
                    }

                }
                
            }

            if(charcount > 312)
            {
                won = true;
            }

            return won;
        }
    }
}
