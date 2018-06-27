
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSestema();
            
            Console.ReadLine();
        }
        public static void UsarSestema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno(); // instanciando um objeto

            Diretor fernanda = new Diretor("159.753.398-04");
            fernanda.Nome = "Fernanda";
            fernanda.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.356.352-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            
            sistemaInterno.Logar(fernanda, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Designer italo = new Designer("833.222.048.-39");
            italo.Nome = "Italo";

            Diretor fernanda = new Diretor("159.753.398-04");
            fernanda.Nome = "Fernanda";

            Auxiliar igor = new Auxiliar("981.185.787.53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.356.352-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(italo);
            gerenciadorBonificacao.Registrar(fernanda);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
