using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class MovimentacaoConta
    {
        //ATRIBUTOS
        //Usando auto-propertie
        public int Conta { get; private set; }
        private string _titular;
        public double Deposito { get; set; }
        public double Saque { get; set; }
        private double _vlSaldo = 0;
        //CONSTRUTORES
        public MovimentacaoConta(int conta, string titular)
        {
            Conta = conta;
            _titular = titular;
        }

        public MovimentacaoConta(int conta, string titular, double deposito)
        {
            Conta = conta;
            _titular = titular;
            Deposito = deposito;
        }

        public MovimentacaoConta(double deposito)
        {
            Deposito = Deposito + deposito;
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
            //VlSaldo = VlSaldo + deposito;
            _vlSaldo = _vlSaldo + deposito;
        }

        public void RemoverSaldo (double saque)
        {
            _vlSaldo = (_vlSaldo - Saque) - 5.00;
        }

        //Sobreposição        
        public override string ToString()
        {
            return "Conta: "
                 + Conta
                 + ", Titular: "
                 + _titular
                 + ", Saldo: "
                 + _vlSaldo.ToString("F2", CultureInfo.InvariantCulture); //tratamento
                
        }

    }
}
