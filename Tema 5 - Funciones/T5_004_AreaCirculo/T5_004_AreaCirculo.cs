using System;

namespace T5_004_AreaCirculo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            double nRadio;
            double nArea;
            //Entrada
            Console.WriteLine("Radio : ");
            nRadio = double.Parse(Console.ReadLine());
            //Proceso
            nArea = CalcularAreaCirculo(nRadio);

            //Salida
            Console.WriteLine("El área del círculo con radio " + nRadio + " = " + nArea.ToString("#,###.##"));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        static double CalcularAreaCirculo(double r)
        {
            return Math.PI * r * r;
        }
    }
}