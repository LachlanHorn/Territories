using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class Board
    {
        static Tile[,] t = new Tile[25, 25];

        public Board()
        {
            fill();
        }

        public bool place(int[] coords, char character)
        {

            bool placed = false;

            if (Neighbourcheck(coords, character) && t[coords[0], coords[1]].Team == ' ')
            {
                t[coords[0], coords[1]] = new Tile(character);
                placed = true;
            }

            return placed;

        }

        public void paint()
        {
            for (int x = 0; x < t.GetLength(0); x++)
            {
                
                for (int y = 0; y < t.GetLength(1); y++)
                {
                    Console.Write("  " + t[x, y].Team);
                }
                Console.WriteLine(" : " + x);
            }

           
        }

        private bool Neighbourcheck(int[] coords, char character)
        {
            bool neighboured = false;



            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    if (t[coords[0] + x, coords[1] + y].Team == character)
                    {
                        neighboured = true;
                    }
                }
            }

            return neighboured;
        }

        public Tile[,] board
        {
            get { return t; }
            set { t = value; }
        }

        private void fill()
        {
            for (int x = 0; x < t.GetLength(0); x++)
            {
                for (int y = 0; y < t.GetLength(1); y++)
                {
                    t[x, y] = new Tile('X');
                }
            }
        }
    }
}
