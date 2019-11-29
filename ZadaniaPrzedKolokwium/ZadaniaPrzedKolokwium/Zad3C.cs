using System;
using System.Collections.Generic;

namespace ZadaniaPrzedKolokwium
{
    public class Zad3C
    {
        public void KopiaTablicy()
        {
            int[,] tablica =
            {
                {2, 5, 0, 0, 0},
                {64, 6, 0, 3, 0},
                {4, 0, 6, 0, 0}
            };

            int[][] nowaTablica = new int[tablica.GetLength(0)][];
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                List<int> tempList = new List<int>();
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i,j] != 0)
                    {
                        tempList.Add(tablica[i,j]);
                    }
                }

                nowaTablica[i] = tempList.ToArray();
            }

            for (int i = 0; i < nowaTablica.Length; i++)
            {
                for (int j = 0; j < nowaTablica[i].Length; j++)
                {
                    Console.Write(nowaTablica[i][j] + "\t");
                }

                Console.WriteLine();
            }
            
            
        }
    }
}