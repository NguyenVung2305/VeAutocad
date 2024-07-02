using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeAutocad.AbstractionClass;

namespace VeAutocad.SOL
{
    public class SOLD : IBranch
    {
        public string Name { get; set; } = "SOLD";
        public CadBlock CadBlock { get; set; }
        Point2d P1 { get; set; }  // la diem se duoc truyen tu ben ngoai vao
        Point2d P2 { get; set; } 
        Vector2d V1 { get; set; } //V1,V2 se duoc truyen tu ngoai vao
        Vector2d V2 { get; set; } 
        double C {  get; set; }  // C  va D se duoc lay tuong ung tu Database
        double D { get; set; }
        public void ReCalculatePoint()
        {
          P2.X=P1.X+(C+D)*V1.X;
          P2.Y=P1.Y+(C+D)*V1.Y;
        }

        public void SaveToDB()
        {
            throw new NotImplementedException();
        }
    }
}
