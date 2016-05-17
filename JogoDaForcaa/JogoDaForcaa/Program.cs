using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForcaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            int x = 0;
            Console.WriteLine("Escreva palavra misteriosa");
            string palavra = Console.ReadLine();

            char[] ast = new char[palavra.Length];

            while (aux < 7)
            {
                Console.WriteLine("Digite a letra");

                char letra = char.Parse(Console.ReadLine());

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (letra == palavra[i])
                    {
                        ast[i] = palavra[i];
                    }
                    else
                    {
                        ast[i] = '*';
                        aux++;
                    }
                    
                }

                Console.WriteLine(ast);
                
            }
        }
    }
}
