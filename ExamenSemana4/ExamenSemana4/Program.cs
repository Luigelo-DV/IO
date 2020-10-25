using System;

namespace ExamenSemana4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user to choose an option.
            Console.WriteLine("Elija su ejercicio:");
            Console.WriteLine("Mínimo 1: ");
            Console.WriteLine("\ta - Ejercicio a");
            Console.WriteLine("\ts - Ejercicio b");
            Console.WriteLine("\td - Ejercicio c");
            Console.WriteLine("Mínimo 2: ");
            Console.WriteLine("\tf - Ejercicio a");
            Console.WriteLine("\tg - Ejercicio b");
            Console.WriteLine("\th - Ejercicio c");
            Console.Write("Que ejercicio desea ejectuar? ");

            switch (Console.ReadLine())
            {
                case "a":
                case "A":
                    int firstNumber, secondNumber, thirdNumber;
                    Console.WriteLine("Escriba primer número");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba segundo número 2");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba tercer número ");
                    thirdNumber = Convert.ToInt32(Console.ReadLine());
                    
                    if(firstNumber == (secondNumber + thirdNumber))
                        Console.WriteLine("El número {0} es la suma de {1} y {2}", firstNumber,secondNumber,thirdNumber);
                    else
                    {
                        if (secondNumber == (thirdNumber + firstNumber))
                            Console.WriteLine("El número {1} es la suma de {0} y {2}", firstNumber, secondNumber,
                                thirdNumber);
                        if (thirdNumber == (firstNumber + secondNumber))
                            Console.WriteLine("El número {2} es la suma de {0} y {1}", firstNumber, secondNumber,
                                thirdNumber);
                        else
                        {
                            Console.WriteLine("La suma de ninguno de los números tiene de resultado otro");
                        }
                    }

                    Console.ReadLine(); 
                        break;
                
                case "s":
                case"S":
                    
                    double userInput, originalInput, output;
                    Console.WriteLine("Escriba la operación que desea realizar");
                    Console.WriteLine("\tc - Converitir a grados Celcius");
                    Console.WriteLine("\tf - Convertir a grados Fahrenheit");
                    Console.Write("Que conversión desea realizar? ");

                    switch (Console.ReadLine())
                    {
                        case "c":
                            case "C":
                                
                            Console.WriteLine("Escriba los grados que quiere convertir");
                            userInput = Convert.ToDouble(Console.ReadLine());
                            
                            originalInput = userInput;

                            output = ((userInput - 32) / (1.8));
                            output = Math.Round(output, 2);
                            Console.WriteLine("{0} grados Fahrenheit son {1} grados Celcius", originalInput, output);
                            break;
                        
                        case "f":
                        case "F":
                                 
                            Console.WriteLine("Escriba los grados que quiere convertir");
                            userInput = Convert.ToDouble(Console.ReadLine());
                            originalInput = userInput;

                            output = ((userInput * 1.8) + 32);
                            output = Math.Round(output, 2);
                            Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit", originalInput, output);
                            
                        break; 
                        default:
                            Console.WriteLine("Error no ha seleccionado ninguna conversión");
                            break;
                    }

                Console.ReadLine();
                    
                break;
                
                case "d":
                case"D":
                    
                    int inputNumber2;
                    Console.WriteLine("Escriba un número");
                    inputNumber2 = Convert.ToInt32(Console.ReadLine());

                    if (inputNumber2 % 2 == 0)
                    {
                        if ((inputNumber2 % 7 == 0) && (inputNumber2 % 13 == 0))
                            Console.WriteLine("El número es PAR y MÚLTIPLE de 7 y 13");
                        else
                        {
                            if (inputNumber2 % 13 == 0)
                                Console.WriteLine("El número es PAR y es solo MÚLTIPLE de 7");
                            else{
                                if (inputNumber2 % 13 == 0) 
                                    Console.WriteLine("El número es PAR y es solo MÚLTIPLE de 13");
                            }
                            
                            Console.WriteLine("El número es PAR pero no es MÚLTIPLE de 7 ni de 13");
                        }
                    }
                    
                    //float x = float.Parse(string.Format("{0}.{1}", a.ToString(), b.ToString()));
                    else
                        Console.WriteLine("El número no es PAR ");

                    Console.ReadLine();
                    break;
                
                case "f":
                case"F":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este ejercicio tiene errores \n");
                    Console.ResetColor();
                    int[] inputNumbersFirst = new int[100];
                    int[] inputNumbersSecond = new int[100];
                    int i, inputNumberSum1;


                    i = 0;
                    Console.WriteLine("Escriba los números que desea sumar a continuación\n");
                    Console.WriteLine("Número primera suma: ");
                    inputNumbersFirst[i] = Convert.ToInt32(Console.ReadLine());

                    inputNumberSum1 = 0;
                    
                    while (inputNumbersFirst[i] != 0)
                    {
                        Console.WriteLine("Número primera suma: ");
                        inputNumbersFirst[i+1] = Convert.ToInt32(Console.ReadLine());
                        inputNumberSum1 += inputNumbersFirst[i+1];
                        i++;

                        if (inputNumbersFirst[i] % 3 != 0) continue;
                        int inputNumberSum2 = 0; 
                        Console.Write("A continuación escriba los números que se " +
                                      "igualarán con la suma de los números anteriores \n");
                        inputNumbersSecond[i+1] = Convert.ToInt32(Console.ReadLine());
                            
                            while (inputNumbersSecond[i+1] != 0)
                            {
                                Console.WriteLine("Número segunda suma: ");
                                inputNumbersSecond[i+1] = Convert.ToInt32(Console.ReadLine());
                                inputNumberSum2 += inputNumbersSecond[i+1];
                                i++;
                            }
                            Console.WriteLine("Esta es la salida erronea de la suma anterior: {0}", inputNumberSum2); 
                            i++;
                    }
                    
                  
                    break;
                
                default:
                    
                    Console.Write("No hay programas asociados con esta selección.");
                    
                    break;
            }
            
        }
    }
}

