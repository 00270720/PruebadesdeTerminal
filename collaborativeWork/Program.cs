using System;

namespace collaborativeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("El número no es positivo, intente de nuevo");
            else if (num % 2 == 0)
                Console.WriteLine("El número es par");
            else
                Console.WriteLine("El número es impar");
            
            
        }
    }
}
