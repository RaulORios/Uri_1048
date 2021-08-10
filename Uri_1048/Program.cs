using System;
using System.Globalization;

namespace Uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double novo_salario;
            double reajuste;
            int percentual;

            if (salario <= 400)
            {
                percentual = 15;
                reajuste = salario / 100 * percentual;
                novo_salario = salario + reajuste;
            }
            else if (salario > 400 && salario <= 800)
            {
                percentual = 12;
                reajuste = salario / 100 * percentual;
                novo_salario = salario + reajuste;
            }
            else if (salario > 800 && salario <= 1200)
            {
                percentual = 10;
                reajuste = salario / 100 * percentual;
                novo_salario = salario + reajuste;
            }
            else if (salario > 1200 && salario <= 2000)
            {
                percentual = 7;
                reajuste = salario / 100 * percentual;
                novo_salario = salario + reajuste;
            }
            else
            {
                percentual = 4;
                reajuste = salario / 100 * percentual;
                novo_salario = salario + reajuste;
            }

            Console.WriteLine($"Novo salario: {novo_salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {percentual} %");
                                   
        }
    }
}
