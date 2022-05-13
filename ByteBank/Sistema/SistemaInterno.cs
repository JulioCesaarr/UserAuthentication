using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(Iautenticavel funcionario, string senha)
        {
            bool UsuarioAutenticado = funcionario.autenticar(senha);
            if(UsuarioAutenticado) 
            {
                Console.WriteLine("Bem-Vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("senha incorreta");
                return false;
            }
        }
    }
}
