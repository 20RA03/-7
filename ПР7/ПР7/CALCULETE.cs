using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР7
{
    class Rectangle : Pair
    {
        public int first { get; set; }

        public int second { get; set; }

        public Rectangle(int first, int second) : base(first, second)
        {
            this.first = first;
            this.second = second;
        }

        public double GetPerimetr(Rectangle triangle)
        {
            return (triangle.first + triangle.second) * 2;
        }

        public long GetArea(Rectangle triangle)
        {
            return triangle.first * triangle.second;
        }
    }
}
