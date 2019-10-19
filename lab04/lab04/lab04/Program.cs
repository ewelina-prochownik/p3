using System;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {
//            int[][] poszarpana = new int[5][];
//            int[][] test =
//            {
//                new[] {1, 2, 3}
//            };

            int[][] tablica =
            {
                new [] {1, 2, 3, 4, 5},
                new [] {1, 2, 3, 4, 5},
                new [] {1, 2, 3, 4, 5},
                new [] {1, 2, 3, 4, 5},
                new [] {1, 2, 3, 4, 5}
            };

            int[][] nowaTablicaPoszarpana = new int[tablica.Length][];

            for (int i = 0; i < tablica.Length; i++)
            {
                nowaTablicaPoszarpana[i] = new int[tablica[i].Length];
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    nowaTablicaPoszarpana[i][j] = tablica[i][j];
                    

                    Console.Write(tablica[i][j]);
                    Console.WriteLine();
                    Console.Write(nowaTablicaPoszarpana[i][j]);
                }
            }
                    nowaTablicaPoszarpana[2][1] = 100;

//            nowaTablicaPoszarpana[2][1] = 100;
//
//            foreach (int[] liczba in tablica)
//            {
//                Console.Write(liczba);
//
//                foreach (int[] liczba2 in tablica)
//                {
//                    Console.Write(liczba2);
//                }
//            }
//
//            Console.WriteLine();
//            
//            foreach (var liczba in nowaTablicaPoszarpana)
//            {
//                Console.Write(liczba);
//                Console.Write(" ");
//            }




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