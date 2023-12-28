using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Leia o número de um funcionário, seu número de horas" +
                " trabalhadas e o seu valor da por hora.");

            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("NUMERO = " + funcionario);

            double salario = horas * valor;
            Console.WriteLine("SALAIO = U$ " + salario.ToString("F2", CI));
        }
    }
}