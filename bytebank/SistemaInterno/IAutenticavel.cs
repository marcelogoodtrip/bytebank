using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha);
    }
}
