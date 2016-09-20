using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gerente : Funcionario
    {
        public string Departamento { get; set; }
        public double Bonus { get; set; }

        public Gerente(string departamento, string cpf, string nome) : base(nome,cpf)
        {
            this.Departamento = departamento;
                    
        }
    
    }
}
