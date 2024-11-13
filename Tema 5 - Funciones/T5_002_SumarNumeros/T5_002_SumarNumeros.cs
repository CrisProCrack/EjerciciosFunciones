using System;

namespace T5_002_SumarNumeros
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracio de variables
            int nNumero1;
            int nNumero2;
            int nSuma;
            
            //Entrada
            Console.Write("Número 1: ");
            nNumero1 = int.Parse(Console.ReadLine());
            
            Console.Write("Número 2: ");
            nNumero2 = int.Parse(Console.ReadLine());
            
            //Proceso
            nSuma = Sumar(nNumero1, nNumero2);
            
            //Salida
            Console.WriteLine("La suma de " + nNumero1 + " + " + nNumero2 + " es " + nSuma.ToString("#,###"));
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            /* Inici seccion de funciones o modulos
             "static" indica que el metodo puede ser invocado directamente usando el nombre de la clase que lo contiene
             sin crear una instancia de la clase*/
            static int Sumar(int x, int y)
            {
                return x + y;
            }
            //Termina seccion de funciones o modulos
        }
    }
}