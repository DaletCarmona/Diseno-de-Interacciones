using System;
using System.Collections.Generic;
using System.Linq;

namespace Práctica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len=0;
            int[] cad = {8,1,2,2,3};
            string arr = String.Empty;
            len = CapturaLen(len, arr);
            cad = Captura(len, arr);
            Imprimir(Mayores(cad));

        }

        public static int CapturaLen(int len, string arr)
        {
            Console.Write("Capture la cantidad de elementos: ");
            arr = Console.ReadLine();
            //Console.WriteLine(arr); //Fue puesto para Trouble Shooting
            len = Convert.ToInt32(arr);
            return len;
        }

        public static int[] Captura(int len, string arr)
        {
            var comp = new List<int>();
            for (int i = 0; i < len; i++) {

                Console.Write("Capture componente " + (i+1) + ": ");
                arr = Console.ReadLine();
                comp.Add(Convert.ToInt32(arr));
            }

            int[] array = comp.ToArray();
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
                //Console.WriteLine(tot);
            }
            return arr;
        }

        public static void Imprimir(int[] cad)
        {
            Console.Write("Nueva Cadena: [");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(cad[i] + ", ");
            }
            Console.Write("\b\b]");
        }

    }
}
