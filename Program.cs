using System;
using System.Collections.Generic;
using System.IO;

namespace Colecciones_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> Numeros = new List<int> {};


            Numeros.Add(1);
            Numeros.Add(2);
            Numeros.Add(3);
            Numeros.Add(4);
            Numeros.Add(5);

            //agregando los elementos de un array a una coleccion
            int[] AgregarMas = new int[]{ 6, 7, 8, 9, 10};

            for (int i = 0; i < 5; i++)
            {
                Numeros.Add(AgregarMas[i]);
            }



            //Para agregar un valor en una posición determinada
            Numeros.Insert(2, 3);

            //Elimina un elemento por su posicion
            Numeros.RemoveAt(2);

            int z = 0;

            foreach (int elementos in Numeros)
            {
                Console.WriteLine($"Elemento numero {z}: {elementos}");
                z++;
            }
            
            //Cambia totalmente las posiciones de los números
            Numeros.Reverse();
            
            z = 0;
            Console.WriteLine();
            
            Console.WriteLine("Numeros invertidos");
            foreach (int elementos in Numeros)
            {
                Console.WriteLine($"Elemento numero {z}: {elementos}");
                z++;
            }



            //Coleccion para que el usuario rellene por la consola
            Console.WriteLine();
            Console.WriteLine("Agregando nombre");


            //Creacion de coleccion
            List<string> nombres = new List<string>();

            Console.WriteLine("Rellena la coleccion/ Presiona s para salir");

            string aggNombre = "";
            
            Console.WriteLine();

            //El usuario rellena la coleccion hasta precionar la tecla "S"
            while (aggNombre != "S")
            {
                
                aggNombre = Console.ReadLine().ToUpper();

                nombres.Add(aggNombre);

            }
            Console.WriteLine();
            //Eliminando el ultimo elemento "S" que se agrega en la coleccion
            nombres.RemoveAt(nombres.Count-1);

            //Recorriendo todos los elementos de la coleccion
            Console.WriteLine("Nombres agregados:");
            foreach (string elemento in nombres)
            {
                Console.WriteLine(elemento);
            }


            Console.ReadKey();
        }
    }
}
