using System;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            
//Zadanie 2

            int[][] tablica =
            {
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 3, 4, 5}
            };

            int[][] nowaTablicaPoszarpana = new int[tablica.Length][];

            for (int i = 0; i < tablica.Length; i++)
            {
                nowaTablicaPoszarpana[i] = new int[tablica[i].Length];
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    nowaTablicaPoszarpana[i][j] = tablica[i][j];
                }
            }

            nowaTablicaPoszarpana[2][1] = 100;

            Console.WriteLine("Tablica");
            foreach (var rzad in tablica)
            {
                foreach (var element in rzad)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nNowa tablica");
            foreach (var rzad in nowaTablicaPoszarpana)
            {
                foreach (var element in rzad)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine();
            }


// Zadanie 1

//            int[,] tablica =
//            {
//                {1, 2, 3, 4, 5},
//                {1, 2, 3, 4, 5},
//                {1, 2, 3, 4, 5},
//                {1, 2, 3, 4, 5},
//                {1, 2, 3, 4, 5},
//            };
//            int[,] nowaTablica = new int[tablica.GetLength(0), tablica.GetLength(1)];
//
//            for (int i = 0; i < tablica.GetLength(0); i++)
//            {
//                for (int j = 0; j < tablica.GetLength(1); j++)
//                {
//                    nowaTablica[i, j] = tablica[i, j];
//                }
//            }
//            
//            nowaTablica[3,3] = 10;
//            
//            foreach (var liczba in tablica)
//            {
//                Console.WriteLine(liczba);
//            }
//
//            foreach (var liczba in nowaTablica)
//            {
//                Console.WriteLine(liczba);
//            }
//
//            Console.WriteLine();
        }
    }
}