using System;
namespace T5_005_Celsius_Fahrenheit
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            double nGradosC;
            double nGradosF;
            
            //Entrada
            Console.WriteLine("Grados Celsius : ");
            nGradosC = double.Parse(Console.ReadLine());
            
            //Proceso
            nGradosF = ConvertirCelsiusAFahrenheit(nGradosC);

            //Salida
            Console.WriteLine(nGradosC + " grados Celsius = " + nGradosF.ToString("#.###") + " grados Fahrenheit");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        static double ConvertirCelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}