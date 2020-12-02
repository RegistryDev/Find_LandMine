using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_LandMine
{
    class Rank
    {
        public string Name { get; set; }
        public int Box { get; set; }
        public double Time { get; set; }

        public Rank(string name, int box, double time)
        {
            this.Name = name;
            this.Box = box;
            this.Time = time;
        }
    }
}
