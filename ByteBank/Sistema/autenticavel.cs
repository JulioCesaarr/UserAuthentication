using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public interface Iautenticavel 
    {
        bool autenticar(string senha);
       
    }
}
