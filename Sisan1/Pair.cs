using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sisan1
{
    public class Pair<T, U>
    {
        public Pair()
        {
        }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First { get; set; }
        public U Second { get; set; }

    };
    public class CompareClass
    {
        public static int Compare(Pair<float, string> x, Pair<float, string> y)
        {
            if (x.First > y.First)
                return -1;
            if (x.First < y.First)
                return 1;
            if (x.First == y.First)
                return 0;
            return 0;
        }
    }
}
