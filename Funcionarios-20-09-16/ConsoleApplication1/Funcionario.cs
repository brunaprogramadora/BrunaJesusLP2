using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Funcionario
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public double Salario { get; set; }



        public  Funcionario(string cpf, string nome)
        {
            this.CPF = cpf;
            this.Nome = nome;
        }

    }
}
