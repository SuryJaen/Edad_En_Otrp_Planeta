using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad_En_Otro_Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("=======Edad_En_Otro_Planeta=======");
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine("DIGITE SU EDAD");
            string digito = Console.ReadLine();
            float edad = float.Parse(digito);
            Console.WriteLine("SU EDAD EN MERCURIO CORRESPONDE A {0}", edad - 365 * 88);
            Console.WriteLine("SU EDAD EN VENUS CORRESPONDE A {0}", edad - 356 * 225);
            Console.WriteLine("SU EDAD EN JUPITER CORRESPONDE A {0}", edad - 356 * 4380);
            Console.WriteLine("SU EDAD EN SATURNO CORRESPONDE A {0}", edad - 365 * 10767);
            Console.Read();
        }
    }
}
