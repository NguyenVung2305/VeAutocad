using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2
{
    internal class Rectangle : AbstractNode
    {
        public override string Name => "Rectangle";

        public double Width { get; set; }
        public double Height { get; set; }

        public override Rectangle2D GetBounds()
        {
            return new Rectangle2D()
            {
                TopLeftX = Position.X,
                TopLeftY = Position.Y,
                Height = Height,
                Width = Width,                
            };
        }
    }
}
