using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntro
{
    class Util
    {
        public static int Max(int a, int b)
        {
            if (a > b) return a;
            return b;
        }

        public static double Max(double a, double b)
        {
            if (a > b) return a;
            return b;
        }
    }
}
