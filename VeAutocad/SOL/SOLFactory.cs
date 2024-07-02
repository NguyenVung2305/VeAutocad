using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VeAutocad.AbstractionClass;

namespace VeAutocad.SOL
{
    public class SOLFactory
    {

      public static  IBranch CreateBranch(string name)
        {
            switch (name)
            {
                case "SOLD":
                    return new SOLD();
                case "SOLU":
                    return new SOLU();
                default:
                    return null;
            }
        }
    }
}
