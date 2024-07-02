using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2
{
    internal abstract class AbstractNode : INode
    {
        public abstract string Name { get; }
        public string Notes { get; set; } = string.Empty;
        public Point2D Position { get; set; } = Point2D.Zero;

        public abstract Rectangle2D GetBounds();
    }
}
