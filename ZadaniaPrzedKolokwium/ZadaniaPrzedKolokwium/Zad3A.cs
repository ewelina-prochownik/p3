using System;

namespace ZadaniaPrzedKolokwium
{
    public class Zad3A
    {
        public void KopiaTablicy()
        {
            int[][] tablica =
            {
                new[] {2, 15, 6},
                new[] {7, 8},
                new[] {9, 12, 3, 4}
            };

            int[,] nowaTablica = new int[tablica.Length, 4];


            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    nowaTablica[i, j] = tablica[i][j];
                }
            }

            for (int i = 0; i < nowaTablica.GetLength(0); i++)
            {
                for (int j = 0; j < nowaTablica.GetLength(1); j++)
                {
                    Console.Write(nowaTablica[i,j] + "\t");
                }

                Console.WriteLine();
            }
            
        }
    }
}