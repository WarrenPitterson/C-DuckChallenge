using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public class Duck
    {
        public string name { get; set; }
        public int coolness { get; set; }

        public Duck(string name, int coolness)
        {
            this.name = name;
            this.coolness = coolness;
        }
    }

}
