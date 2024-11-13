using System;
namespace T5_012_AreaPerimetro
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            double nLargo;
            double nAncho;
            double nArea;
            double nPerimetro;
            
            //Entrada
            Console.Write("Largo : ");
            nLargo = double.Parse(Console.ReadLine());
            
            Console.Write("Ancho : ");
            nAncho = double.Parse(Console.ReadLine());
            

            //Proceso
            CalcularAreaYPerimetro(nLargo, nAncho, out nArea, out nPerimetro);
            
            
            //Salida
            Console.WriteLine("");
            Console.WriteLine("Area             : " + nArea.ToString("#,###.##"));
            Console.WriteLine("Perimetro        : " + nPerimetro.ToString("#,###.##"));
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        static void CalcularAreaYPerimetro(double pLargo, double pAncho, out double pArea, out double pPerimetro)
        {
            pArea = pLargo * pAncho;
            pPerimetro = 2 * (pLargo + pAncho);
        }
        // Termina seccion de funciones o modulos
    }
}