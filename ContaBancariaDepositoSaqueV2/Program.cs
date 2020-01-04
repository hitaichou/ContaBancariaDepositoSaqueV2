using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre o número da conta: ");            
            int conta = int.Parse(Console.ReadLine());            
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();            

            MovimentacaoConta mc = new MovimentacaoConta(conta, titular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string flagDep = Console.ReadLine();

            if (flagDep == "s" || flagDep == "S")
            {
                Console.Write("Entre o valor do depósito inicial: ");                                                
                mc.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mc.AdicionarSaldo(mc.Deposito);
                Console.WriteLine();
            }
            //Mostra resultado e pula uma linha
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(mc);
            Console.WriteLine();

            Console.Write("Deseja alterar o nome (s/n)? ");
            string flagNome = Console.ReadLine();

            if (flagNome == "s")
            {
                Console.Write("Entre o novo nome: ");                
                mc.Titular = Console.ReadLine();
                Console.WriteLine(mc.Titular);
            }
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            mc.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Adiciona saldo a conta
            mc.AdicionarSaldo(mc.Deposito);
            Console.WriteLine();

            //Mostra resultado e pula uma linha
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(mc);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");            
            mc.Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Faz resgate da conta
            mc.RemoverSaldo(mc.Saque);

            //Mostra resultado e pula uma linha
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(mc);
        }
    }
}
