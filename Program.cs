using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] Names =  new string[] {"Tim", "Martin", "Nikki", "Sara"};
            Boolean[] trueFalse = {true, false, true, false, true, false, true, false, true, false};
            foreach (Boolean tf in trueFalse)
            {
                Console.WriteLine($"- {tf}");
            }
            List<string> flavors = new List<string>();
            flavors.Add("Mint Chocolate Chip");
            flavors.Add("Cherry Garcia");
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Cookies N' Cream");
            Console.WriteLine("The ice cream flavors are:");
            for (var idx=0; idx < flavors.Count; idx++)
            {
                Console.WriteLine("-" + flavors[idx]);
            }
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove("Chocolate");
            Console.WriteLine(flavors.Count);

            Dictionary<string,string> iceCream = new Dictionary<string,string>();
            iceCream.Add("Tim", "Mint Chocolate Chip");
            iceCream.Add("Martin", "Cherry Garcia");
            iceCream.Add("Nikki", "Vanilla");
            iceCream.Add("Sara", "Cookies N' Cream");
            foreach (var entry in iceCream)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
