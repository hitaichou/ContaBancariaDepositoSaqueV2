using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ContaBancariaDepositoSaqueV2
{
    class MovimentacaoConta
    {
        public int _conta;
        public string _titular;
        public double _vlDeposito;
        public double _vlSaque;
        public double _vlSaldo = 0;

        public void AdicionarSaldo (double deposito)
        {
            _vlSaldo = _vlSaldo + deposito;
        }

        public void RemoverSaldo (double saque)
        {
            _vlSaldo = (_vlSaldo - saque) - 5.00;
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
