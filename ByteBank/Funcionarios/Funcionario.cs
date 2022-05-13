using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
     
        public funcionario(double salario, string cpf)
        {
            Console.WriteLine("criando Funcionario");
            CPF = cpf;
            Salario = salario; 
            TotalDeFuncionarios++; 
        }
        


        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
       
       
    }
}
