using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2
{
    internal class Diagram
    {
        public IList<INode> Nodes { get; } = [];

        public void Add(INode node)
        {
            Nodes.Add(node);
        }

        public void Clear() { 
            Nodes.Clear(); 
        }
    }
}
