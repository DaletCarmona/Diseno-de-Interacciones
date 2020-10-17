using System;
using System.Collections.Generic;

namespace Problema_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int target = 9;
            int[] cad = { 9, 8, 7, 3, 4, 2, 1 },res;
            
            //Imprimir Cadena
            Console.Write("[");
            for (int i = 0; i < cad.Length; i++) 
            {
                if(i!=cad.Length-1)
                    Console.Write( cad[i]+", ");
                else
                    Console.Write(cad[i]);
            }
            Console.Write("]\n\n");

            res = SumarDos(cad, target);
            
            //Imprimir Cadena
            Console.Write("[");
            for (int i = 0; i < res.Length; i++)
            {
                if (i != res.Length - 1)
                    Console.Write(res[i] + ", ");
                else
                    Console.Write(res[i]);
            }
            Console.Write("]");

        }

        public static int[] SumarDos(int[] cad, int target)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < cad.Length; i++)
            {
                for (int j = i + 1; j < cad.Length; j++)
                {
                    if (cad[i] + cad[j] == target)
                    {
                        res.Add(cad[i]);
                        res.Add(cad[j]);
                        cad[i] = 0;
                        cad[j] = 0;
                    }
                }
            }
            return res.ToArray();
        }
    }
}
