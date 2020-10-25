using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] value= new int[3];
            int v, max = value[0], min = value[0];
            int i = 0;
            while(i < 3)
            {
                Console.Write("Escribe un número: ");
                v = int.Parse(Console.ReadLine());
                value[i] = v;
                i++;
            }

            Console.Write("\n\nEl mayor número es: " + value.Max());
            Console.Write("\n\nEl menor número es: " + value.Min());
            Console.ReadKey();
        }
    }
}