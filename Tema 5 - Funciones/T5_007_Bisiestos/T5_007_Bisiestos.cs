using System;
namespace T5_005_SumaNPares
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            int nAnio;
            
            //Entrada
            Console.Write("Año : ");
            nAnio = int.Parse(Console.ReadLine());
            
            //Proceso
            if (EsBisiesto(nAnio))
            {
                Console.WriteLine("El año " + nAnio + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + nAnio + " no es bisiesto");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        static bool EsBisiesto(int pAnio)
        {
            /* Un año es bisiesto si es divisible por 4,
             pero no por 100, a menos que tambien sea divisible por 400.*/
            return (pAnio % 4 == 0 && pAnio % 100 != 0) || (pAnio % 400 == 0);
        }
        // Termina seccion de funciones o modulos
    }
}