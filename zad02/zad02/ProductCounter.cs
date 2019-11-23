using System;

namespace zad02
{
    public class ProductCounter
    {
        private static int productsAmount = 0;

        private static void UniqueName(string productName)
        {
            productsAmount++;
            Console.WriteLine("Amount of products [" + productName + "]: " + productsAmount);
        }

        public static void CountProducts()
        {
            Console.WriteLine("Type product name (hammer, screwdriver, saw) to get a total of all products " +
                              "or type \"exit\" to close the application.");
            
            string escape = "exit";
            string result = "";

            while (!result.Equals(escape))
            {
                result = Console.ReadLine();
                switch (result)
                {
                    case "hammer":
                        UniqueName("hammer");
                        break;
                    case "screwdriver":
                        UniqueName("screwdriver");
                        break;
                    case "saw":
                        UniqueName("saw");
                        break;
                    default:
                        Console.WriteLine("Type correct product name!");
                        break;
                }
            }
        }
    }
}