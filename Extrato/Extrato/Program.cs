using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Extrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo extrato = new Calculo();
            double saldo;

            Console.WriteLine("Possui saldo inicial? \nS: Para digitar o saldo! \nN: Para prosseguir!");
            char resp = char.Parse(Console.ReadLine());
            switch (resp)
            {
                case 'S':
                    Console.Write("Digite o saldo inicial: ");
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    extrato.SetSaldo(saldo);
                    break;
                case 'N' :
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Erro 001: Feche o programa e tente novamente!\n");
                    break;
            }

            Console.WriteLine("Escolha o tipo de operção que foi feita! \nC: Para crédito! \nD: Para débito!");

            

        }
    }
}
