using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueMgmtSln
{
    public class Circle
    {
        //What is the radius of the circle if the area is 36 m2?
        public double Radius()
        {
            double areaSqm = 36;
            // r = ⎷(A/π)
            var radius = Math.Sqrt(areaSqm/(22/7));
            return radius;
        }
    }

    public class Square
    {
        public double Perimeter()
        {
            double areaSqm = 36;
            var side = Math.Sqrt(areaSqm);
            var perimeter = 4* side;
            return perimeter;
        }
    }
}
