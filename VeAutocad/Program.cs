using VeAutocad.AbstractionClass;
using VeAutocad.SOL;

namespace VeAutocad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBranch branch = SOLFactory.CreateBranch("SOLD");
            // vi Branch luc nay la class SOLD, lam sao de em co the gan gia tri cho C,D
           // branch.C= 10 chang han, de phuc vu viec tinh toan ben trong
           // cung tuong tu cho truong hop class SOLU
        }
    }
}
