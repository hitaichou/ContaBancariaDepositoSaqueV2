using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double vldeposito = 0;

            Console.Write("Entre o número da conta: ");            
            int conta = int.Parse(Console.ReadLine());            
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();            

            MovimentacaoConta mc = new MovimentacaoConta(conta, titular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string flagDep = Console.ReadLine();

            if (flagDep == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");                                
                //vldeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //mc.SetDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                //mc.AdicionarSaldo(mc.GetDeposito());
                mc.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mc.AdicionarSaldo(mc.Deposito);
                Console.WriteLine();

                Console.WriteLine("Dados da conta:");
                Console.WriteLine(mc);

                Console.WriteLine();
            }
            //MovimentacaoConta mc = new MovimentacaoConta(conta, titular, vldeposito);

            //mc.AdicionarSaldo(vldeposito);
            //mc.AdicionarSaldo(mc.GetDeposito());
            //Console.WriteLine();

            //Console.WriteLine("Dados da conta:");
            //Console.WriteLine(mc);

            //Console.WriteLine();

            Console.Write("Deseja alterar o nome (s/n)? ");
            string flagNome = Console.ReadLine();

            if (flagNome == "s")
            {
                Console.Write("Entre o novo nome: ");
                //mc.SetTitular(Console.ReadLine());
                //Console.WriteLine(mc.GetTitular());
                mc.Titular = Console.ReadLine();
                Console.WriteLine(mc.Titular);
            }
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            //vldeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //mc.SetDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            mc.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //mc.AdicionarSaldo(vldeposito);
            //mc.AdicionarSaldo(mc.GetDeposito());
            mc.AdicionarSaldo(mc.Deposito);
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(mc);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            //double vlSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //mc.SetSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            mc.Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //mc.RemoverSaldo(vlSaque);            
            //mc.RemoverSaldo(mc.GetSaque());
            mc.RemoverSaldo(mc.Saque);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(mc);
        }
    }
}
