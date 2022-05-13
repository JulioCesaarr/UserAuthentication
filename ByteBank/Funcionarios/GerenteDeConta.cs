
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf) { }


        public override void AumentarSalario()
        {
            Salario *= 0.5; 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25; 
        }






    }

   
 


    
}
