using System;
namespace T5_011_CambiaNumero
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            int nNumero;
            
            
            //Entrada
            Console.Write("Numero entero : ");
            nNumero = int.Parse(Console.ReadLine());
            

            //Proceso y salida
            Console.WriteLine("");
            Console.WriteLine("Valor antes                          : " + nNumero);
            CambiarValor(ref nNumero);

            Console.WriteLine("Valor despues de incrementarle 10  : " + nNumero);
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        static void CambiarValor(ref int valor)
        {
            valor = valor + 10; //Aumenta el valor en 10
        }
        // Termina seccion de funciones o modulos
    }
}