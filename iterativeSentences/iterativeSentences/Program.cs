

using System;

namespace iterativeSentences
{
    internal static class Program
    {
        private const int Max2 = 7;
        private const int Max3 = 20;
        public static void Main(string[] args)
        {
            // Ask the user to choose an option.
            Console.WriteLine("Choose one of the following functions:");
            Console.WriteLine("\ta - Double a number less than 100");
            Console.WriteLine("\ts - Digits comparator");
            Console.WriteLine("\td - Sum of all numbers between 1 and 100 which are multiple of 5 or 7.");
            Console.WriteLine("\tf - Last one");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                //DOUBLE OF A NUMBER LESS THAN 100
                case "a":
                case"A":
                    
                    int inputNumber1, res;
                    Console.WriteLine("Enter a number:");
                    inputNumber1 = Convert.ToInt32(Console.ReadLine());
                    res = 2 * inputNumber1;
                    while (inputNumber1 != 0 && inputNumber1 < 100)
                    {
                        Console.WriteLine("The double of " + inputNumber1 + " is " + res);
                        Console.WriteLine("Enter a number:");
                        inputNumber1 = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("The double of " + inputNumber1+ " is " + res);
                    Console.WriteLine("End of the program");
                    Console.ReadLine();
                    break;
                
                //DIGITS COMPARATOR
                case "s":
                case "S":
                    int original, inputNumber2, cont;
                    cont = 0;
                    Console.WriteLine("Introduce a number");
                    inputNumber2 = Convert.ToInt32(Console.ReadLine());
                    original = inputNumber2;

                    while (inputNumber2 / 10 != 0)
                    {
                        if (inputNumber2 % 10 > Max2) continue;//Cuando es True el bucle para si es false continua
                        cont++;
                        inputNumber2 = inputNumber2 / 10;
                        
                    }
                    
                    Console.WriteLine("The number " + original + " has " + cont +         
                                      " digits bigger than " + Max2);
                        Console.ReadLine();

                    break;
                
                case "d":
                case "D":
                    /*
                     * Write a program that calculates the sum of all numbers between 1 and 100
                     * which are multiple of 5 or 7. To verify that a number X is multiple of another number
                     */
                    int  limitValue, initialValue, counter;
                    initialValue = 0;
                    limitValue = 99; 
                    counter = 0;
                    
                    while ( counter <= limitValue  )
                    {
                        counter++;
                        if ((counter % 5 == 0) || (counter % 7 == 0))
                        {
                            initialValue = initialValue + counter;
                        }
                    }
                    Console.WriteLine(initialValue);
                    Console.ReadLine();
                    
                    break;
                    
                case "f":
                case "F":
                    /*
                     * Write and test in the computer a program that reads a sequence of integers entered by the keyboard.
                     * The program will sum values each time they are introduced, until the sum will be bigger than a pre-established
                     * number by means of a constant of the program (just like we defined constant MAX in the previous example).
                     * When it happens, the program prints on the screen the value of the sum and it finishes.
                     */
                    
                    int firstInputNumber3, secondInputNumber3, resultNumber3, integredInputNumber3;
                    
                    Console.WriteLine("Introduce a number");
                    firstInputNumber3 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("+");
                    
                    secondInputNumber3 = Convert.ToInt32(Console.ReadLine());
                    resultNumber3 = firstInputNumber3 + secondInputNumber3;
                    
                    while ( resultNumber3 <= Max3  )
                    {
                        Console.WriteLine("+");
                        integredInputNumber3 = Convert.ToInt32(Console.ReadLine());
                        resultNumber3 = resultNumber3 + integredInputNumber3;
                        
                    }

                    Console.WriteLine("The limit value {0} have been exceeded.", Max3);
                    Console.WriteLine("The result of your operation is : {0}", resultNumber3);
                    Console.ReadLine();
                    
                    break;
                
            }
        }
    }
}