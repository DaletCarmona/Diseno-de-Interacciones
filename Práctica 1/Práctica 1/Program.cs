using System;
using System.Linq;

namespace Práctica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cad = {8,1,2,2,3};
            string arr = String.Empty;
            //cad = Captura(arr);
            Imprimir(Mayores(cad));

        }

        public static int[] Captura(string arr)
        {
            Console.WriteLine("Capture el arrego de enteros separados por una coma y sin corchetes, maximo 10 enteros.");
            arr = Console.ReadLine();
            Console.WriteLine(arr); //Fue puesto para Trouble Shooting
            int[] array = arr.Split(',').Select(int.Parse).ToArray();
            return array;
        }

        public static int[] Mayores(int[] cad)
        {
            int tot;
            int[] arr = new int[5];
            //Console.WriteLine(cad[0]);// Fue puesto para Trouble Shooting
            for (int i = 0; i < 5; i++)
            {
                tot = 0;
                for (int j = 0; j < 5; j++) {
                    if (cad[i] > cad[j]) 
                        tot++;

                }
                arr[i] = tot;
            }
            return arr;
        }

        public static void Imprimir(int[] cad)
        {
            Console.Write("Nueva Cadena: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(cad[i] + ", ");
            }
        }

    }
}
