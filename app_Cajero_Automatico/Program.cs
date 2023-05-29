using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

public class app_Bank_Latam
{
    public static void Main(string[] args)
    {
        //Se define la salida del programa en false para que la podamos utilizar después.
        bool exit = false;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        //Declaración
        string id, password;
        //Saldo inicial.
        int saldo = 1000000;
        //Declaración como entero.
        int resta;

        //Haz esto mientras se usa el exit.
        while (!exit)
        {
            try
            {
                //Opciones.
                Console.WriteLine("\t******************BANK LATAM*****************\n");
                Console.WriteLine("Señor Usuario.. ");
                Console.WriteLine("¿Que transacción desea hacer?");
                Console.WriteLine("1. Crear Cuenta");
                Console.WriteLine("2. Iniciar Sesion");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Retirar Saldo");
                Console.WriteLine("5. Salir");

                //Se crea la variable opcion como entero mientras el ReadLine está en pantalla de carga mientras se introduce el dato.
                Console.WriteLine("Escribe el número: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //Registro de sesion.
                        Console.WriteLine("\t************Crear Cuenta*************\n");
                        Console.WriteLine("Ingrese su Cédula de Ciudadanía: ");
                        id = Console.ReadLine();
                        Console.WriteLine("Ingrese una contraseña: ");
                        password = Console.ReadLine();

                        Console.WriteLine($"Registro éxitoso. ID usuario: {id} y su contraseña: {password}");
                        Console.WriteLine("Has sido devuelto al Inicio.\n");
                        break;
                    case 2:
                        //Inicio de Sesion.
                        Console.WriteLine("\t****************Iniciar Sesion****************\n");
                        Console.WriteLine("Ingrese su Usuario: ");
                        id = Console.ReadLine();
                        Console.WriteLine("Ingrese una contraseña: ");
                        password = Console.ReadLine();

                        Console.WriteLine($"Señor Usuario, {id} Bienvenid@. ");
                        Console.WriteLine("Has sido devuelto al Inicio.\n");
                        break;
                    case 3:
                        //Consultar el saldo, se hace una itineración en vez de concatenación llamadno las variables en todo momento.
                        Console.WriteLine("\t***************Consultar Saldo*****************\n");
                        Console.WriteLine($"Tienes un saldo actual de: {saldo} ");
                        Console.WriteLine("\t***********************************************");
                        Console.WriteLine("Has sido devuelto al Inicio.\n");
                        break;
                    case 4:
                        //Se consulta el saldo y después lo resta con el saldo fijado.
                        Console.WriteLine("\t***************Retirar Saldo*****************\n");
                        Console.WriteLine("¿Cuánto saldo deseas retirar? ");
                        Console.WriteLine("$200.000 - $100.000 - $50.000 - $20.000 - $10.000 ");
                        resta = Convert.ToInt32(Console.ReadLine());
                        int contador = saldo - resta;
                        Console.WriteLine($"Has retirado: {resta}, Tu cuenta quedo con un saldo de: {contador}");
                        Console.WriteLine("\t*********************************************\n");
                        Console.WriteLine("Has sido devuelto al Inicio.\n");
                        break;
                    case 5:
                        //Se cierra la sesión cambiando el valor a true.
                        Console.WriteLine("Cerrando Sesion...");
                        exit = true;
                        break;
                    default:
                        //Si selecciono un numero distinto, me saltará esta opcion.
                        Console.WriteLine("Debes de elegir una opción.");
                        break;
                }

            }
            catch (FormatException e)
            {
                //En caso de algún error, mostrará mensaje.
                Console.Write(e.Message);
            }
        }
    }
}