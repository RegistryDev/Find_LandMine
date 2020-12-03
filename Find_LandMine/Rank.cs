using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_LandMine
{
    class Rank
    {
        internal List<Record> list = new List<Record>();
        internal List<Record> listOut;

        public Rank()
        {
            list.Add(new Record("", 5, 15.0));
            list.Add(new Record("", 4, 10.0));
            list.Add(new Record("", 3, 5.0));
        }
        public void addList(string name, int box, double time)
        {
            list.Add(new Record(name, box, time));
            var data = from num in list
                       orderby num.Box descending, num.Time ascending
                       select num;
            listOut = data.ToList();
        }
        public void sortList()
        {
            var data = from num in list
                       orderby num.Box descending, num.Time ascending
                       select num;
            listOut = data.ToList();
        }
    }
    class Record
    {
        public string Name { get; set; }
        public int Box { get; set; }
        public double Time { get; set; }
        public Record(string name, int box, double time)
        {
            this.Name = name;
            this.Box = box;
            this.Time = time;
        }
    }
}
