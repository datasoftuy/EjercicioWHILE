using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 1 - dejo en eterno loop el programa -------------------------------------------------------------
            /*int unNumero = 0;
            while (true)
             {
                 Console.WriteLine(unNumero);
                 unNumero++;
             }*/


            //Ejemplo 2 - realizo una cuenta progresiva de 0 a 15 con WHILE-------------------------------------------
            int unNumero = 0;

            Console.WriteLine("\n * Cuenta Progresiva - While");

            unNumero = 0;
            while (unNumero <= 15)
            {
                Console.WriteLine(unNumero);
                unNumero++;
            }

            //Ejemplo 3 - realizo cuenta progresiva de 0 a 15 con FOR--------------------------------------------------
            Console.WriteLine("\n *Cuenta Progresiva - For");
            for (unNumero = 0; unNumero <= 15; unNumero++)
            { Console.WriteLine(unNumero); }

            //Ejemplo 4 - despejar la potencia 2 ^ 4 con FOR -----------------------------------------------------------
            int numBase = 2;
            int numExp = 4;
            int resultado = 1;
            for (int contador = 1; contador <= numExp; contador++)
            {
                resultado = resultado * numBase;
            }

            Console.Write("\n * El resultado de 2 ^ 4 es: " + resultado);

            //Ejemplo 5 - Solicitar valor hasta que sea correcto con While ---------------------------------------------
            string dato = "";
            int numero = 0;
            bool error = true; //Esta variable es una BANDERA
            Console.Write("\n * Tabla de Multiplicar (1-10) *");

            while (error)
            {
                Console.Write("\nIngrese un número entre 1 y 10: ");
                
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero >= 1 && numero <= 10)
                    { error = false; }
                    else
                    {
                        Console.Write("El valor ingresado no es válido. Entre para reintentar");
                        Console.ReadLine();
                    }
                }
                catch
                { Console.Write("El valor ingresado no tiene formato numérico."); }
            }

            Console.WriteLine("\n * Ha ingresado el número " + numero + ".\n La Tabla es: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

            Console.ReadLine();
        }
    }
}
