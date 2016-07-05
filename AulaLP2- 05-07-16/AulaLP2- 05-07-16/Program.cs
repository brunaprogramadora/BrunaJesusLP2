using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaLP2__05_07_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma t = new Turma();
            t.AnoLetivo = "2016";
            t.Serie = "2° ano";
            t.Numero = "IN207";
            t.NumSala = "8";
            t.Tipo = "Integrado";
            t.Turno = "Manhã";

            for (int i = 0; i < 3; i++)
			{
			    Aluno a = new Aluno();
                a.Matricula = Console.ReadLine();
                a.Nome = Console.ReadLine();
                a.Numero = int.Parse(Console.ReadLine());
                t.AddAluno(a);
			}
            foreach (Aluno a in t.Alunos)
            {
                Console.WriteLine("{0} - {1}, {2}", a.Matricula, a.Nome, a.Numero);
            }
        }
    }
}
