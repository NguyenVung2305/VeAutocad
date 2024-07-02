using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2
{
    internal interface INode
    {
        string Name { get; }
        string Notes { get; set; }
        Point2D Position { get; set; }
        Rectangle2D GetBounds();
    }
}
