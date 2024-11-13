using System;
namespace T5_005_SumaNPares
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            int nLimite;
            int nsumaPares;
            
            //Entrada
            Console.Write("Limite de N : ");
            nLimite = int.Parse(Console.ReadLine());
            
            //Proceso
            //Llamada a la funcion para generar numero pares y calcular la suma
            nsumaPares = GenerarNumerosPares(nLimite);

            //Salida
            Console.WriteLine("La suma de los pares entre 0 y  " + nLimite + " es " + nsumaPares.ToString("#.###"));
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inici seccion de funciones o modulos
        static int GenerarNumerosPares(int limite)
        {
            int suma = 0;
            Console.WriteLine("Numeros pares:");
            for (int i = 0; i < limite; i+= 2)
            {
                Console.WriteLine(i);
                suma = suma + i;
            }

            return suma;
        }
        // Termina seccion de funciones o modulos
    }
}