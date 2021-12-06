using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Rectangle : Polygon
    {
        private double width;
        private double height;

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public override double GetArea()
        {
            Area = width * height;
            return Area;
        }
    }
}
