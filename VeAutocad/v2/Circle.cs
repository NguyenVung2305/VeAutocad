using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2
{
    internal class Circle : AbstractNode
    {
        public override string Name => "Circle";

        public double Radius { get; set; } = 1;

        public override Rectangle2D GetBounds()
        {
            return new Rectangle2D() { 
                TopLeftX = Position.X + Radius,
                TopLeftY = Position.Y - Radius,
                Height = Radius * 2, 
                Width = Radius * 2
            };
        }
    }
}
