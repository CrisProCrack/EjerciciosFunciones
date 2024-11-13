using System;
namespace T5_013_ModicaArreglo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion e inicializar un arreglo
            int[] aNumeros = { 10, 20, 30, 40, 50 };
            
            //Mostrar el arreglo original
            Console.WriteLine("Arreglo original             :" + string.Join(",", aNumeros));
            
            //Llamar a la funcion para modificar el arreglo
            ModificarArreglo(ref aNumeros);
            
            //Mostrar el arreglo modificado
            Console.WriteLine("Arreglo modificado( multiplicado * 2) :" + string.Join(",", aNumeros));
            
            
            //Salida
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        //Funcion que modifica los elementos del arreglo multiplicandolos por 2
        static void ModificarArreglo(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 2; //Multiplcar cada elemento por 2
            }
        }
        // Termina seccion de funciones o modulos
    }
}