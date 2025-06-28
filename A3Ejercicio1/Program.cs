// See https://using System;

namespace SumaConFuncion
{
    class Program
    {
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = Sumar(Num1, Num2);

            Console.WriteLine($"La suma de {Num1} y {Num2} es: {resultado}");
        }
    }
}

