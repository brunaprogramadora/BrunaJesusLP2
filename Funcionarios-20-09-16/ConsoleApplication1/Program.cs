using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente g = new Gerente("", "", "");
            g.CPF = Console.ReadLine();
            Console.WriteLine(g.CPF);
            
        }
    }
}
