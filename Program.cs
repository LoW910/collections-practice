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



            // Multidimensional arrays
            int [,] array2D = new int[3,2];
            int [,,] array3D = new int[2,3,4]
            {
                {   {45, 1, 16, 17}, {4, 47, 21, 68}, {21, 28, 32, 76} },
                {   {11, 0, 85, 42}, {9, 10, 14, 96}, {66, 99, 33, 12} }
            };

            System.Console.WriteLine(array2D[0,1]); // prints 0
            System.Console.WriteLine(array3D[1,0,3]); // prints 42

            int [][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            
            int[][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };

            int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {4,6},
                new int[] {55,66,77,88}
            };

            int[][,] jaggedArray4 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,8}, {4,6}, {8,10} },
                new int[,] { {99,11}, {55,33}, {98, 16}}
            };

            foreach (int[] innerArr in jaggedArray)
            {
                System.Console.WriteLine("Inner array length is {0}", innerArr.Length);
            }

            System.Console.WriteLine(jaggedArray2[0][1]); // 3
            System.Console.WriteLine(jaggedArray3[2][3]); // 88









        }
    }
}
