using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vett = new int [10] { 8, 4, -9, 5, 2 , 1, 7, 45, 76, 89};

            Ordina(vett);
            int min = Minimo(vett);

            Console.WriteLine("Il valore minimo è: " + min);

        }

        static void Ordina(int [] v)
        {
            Array.Sort(v);
        }

        static int Minimo(int [] v)
        {
            return v[0];
        }
            
    }
}
