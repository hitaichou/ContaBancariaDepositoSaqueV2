using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class MovimentacaoConta
    {
        //ATRIBUTOS
        public int Conta;
        public string Titular;
        public double VlDeposito;
        //public double _vlSaque;
        public double VlSaldo = 0;

        //CONSTRUTORES
        public MovimentacaoConta(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;            
        }

        public MovimentacaoConta(int conta, string titular, double deposito)
        {
            Conta = conta;
            Titular = titular;
            VlDeposito = deposito;
        }

        public MovimentacaoConta(double deposito)
        {
            VlDeposito = VlDeposito + deposito;
        }

        //METODOS
        public void AdicionarSaldo (double deposito)
        {
            VlSaldo = VlSaldo + deposito;
        }

        public void RemoverSaldo (double saque)
        {
            VlSaldo = (VlSaldo - saque) - 5.00;
        }

        //Sobreposição        
        public override string ToString()
        {
            return "Conta: "
                 + Conta
                 + ", Titular: "
                 + Titular
                 + ", Saldo: "
                 + VlSaldo.ToString("F2", CultureInfo.InvariantCulture); //tratamento
                
        }

    }
}
