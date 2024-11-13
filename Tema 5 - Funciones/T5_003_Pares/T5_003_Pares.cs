using System;
namespace T5_003_Pares
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            int nNumero;
            
            //Entrada
            Console.WriteLine("Número : ");
            nNumero = int.Parse(Console.ReadLine());
            
            //Proceso y salida
            if (EsPar(nNumero))
            {
                Console.WriteLine(nNumero + " es par");
            }
            else
            {
                Console.WriteLine(nNumero + " es impar");
            }
            
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inici seccion de funciones o modulos
        static bool EsPar(int num)
        {
            return num % 2 == 0; //Retorna verdadero si el numero es par
        }
        // Termina seccion de funciones o modulos
    }
}