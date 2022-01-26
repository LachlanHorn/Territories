using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class AiPlayer : Player
    {
        int difficulty;
        
       
        public AiPlayer(char team, int difficulty) : base (team)
        {
            this.difficulty = difficulty;
            this.Team = team;
            Console.WriteLine("I AM THE THINKING MACHINE!");                     
            
        }

        public void randopath(Board board)
        {
            Random rand = new Random();
            bool placed = false;
            
            do
            {
                int[] rands = new int[] { rand.Next(0, 24), rand.Next(0, 24) };

                placed = board.place(rands, Team);

            } while (!placed);
            


        }


    }
}
