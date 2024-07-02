using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad.AbstractionClass
{
    public interface IBranch
    {
        string Name { get; set; }
        CadBlock CadBlock { get; set; }
        void ReCalculatePoint();
        void SaveToDB();
    }
}
