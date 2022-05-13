using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : funcionario, Iautenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double Salario, string cpf)
            : base(Salario, cpf)
        {

        }
        public bool autenticar(string senha)
        {
            return Senha == senha; 
        }

    }
}
