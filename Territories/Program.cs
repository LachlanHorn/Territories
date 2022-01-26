using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to territories");

            Board b = new Board();
            Console.WriteLine("Conquer the board to win!");

            Game game = new Game();

            Console.ReadLine();

            AiPlayer Ai = new AiPlayer('a', 2);
            Ai.place(b);

        }
    }
}
