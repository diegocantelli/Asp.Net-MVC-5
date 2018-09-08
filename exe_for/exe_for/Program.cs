using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdPares;
            double valor1 = 0;
            double valor2 = 0;

            Console.WriteLine("Informe a quatidade de pares numéricos a serem lidos: ");
            qtdPares = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < qtdPares; i++)
            {
                Console.WriteLine("Informe o primeiro número:  ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo número:  ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                if (valor2 > 0)
                    Console.WriteLine("O resultado da divisão é:  " + (valor1 / valor2).ToString());
                else
                    Console.WriteLine("Não existe");
            }

        }
    }
}
