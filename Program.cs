using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDaGabriela = new ContaCorrente();
            ContaDaGabriela.titular = "Gabriela";
            ContaDaGabriela.agencia = 863;
            ContaDaGabriela.numero = 863452;

            ContaCorrente contadaDaGabrielaCosta = new ContaCorrente();
            contadaDaGabrielaCosta.titular = "Gabriela";
            contadaDaGabrielaCosta.agencia = 863;
            contadaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (ContaDaGabriela == contadaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            ContaDaGabriela = contadaDaGabrielaCosta;
            Console.WriteLine(ContaDaGabriela == contadaDaGabrielaCosta);


            ContaDaGabriela.saldo = 300;
            Console.WriteLine(ContaDaGabriela.saldo);
            Console.WriteLine(contadaDaGabrielaCosta.saldo);


            if (ContaDaGabriela.saldo >= 100)
            {
                ContaDaGabriela.saldo -= 100;
            }



            Console.ReadLine();

        }
    }
}
