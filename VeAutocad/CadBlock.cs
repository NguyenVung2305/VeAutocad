using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeAutocad
{
    public class CadBlock
    {

     public  Matrix Matrix {  get; set; }
     public Point2d InsertPoint { get; set; }
     public   void Insert(string Name)
        {
            // su dung InsertPoint va Matrix de tinh toan vi tri insert tam thoi chua tinh toan
            Console.WriteLine($" Insert {Name} Successful ");
        }

    }
}
