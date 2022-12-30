using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    internal class Auxiliar:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario + (this.Salario *= 0.20);
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando um Auxiliar");
        }
    }
}
