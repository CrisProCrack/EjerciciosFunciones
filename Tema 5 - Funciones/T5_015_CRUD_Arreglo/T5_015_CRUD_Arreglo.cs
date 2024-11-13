using System;
namespace T5_015_CRUD_Arreglo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declar constante
            const int nTam = 5;
            //Definicion del arreglo de temperaturas
            double[] aTemperaturas = new double[nTam];
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu de opciones:");
                Console.WriteLine("1. Ingresar temperaturas");
                Console.WriteLine("2. Mostrar temperaturas");
                Console.WriteLine("3. Calcular promedio");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarTemperaturas(ref aTemperaturas);

                        break;
                    case 2:
                        MostrarTemperaturas(ref aTemperaturas);

                        break;
                    case 3:
                        CalcularPromedio(ref aTemperaturas);

                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            } while (opcion != 4);
        }
        
        //Inicia seccion de funciones o modulos
        //Funcion para ingresar temperaturas
        static void IngresarTemperaturas(ref double[] temperaturas)
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write("Temperatura " + (i + 1) + ": ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }
        }
        
        //Funcion para mostrar temperaturas
        static void MostrarTemperaturas(ref double[] temperaturas)
        {
            Console.WriteLine("");
            Console.WriteLine("Las temperaturas ingresadas son:");
            foreach (var temp in temperaturas)
            {
                Console.WriteLine(temp);
            }
        }
        
        //Funcion para calcular el promedio de las temperaturas
        static void CalcularPromedio(ref double[] temperaturas)
        {
            double suma = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
            }
            double promedio = suma / temperaturas.Length;
            Console.WriteLine("El promedio de las temperaturas es: " + promedio.ToString("#.###"));
        }
        
        // Termina seccion de funciones o modulos
        
    }
}