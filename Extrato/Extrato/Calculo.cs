using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Extrato
{
    class Calculo
    {
        //  VARIAVEIS
        private double Saldo;
        public double Entrada { get; private set; }
        public double Saida { get; private set; }

        //  METODOS
        public double GetSaldo()
        {
            return Saldo;
        }
        public void SetSaldo(double saldo)
        {
            Saldo = saldo;
        }

        public void Credito(double entrada)
        {
            Saldo += entrada;
        }
        public void Debito(double saida)
        {
            Saldo -= saida;
        }
    }
}
