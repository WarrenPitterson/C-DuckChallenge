using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Player
    {
        public string name { get; set; }
        public int score { get; set; }

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
