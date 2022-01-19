using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Territories
{
    class Tile
    {
        char team = ' ';
        public Tile(char character)
        {
            team = character;
        }

        public Tile()
        {

        }

        public char Team
        {
            get { return team; }
            set { team = value; }
        }
    }
}
