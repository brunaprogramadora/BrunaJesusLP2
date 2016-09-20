using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Empregado : Funcionario
    {
        public double VR { get; set; }
        public double VT { get; set; }

        public Empregado(double vr, string nome, string cpf) :base(nome,cpf)
        {
            this.VR = vr;
        }
        
    }
}
