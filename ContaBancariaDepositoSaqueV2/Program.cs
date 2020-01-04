using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vldeposito = 0;

            Console.Write("Entre o número da conta: ");            
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");            
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string flagDep = Console.ReadLine();

            if (flagDep == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");                                
                vldeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            }
            MovimentacaoConta mc = new MovimentacaoConta(conta, titular, vldeposito);

            mc.AdicionarSaldo(vldeposito);
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(mc);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            vldeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mc.AdicionarSaldo(vldeposito);
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(mc);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double vlSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mc.RemoverSaldo(vlSaque);            

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(mc);



        }
    }
}
