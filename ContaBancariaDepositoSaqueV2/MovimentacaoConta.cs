using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class MovimentacaoConta
    {
        //ATRIBUTOS
        //Usando auto-propertie
        public int Conta { get; private set; }
        public double Deposito { get; set; }
        public double Saque { get; set; }
        public double Saldo { get; set; }
        private string _titular;                

        //CONSTRUTORES
        public MovimentacaoConta(int conta, string titular)
        {
            Conta = conta;
            _titular = titular;
        }

        public MovimentacaoConta(int conta, string titular, double deposito) : this(conta, titular)
        {
            Deposito = deposito;
        }

        public MovimentacaoConta(double deposito)
        {
            //Chamando o método de adição direta do saldo
            AdicionarSaldo(deposito);
        }

        //GET/SET
        //Propertie
        public string Titular
        {
            get { return _titular; }
            set
                { //atribui nome se o nome não for nulo e tamanho for maior que 1
                  //a entrada do dado é através do parâmetro value
                    if (value != null && value.Length > 1)
                    {
                        _titular = value;
                    }
                }
        }
        
        //METODOS
        public void AdicionarSaldo (double deposito)
        {
            Saldo = Saldo + deposito;
        }

        public void RemoverSaldo (double saque)
        {
            Saldo = (Saldo - Saque) - 5.00;
        }

        //Sobreposição        
        public override string ToString()
        {
            return "Conta: "
                 + Conta
                 + ", Titular: "
                 + _titular
                 + ", Saldo: "
                 + Saldo.ToString("F2", CultureInfo.InvariantCulture); //tratamento
                
        }

    }
}
