using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeAutocad.AbstractionClass;

namespace VeAutocad.SOL
{
    public class SOLU : IBranch
    {
        public string Name { get; set; } = "SOLU";
        public CadBlock CadBlock { get; set; }
        Point2d P1 { get; set; }  // la diem se duoc truyen tu ben ngoai vao
        Point2d P2 { get; set; }
        Point2d P3 { get; set; }
        Vector2d V1 { get; set; }  //V1,V2,V3 se duoc truyen tu ngoai vao
        Vector2d V2 { get; set; } 
        Vector2d V3 { get; set; } 
       public double H {  get; set; }  // H  va K se duoc lay tuong ung tu Database
       public double K { get; set; }
       

        public void ReCalculatePoint()
        {
           P2.X=P1.X+(H+K)*V1.X;
           P2.Y=P1.Y+(H+K)*V1.Y;

           P2.X = P1.X + (H - K) * V1.X;
           P2.Y = P1.Y + (H - K) * V1.Y;

        }
    }
}
