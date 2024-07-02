using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2
{
    internal class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static readonly Point2D Zero = new() { X = 0, Y = 0 };
    }
}
