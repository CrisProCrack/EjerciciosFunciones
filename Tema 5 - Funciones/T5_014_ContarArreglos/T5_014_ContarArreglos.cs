using System;
namespace T5_014_ContarArreglos
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion constante
            const int nTam = 5;
            
            //Declaracion de variables
           int [] aNumeros = new int[nTam];
           int nValorBuscar = 0;
           int nContador = 0;
            
            //Entrada
            Console.WriteLine(" Arreglo         Valor");
            Console.WriteLine("");
            for (int i = 0; i < nTam; i++)
            {
                Console.Write("aNumeros[" + i + "] <- ");
                aNumeros[i] = int.Parse(Console.ReadLine());
            }
            
            //Proceso
            Console.WriteLine("");
            Console.Write("Buscar : ");
            nValorBuscar = int.Parse(Console.ReadLine());
            
            ContarOcurrencias(aNumeros, nValorBuscar, ref nContador);
            
            //Salida
            Console.WriteLine("");
            Console.WriteLine("El numero " + nValorBuscar + " aparece " + nContador + " veces");
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        //Funcion que modifica los elementos del arreglo multiplicandolos por 2
        public static void ContarOcurrencias(int[] pNumeros, int pBuscar, ref int pContador)
        {
            pContador = 0;
            foreach (int numero in pNumeros)
            {
                if (numero == pBuscar)
                {
                    pContador++;
                }
            }
        }
        // Termina seccion de funciones o modulos
    }
}