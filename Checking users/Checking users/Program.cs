using System.Net.Mime;
using System.Security;
using System.Security.Cryptography;

namespace Checking_users
{  using System;
    internal class Program
    {
        public static void Main(string[] args)
        {            
           
                    //Defino el tipo de variables 
                    string nameReceived;
                    string userReceived;
                    
                    //Nombre de usuario
                    var userRegistered ="user";
                    //Contraseña
                    string passwordRegistered = "user2020";
                    
            
                    
                    //Extraigo la fecha actual de localSystem
                    DateTime date = DateTime.Now;
                    string dateWithFormat = date.ToLongDateString();
                    
                    
                    
                    Console.WriteLine ("Cual es tu nombre:");
                    nameReceived = Console.ReadLine();
                    
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine ("Bienvenido " + nameReceived);
                    Console.WriteLine();
                    
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine ("Ingresa tu nombre de usuario: (Es: 'user')");
                    userReceived = Console.ReadLine();
            
                    if(userReceived == userRegistered)
                    {    
                        SecureString psw = maskInputString();
                        string password = new System.Net.NetworkCredential(string.Empty, psw).Password;
                        
                        if (password == passwordRegistered){
                            
                            Console.WriteLine();//Space
                            Console.WriteLine("Bienvenido de nuevo" );
                            Console.WriteLine();
                            Console.WriteLine("Entrada exitosa en la fecha: " + dateWithFormat + " de " + nameReceived);
                        }
                        else
                        {    
                            Console.Beep();
                            Console.WriteLine("Contraseña incorrecta prueba de nuevo ");
                        }                                
                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("Nombre de usuario inexistente por favor introduzcalo correctamente ");
                    }
                
        }

        private static SecureString maskInputString()
        {
            Console.WriteLine("Ingresa tu contraseña: (Es: 'user2020')");
            SecureString psw = new SecureString();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                if (!char.IsControl(keyInfo.KeyChar))
                {
                    psw.AppendChar(keyInfo.KeyChar);
                    Console.Write("*");
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && psw.Length > 0)
                {
                    psw.RemoveAt(psw.Length - 1);
                    Console.Write("\b \b");
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            {
                return psw;
            }
        }
        
    }
}