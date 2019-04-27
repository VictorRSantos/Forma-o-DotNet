using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela =  new ContaCorrente();


            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;


            Console.WriteLine("Nome: {0}",contaDaGabriela.titular);
            Console.WriteLine("Agência: {0}", contaDaGabriela.agencia);
            Console.WriteLine("Número: {0}",contaDaGabriela.numero);
            Console.WriteLine("Saldo: {0}",contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.WriteLine("Saldo: {0}", contaDaGabriela.saldo);

            Console.ReadLine();


        }
    }
}
