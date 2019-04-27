using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);



            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: {0}", contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: {0}", contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);


            Console.WriteLine("Saldo do Bruno: {0}", contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: {0}", contaDaGabriela.saldo);
            Console.WriteLine("Resultado Transferência: {0}", resultadoTransferencia);



            contaDaGabriela.Transferir(100, contaDoBruno);


            Console.WriteLine("Saldo do Bruno: {0}", contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: {0}", contaDaGabriela.saldo);










            Console.ReadKey();

        }
    }
}
