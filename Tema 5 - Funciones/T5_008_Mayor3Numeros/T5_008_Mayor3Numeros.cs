using System;
namespace T5_008_Mayor3Numeros
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            int nNumero1;
            int nNumero2;
            int nNumero3;
            int nMayor;
            
            //Entrada
            Console.Write("Numero 1 : ");
            nNumero1 = int.Parse(Console.ReadLine());
            
            Console.Write("Numero 2 : ");
            nNumero2 = int.Parse(Console.ReadLine());
            
            Console.Write("Numero 3 : ");
            nNumero3 = int.Parse(Console.ReadLine());
            
            //Proceso
            nMayor = EncontarMayor(nNumero1, nNumero2, nNumero3);

            

            //Salida
            Console.WriteLine("El mayor entre " + nNumero1 + ", " + nNumero2 + " y " + nNumero3 + " es " + nMayor);
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        static int EncontarMayor(int a, int b, int c)
        {
            int mayor;
            
            //Comparaciones usando if
            if (a >= b && a >= c)
            {
                mayor = a;
            }
            else if (b >= a && b >= c)
            {
                mayor = b;
            }
            else
            {
                mayor = c;
            }

            return mayor;
        }
        // Termina seccion de funciones o modulos
    }
}