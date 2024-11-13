using System;

namespace T5_001_Factorial

{

    class Program

    {

        public static void Main(string[] args)

        {

            //Declaracion de variables

            int nNumero;

            int nResultado;

            //Entrada

            Console.WriteLine("Número : ");

            nNumero = int.Parse(Console.ReadLine());

            //Proceso

            nResultado = CalcularFactorial(nNumero);

            //Salida

            Console.WriteLine("El factorial de " + nNumero + " es " + nResultado.ToString("#,###"));

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();

        }

        //Inici seccion de funciones o modulos

        static int CalcularFactorial(int n)

        {

            if (n <= 1) return 1;

            return n * CalcularFactorial(n - 1);

        }

    }

}