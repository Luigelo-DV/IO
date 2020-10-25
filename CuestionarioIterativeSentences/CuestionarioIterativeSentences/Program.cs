using System;
namespace CuestionarioIterativeSentences
{
  internal class Program
  {

      public static void Main(string[] args)
      {
          // Ask the user to choose an option.
          Console.WriteLine("Elija una de las opciones:");
          Console.WriteLine("\ta - Pregunta 6");
          Console.WriteLine("\ts - Pregunta 7");
          Console.WriteLine("\td - Pregunta 8");
          Console.Write("Su opción? ");

          switch (Console.ReadLine())
          {
              case "a":
              case "A":
              {
                  /*
                   * Ejercicio 6: Escribid un programa que lea una secuencia de 20
                   * números enteros introducidos por teclado. Al acabar la secuencia el
                   * programa debe mostrar el valor máximo y el valor mínimo introducidos.
                   */

                  int[] numeros = new int[100];

                  int i, mx, mn, n;

                  //máximo de veces 
                  n = 21;

                  Console.WriteLine("Encontraremos el máximo y el mínimo de {0} números :\n", n - 1);
                  i = 1;

                  while (i < n)
                  {
                      Console.WriteLine("Número - {0} : ", i);
                      numeros[i] = Convert.ToInt32(Console.ReadLine());
                      i++;
                  }

                  mx = numeros[0];
                  mn = numeros[0];

                  //Selector de mayor y menor 
                  while (i < n)
                  {
                      if (numeros[i] > mx)
                      {
                          mx = numeros[i];
                      }

                      if (numeros[i] < mn)
                      {
                          mn = numeros[i];
                      }

                      i++;
                  }

                  Console.WriteLine("El número mayor es: {0}", mx);
                  Console.WriteLine("El número menor es: {0}", mn);
                  Console.ReadLine();

                  break;
              }
              case "s":
              case "S":
              {
                  /*
                   * Escribe un programa que calcule la potencia x^y para dos número enteros dados x e y,
                   * mediante una acumulación sucesiva de productos. Previo al cálculo se
                   * verificará que el valor de y sea positivo. En caso contrario no se realizará el cálculo. 
                   */

                  int x, y, i, value;
                  i = 0;
                  value = 0;

                  Console.WriteLine("Introduce un número:");
                  x = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Introduce la potencia del número anterior:");
                  y = Convert.ToInt32(Console.ReadLine());

                  while (i <= y)
                  {
                      value = x * x;
                      i++;
                  }

                  if (y >= 0)
                      Console.WriteLine("La operación con resultado {0} tiene exponente positivo.", value);
                  else
                      Console.WriteLine("El valor del exponente: {0}, es negativo.", y);

                  Console.ReadLine();
                  break;

              }

              case "d":
              case "D":
              {
                  int i, inputNumberD, orginalInputNumberD;
                  string cifraString;
                  
                  Console.WriteLine("Introduce un número:");
                  inputNumberD = Convert.ToInt32(Console.ReadLine());
                  orginalInputNumberD = inputNumberD;
                  
                  i = 1;
                  while (inputNumberD / 10 != 0)
                  {
                      inputNumberD = inputNumberD / 10;
                      i++;
                  }
                  
                  if (i > 1)
                      cifraString = "cifras";
                  else
                  {
                      cifraString = "";
                      if (i == 1) 
                          cifraString = "cifra";
                      
                  }
                  
                  Console.WriteLine("El número {0} tiene {1} {2}", orginalInputNumberD, i, cifraString);
                  Console.ReadLine();
                  
                  break;
                }
            }
            
        }
  }
}