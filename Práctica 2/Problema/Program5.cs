using System;

namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            int var;
            int[] arreglo = { 10, 153, 1548, 95366, 154256 };
            var=Compare(arreglo);

            Console.Out.WriteLine(var);

        }

        static int Compare(int[] arreglo)
        {
            int x = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if( (arreglo[i].ToString()).Length%2==0 )
                {
                    x++;
                }

            }

            return x;
        }
    }
}

