using System;
namespace cTercero
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n1;
            int n2;
            
            Console.WriteLine("Escribe el número 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 % n2 == 0)
                Console.WriteLine("Los números {0} / {1} son divisibles", n1, n2);
            else
            {
                if (n1 % n2 != 0)
                {
                    if (n2 % n1 == 0)
                        Console.WriteLine("Los números {1} / {0} son divisibles", n1, n2);
                    else if (n2 % n1 != 0)
                        Console.WriteLine("Los números {1} Y {0} no son divisibles", n1, n2);
                }
                else
                        Console.WriteLine("ERROR");
            }
            Console.ReadLine();
        }
    }
}


