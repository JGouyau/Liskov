using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Square : Polygon
    {
        private double side;

        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetSide()
        {
            return side;
        }

        public override double GetArea()
        {
            Area = side * side;
            return Area;
        }

    }
}
