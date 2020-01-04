using System;
using System.Globalization;

namespace ContaBancariaDepositoSaqueV2
{
    class MovimentacaoConta
    {
        //ATRIBUTOS
        /*
        public int Conta;
        public string Titular;
        public double VlDeposito;
        //public double _vlSaque;
        public double VlSaldo = 0;
        */
        //Trocando variáveis da classe de public para private
        private int _conta;
        private string _titular;
        private double _vlDeposito;
        private double _vlSaque;
        private double _vlSaldo = 0;

        //CONSTRUTORES
        public MovimentacaoConta(int conta, string titular)
        {
            //Conta = conta;
            //Titular = titular;            
            _conta = conta;
            _titular = titular;
        }

        public MovimentacaoConta(int conta, string titular, double deposito)
        {
            //Conta = conta;
            //Titular = titular;
            //VlDeposito = deposito;
            _conta = conta;
            _titular = titular;
            _vlDeposito = deposito;
        }

        public MovimentacaoConta(double deposito)
        {
            //VlDeposito = VlDeposito + deposito;
            _vlDeposito = _vlDeposito + deposito;
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
        /*public string GetTitular()
        {
            return _titular;
        }

        public void SetTitular(string titular)
        {   //atribui nome se o nome não for nulo e tamanho for maior que 1
            if(titular != null && titular.Length > 1)
            {
                _titular = titular;
            }            
        }*/

        public int Conta
        {
            get { return _conta; }
            set { _conta = value; }
        }

        public double Deposito
        {
            get { return _vlDeposito; }
            set { _vlDeposito = value; }
        }

        /*public double GetDeposito()
        {
            return _vlDeposito;
        }

        public void SetDeposito(double deposito)
        {
            _vlDeposito = deposito;
        }*/

        public double Saque
        {
            get { return _vlSaque; }
            set { _vlSaque = value; }
        }

        /*public double GetSaque()
        {
            return _vlSaque;
        }

        public void SetSaque(double saque)
        {
            _vlSaque = saque;
        }*/

        //METODOS
        public void AdicionarSaldo (double deposito)
        {
            //VlSaldo = VlSaldo + deposito;
            _vlSaldo = _vlSaldo + deposito;
        }

        public void RemoverSaldo (double saque)
        {
            //VlSaldo = (VlSaldo - saque) - 5.00;
            //_vlSaldo = (_vlSaldo - saque) - 5.00;
            _vlSaldo = (_vlSaldo - _vlSaque) - 5.00;
        }

        //Sobreposição        
        public override string ToString()
        {
            return "Conta: "
                 + _conta
                 + ", Titular: "
                 + _titular
                 + ", Saldo: "
                 + _vlSaldo.ToString("F2", CultureInfo.InvariantCulture); //tratamento
                
        }

    }
}
