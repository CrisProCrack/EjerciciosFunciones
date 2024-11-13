using System;
namespace T5_010_MenuArreglo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1. Calcular el area de un circulo");
                Console.WriteLine("2. Calcular el area de un cuadrado");
                Console.WriteLine("3. Calcular el area de un rectangulo");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //Entrada
                        Console.Write("Ingrese el radio del circulo: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        //Proceso
                        double areaCirculo = CalcularAreaCirculo(radio);
                        //Salida
                        Console.WriteLine("El area del circulo es: " + areaCirculo.ToString("#.###"));
                        break;
                    case 2:
                        //Entrada
                        Console.Write("Ingrese la longitud del lado del cuadrado: ");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        //Proceso
                        double areaCuadrado = CalcularAreaCuadrado(lado);
                        //Salida
                        Console.WriteLine("El area del cuadrado es: " + areaCuadrado.ToString("#.###"));
                        break;
                    case 3:
                        //Entrada
                        Console.Write("Ingrese la base del rectangulo: ");
                        double baseRect = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del rectangulo: ");
                        double alturaRect = Convert.ToDouble(Console.ReadLine());
                        //Proceso
                        double areaRectangulo = CalcularAreaRectangulo(baseRect, alturaRect);
                        //Salida
                        Console.WriteLine("El area del rectangulo es: " + areaRectangulo.ToString("#.###"));
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            } while (opcion != 4);
        }
        
        //Inicia seccion de funciones o modulos
        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        
        static double CalcularAreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
        
        static double CalcularAreaRectangulo(double baseRect, double alturaRect)
        {
            return baseRect * alturaRect;
        }
        // Termina seccion de funciones o modulos
        
    }
}