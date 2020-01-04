using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class Program
    {
        static void Main(string[] args)
        {
            MovimentacaoConta mc = new MovimentacaoConta();

            Console.Write("Entre o número da conta: ");            
            mc._conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");            
            mc._titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string flagDep = Console.ReadLine();

            if (flagDep == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");                
                mc._vlDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                mc.AdicionarSaldo(mc._vlDeposito);
                Console.WriteLine();

                Console.WriteLine("Dados da conta:");
                Console.WriteLine(mc);
            }
            Console.WriteLine();

            Console.Write("Entre um valor para deposósito: ");
            double vlDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mc.AdicionarSaldo(vlDeposito);
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
