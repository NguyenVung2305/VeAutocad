using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.v2.DiagramStorage
{
    internal interface IDiagramLoader
    {
        Diagram? Load(string name);
    }
}
