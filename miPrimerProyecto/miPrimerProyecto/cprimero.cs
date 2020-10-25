/*
                       __
                     .'  '.
                 _.-'/  |  \
    ,        _.-"  ,|  /  0 `-.
    |\    .-"       `--""-.__.'=====================-,
    \ '-'`        .___.--._)=========================|
     \            .'      |                          |
      |     /,_.-'        |        CODE MADE BY      |
    _/   _.'(             |                          |
   /  ,-' \  \            |           LDV            |
   \  \    `-'            |                          |
    `-'                   '--------------------------'
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace miPrimerProyecto
{
    class cmayor
    {
        static void Main(string[] args)
        {
            // Ask the user to choose an option.
            Console.WriteLine("Escoja una de las siguientes opciones:");
            Console.WriteLine("\ta - Mayor y menor de tres numeros");
            Console.WriteLine("\ts - Múltiples de 5 y 7");
            Console.WriteLine("\td - Número divisible por 7");
            Console.WriteLine("\tf - Hallar dos número impares");
            Console.WriteLine("\tg - Año bisiesto");
            Console.Write("Su opción? ");

            switch (Console.ReadLine())
            {
                case "a":
                    /*En este caso obtenemos los valores llamando a los métodos Math.Max y al Math.Min
             
                    Console.WriteLine("El número menor es: " 
                                      +Math.Max(a, Math.Max(b, c))
                                      );
                    Console.WriteLine("El número menor es: " 
                                      +Math.Min(a, Math.Min(b, c))
                                      );
                    */
                    //Definición de las varibles
                    int a, b, c;
                    //Primera ejecución recoje los parametros con los que nuestro programa trabajará
                    
                    Console.WriteLine("Introduce tres números");
                    Console.Write("Número 1: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Número 2: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Número 3: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    if ((a > b) && (a > c))
                    {
                        Console.WriteLine("El número mayor es: {0}", a);
                        if ((b < a) && (b < c))
                            Console.WriteLine("El número menor es: {0}", b);
                        if ((c < a) && (c < b))
                            Console.WriteLine("El número menor es: {0}", c);
                    }

                    if ((b > c) && (b > a))
                    {
                        Console.WriteLine("El número mayor es: {0}", b);
                        if ((c < a) && (c < a))
                            Console.WriteLine("El número menor es: {0}", b);
                        if ((a < c) && (a < b))
                            Console.WriteLine("El número menor es: {0}", a);
                    }
                    else if ((c > b) && (c > a))
                    {
                        Console.WriteLine("El número mayor es: {0}", c);
                        if ((c < a) && (c < a))
                            Console.WriteLine("El número menor es: {0}", b);
                        if ((a < c) && (a < b))
                            Console.WriteLine("El número menor es: {0}", a);
                    }
                    break;

                case "s":
                    /* OTRA OPCION SERIA DE ESTE ESTILO
                      int x;
                      int z;
                    Console.WriteLine("Introduce un número: ");
                    x = Convert.ToInt32(Console.ReadLine());
                     z = x;
                    while (z > 0) { z = z - 5;}
                    if ( z == 0 ) 
                        Console.WriteLine("El número {0} es multiple de 5",x);
                    */
                    int x;
                    Console.WriteLine("Introduce un número: ");
                    x = Convert.ToInt32(Console.ReadLine());
                   
                    if (x % 5 == 0)
                        Console.WriteLine("El número {0} es multiple de 5",x);
                    else if (x % 7 == 0)
                        Console.WriteLine("El número {0} es multiple de 7",x);
                    else 
                        Console.WriteLine("El número {0} no es multiple ni de 5 ni de 7",x);
                    
                    break;
                
                
                case "d":
                    int g;
                    int h;
                    Console.WriteLine("Introduce un número: ");
                    g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce otro número: ");
                    h = Convert.ToInt32(Console.ReadLine());
                    if ((g % 7 == 0) && (h % 7 == 0))
                        Console.WriteLine("Ambos números, el {0} y el {1} son divisbles entre 7",g,h);
                    if ((g % 7 == 0) && (h % 7 != 0))
                        Console.WriteLine("Solo el número {0} es divisble entre 7",g);
                    if ((g % 7 != 0) && (h % 7 == 0))
                        Console.WriteLine("Solo el número {0} es divisible entre 7",h);
                    else if((g % 7 != 0) && (h % 7 != 0))
                        Console.WriteLine("Tanto el número {0} y el {1} no son divisbles entre 7",g,h);
                    break;
                 case "f":
                     int n1;
                     int n2;
                     int n3;
                     int n4;
                     Console.WriteLine("Introduce un primer número: ");
                     n1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Introduce un segundo número: ");
                     n2 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Introduce un tercer número: ");
                     n3 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Introduce un cuarto número: ");
                     n4 = Convert.ToInt32(Console.ReadLine());
                     
                     //QUEREMOS SABER SI EXISTEN DOS PARES O NO POR TANTO LA VARIANTE ES BOOLEANA (TRUE O FALSE)
                     if ((n1 % 2 == 0) || (n1 % 2 == 0) || (n3 % 2 == 0)  || (n4 % 2 == 0) && 
                         (n1 % 2 == 0) || (n2 % 2 == 0) || (n3 % 2 == 0) || (n4 % 2 == 0))
                         Console.WriteLine("Dos de los números son pares");
                     else 
                         Console.WriteLine("No hay dos números pares");
                     break;
                 
                case "g":
                    //Declaras variable
                    int year;
                    
                    Console.WriteLine("Introduzca un año: ");
                    
                    //Guardas variable
                    year = Convert.ToInt32(Console.ReadLine());
                    
                    if ((year % 4 == 0) || (year % 400 == 0))
                        Console.WriteLine("El año introducido es bisiesto");
                    else if((year % 100 == 0) || (year % 4 !=0) || (year % 400 != 0))
                         Console.WriteLine("El año introducido no corresponde con un año bisiesto");
                    
                    break;
            }

            Console.ReadLine();
        }
    }
}