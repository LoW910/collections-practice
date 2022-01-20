using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] zeroNine = {0,1,2,3,4,5,6,7,8,9};
            bool [] yesNo ={true,false,true,false,true,false,true,false,true,false};


            string [] names = {"Tim", "Martin", "Nikki", "Amanda"};
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Strawberry");
            iceCreamFlavors.Add("Chocolate");
            iceCreamFlavors.Add("Vanilla");
            iceCreamFlavors.Add("Mint Chocolate");
            iceCreamFlavors.Add("Orange");

            System.Console.WriteLine($"We have {iceCreamFlavors.Count} flavors of icecream.");
            System.Console.WriteLine($"The third flavor is: {iceCreamFlavors[2]}");
            iceCreamFlavors.Remove(iceCreamFlavors[2]);
            System.Console.WriteLine($"We have {iceCreamFlavors.Count} flavors of icecream.");


            Dictionary<string,string> kv = new Dictionary<string, string>();

            Random rand = new Random();

            foreach (string name in names) {
                kv.Add(name, iceCreamFlavors[rand.Next(0, iceCreamFlavors.Count)]);
            }

            foreach (var rum in kv)
            {
                System.Console.WriteLine(rum.Key + " ** " + rum.Value);
            }















        }
    }
}
