using System;

namespace cSegundo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int n1;
            char x;
            int result;
            
            Console.WriteLine("Escribe un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elije tu operacion");
            x = Convert.ToChar(Console.ReadLine());
            
            if (x == 'd' || x == 'D')
            {
                 result = n1 * 2 ;
                 Console.WriteLine("Su resultado es : {0}", result);
            }   
            else
            {
                if (x == 't' || x == 'T')
                {
                    result = n1 * 3;
                    Console.WriteLine("Su resultado es : {0}", result);
                }
                else
                    Console.WriteLine("Error no se ha encontrado una operación válida");
            }
            Console.ReadLine();
            
        }
    }
}