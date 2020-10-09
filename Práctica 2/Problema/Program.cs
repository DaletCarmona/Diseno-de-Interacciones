using System;

namespace Problema_Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var;
            string[] lista = {"MUFASA", "SCAR", "SIMBA", "NALA", "KIARA", "SARABI", "PUMBAA", "TIMON", "ZAZU", "KOBU"};
            string nombre;
    
            nombre=Console.ReadLine();
            var=Compare(lista, nombre);

            if (var == 1)
                Console.WriteLine("Nombre en Lista");
            else
                Console.WriteLine("Nombre no en Lista");
        }

        static int Compare(string[] lista, string nombre) 
        {
            for (int i = 0; i < 10; i++) 
            {

                if (String.Equals(lista[i], nombre.ToUpper()))
                    return 1;
            }

            return 0;
        }
    }
}
