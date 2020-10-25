namespace ConsoleApplication1
{
    using System;
    class Program
    {
        public static void Main(string[] args)
        {
            /* Mi primer programa */
            int a,b;
            char c;
            
            Console.WriteLine ("Escribe un numero:");
            a = Convert.ToInt32(Console.ReadLine());
            b=a*2;

            c='L';

            Console.WriteLine ("El doble de {0} es {1}",a,b);
            Console.WriteLine ("La letra es"+c); //Forma alternativa de escribir frases y datos
            Console.ReadLine();
            
        }
    }
}