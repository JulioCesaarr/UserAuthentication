using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _TotalBonificacao;
        public void registrar(funcionario funcionario)
        {
            _TotalBonificacao += funcionario.GetBonificacao();
        }

        public double GetBonificacao()
        { return _TotalBonificacao; }


    }
}
