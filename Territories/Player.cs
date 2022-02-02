using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class Player
    {
        public int[] lastplace;
        char team;

        public Player(char team)
        {
            this.team = team;
        }

        public void place(Board board)
        {

            int[] coords = new int[2];

            bool placed = false;

            do
            {

                //Console.WriteLine("Please enter Y coordinate.");
                //coords[0] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Please enter X coordinate.");
                //coords[1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter coordinates in format x,y");

                string[] temp = Console.ReadLine().Split(',');

                coords[1] = Convert.ToInt32(temp[0]);
                coords[0] = Convert.ToInt32(temp[1]);

                placed = board.place(coords, team);

                lastplace = coords;

            } while (!placed && coords[0] != -1);

        }

        public char Team
        {
            get { return team; }
            set { team = value; }
        }
    }
}
