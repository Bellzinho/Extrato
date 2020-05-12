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
            char resp, stop;
            Console.WriteLine("Possui saldo inicial? \nS: Para digitar o saldo! \nN: Para prosseguir!");
            resp = char.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (resp)
            {
                case 'S':
                    Console.Write("Digite o saldo inicial: ");
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    extrato.SetSaldo(saldo);
                    Console.WriteLine("");
                    break;
                case 'N' :
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Erro 001: Feche o programa e tente novamente!\n");
                    break;
            }

            Console.WriteLine("Seu saldo inicial é de: " + extrato.GetSaldo().ToString("F2", CultureInfo.InvariantCulture) + "\n");

            Console.WriteLine("Deseja fazer uma operação? \nS: Para digitar uma operação! \nN: Para finalizar!");
            stop = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (stop == 'S')
            {
                Console.WriteLine("Escolha o tipo de operção a ser feita!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("C: Para crédito!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("D: Para débito!");
                Console.ForegroundColor = ConsoleColor.White;
                resp = char.Parse(Console.ReadLine());
                Console.WriteLine("");
                if(resp == 'C')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite o valor do crédito: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    extrato.Credito(saldo);
                    Console.WriteLine("\nSeu saldo é de: " + extrato.GetSaldo().ToString("F2", CultureInfo.InvariantCulture) + "\n");
                }
                else if(resp == 'D')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Digite o valor do débito: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    extrato.Debito(saldo);
                    Console.WriteLine("\nSeu saldo é de: " + extrato.GetSaldo().ToString("F2", CultureInfo.InvariantCulture) + "\n");
                }

                Console.WriteLine("Deseja fazer uma operação? \nS: Para digitar uma operação! \nN: Para finalizar!");
                stop = char.Parse(Console.ReadLine());
                Console.WriteLine("");

            }
            Console.WriteLine("Seu saldo final é de: " + extrato.GetSaldo().ToString("F2", CultureInfo.InvariantCulture) + "\n");
            Console.WriteLine("Obrigado pela preferencia! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
