



using ByteBank.Funcionarios;
using ByteBank.Sistema;

namespace ByteBank
{
    class program
    {
        static void Main(string[]args)
        {
            //CalcularBonificacao(); 
            usarSistema(); 
            Console.ReadLine();
        }
        public static void usarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            
            diretor Roberto = new diretor("243.525.258-86");
           
            Roberto.Nome = "Roberto";
            Roberto.Senha = "456";

            GerenteDeConta Fabia = new GerenteDeConta("134.212.464-63");
            Fabia.Nome = "Fabia";
            Fabia.Senha = "123";

            ParceiroComercial Cléber = new ParceiroComercial();
            Cléber.Senha = "oie";

            sistemaInterno.Logar(Cléber, "oie");
            sistemaInterno.Logar(Fabia, "123");
            sistemaInterno.Logar(Roberto, "456");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer Nilza = new Designer("928.424.811-85");
            Nilza.Nome = "Nilza";

            GerenteDeConta Fabia = new GerenteDeConta("134.212.464-63");
            Fabia.Nome = "Fabia";

            Auxiliar Yuri = new Auxiliar("215.654.367-75");
            Yuri.Nome = "Yuri";

            diretor Roberto = new diretor("243.525.258-86");
            Roberto.Nome = "Roberto"; 

            gerenciadorBonificacao.registrar(Roberto);
            gerenciadorBonificacao.registrar(Fabia);
            gerenciadorBonificacao.registrar(Nilza);
            gerenciadorBonificacao.registrar(Yuri);

            Console.WriteLine("Total bonificações Mensal: " + gerenciadorBonificacao.GetBonificacao()); 
       
        
        }
        
    
    }



}