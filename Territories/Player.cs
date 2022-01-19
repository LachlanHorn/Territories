using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class Player
    {
        char team;

        public Player(char team)
        {
            this.team = team;
        }

        public void place(Board board)
        {
            int[] coords = new int[2];

            do
            {

                Console.WriteLine("Please enter X coordinate.");
                coords[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Y coordinate.");
                coords[1] = Convert.ToInt32(Console.ReadLine());

            } while (!board.place(coords, team));



        }
    }
}
