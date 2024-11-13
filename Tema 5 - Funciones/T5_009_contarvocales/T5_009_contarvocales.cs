using System;
namespace T5_009_contarvocales
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaracion de variables
            string cCadena;
            int cantidadVocales1;
            int cantidadVocales2;
            
            //Entrada
            Console.Write("Cadena de texto : ");
            cCadena = Console.ReadLine();
            
            //Proceso
            cantidadVocales1 = ContarVocales(cCadena);
            cantidadVocales2 = ContarVocales(cCadena);

            
            //Salida
            Console.WriteLine("El numero de vocales en la cadena es: " + cantidadVocales1);
            Console.WriteLine("El numero de vocales en la cadena es: " + cantidadVocales2);
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        
        //Inicia seccion de funciones o modulos
        //Opcion 1
        static int ContarVocales(string texto)
        {
            int contador = 0;
            
            //Usamos un ciclo for para recorre cada caracter de la cadena
            for (int i = 0; i < texto.Length; i++)
            {
                char car = texto[i]; //Extraemos el caracter en la posicion i
                //Comparamos si el caracter es una vocal
                if (car == 'a' || car == 'e' || car == 'i' || car == 'o' || car == 'u' || car == 'A' || car == 'E' || car == 'I' || car == 'O' || car == 'U')
                {
                    contador++; //Incrementamos el contador
                }
            }

            return contador;
        }
        // Opcion 2
        static int ContarVocales2(string texto)
        {
            int contador = 0;
            string vocales = "aeiouAEIOU"; //Incluye tanto minusculas como mayusculas

            foreach (char car in texto) //En cada repeticion, se toma un caracter de la cadena texto y se asigna la variable "c"
            {
                //Convertir el caracter a string para usar Contains
                if (vocales.Contains(car.ToString())) //Verifica si el caracter es una vocal
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}