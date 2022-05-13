using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class diretor : FuncionarioAutenticavel
    {
      
        public diretor(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public bool autenticar(string senha)
        {
            return true; 
        }
        

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }



        public override double GetBonificacao()
        {
            
            return Salario * 0.5;
           
        }
    }
}
