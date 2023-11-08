using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aline Sathler Delfino - InClass4
//Name of Project: Dog Kennel
//Purpose: C# console application to control number of puppies each mom dogs had
//Revision History:
//REV00 - 2023/11/08 - Initial version



namespace ASDInClass4 {
    internal class Program {
        //Method to calculate the average of puppies per Mom Dogs
        static double[] AveragePuppies(int[,] litters) {
            double[] average = new double[litters.GetLength(0)/2];

            //Sum up the two rows of each Mom Dogs and get the average
            for (int i = 0; i < litters.GetLength(0); i+=2) {
                average[i/2] = (litters[i, 1] + litters[i + 1 , 1]) / 2.0; 
            }

            return average;
        }

        //Method to calculate the highest litter
        static string[] HighestLitter(int[,] litters) {
            string[] highestLitter = new string[litters.GetLength(0)/2];

            //compare the two litters of each Mom Dogs
            for (int i = 0; i < litters.GetLength(0); i += 2) {
                if (litters[i, 1] > litters[i + 1, 1]) {
                    highestLitter[i/2] = $"Litter 1";
                } else if (litters[i, 1] < litters[i + 1, 1]) {
                    highestLitter[i / 2] = $"Litter 2";
                } else {
                    highestLitter[i / 2] = $"Litters are equal";
                }
            }

            return highestLitter;
        }

        //Method to calculate the smallest number of puppies per mom
        static string SmallestLitter(int[,] litters) {
            int smallestNumberOfPuppies = 100;
            string index = "";

            //Comparing the litters and getting the index of the smallest one and the Mom Dogs
            for (int i = 0; i < litters.GetLength(0); i += 2) {
                if ((litters[i, 1] < smallestNumberOfPuppies)) {
                    smallestNumberOfPuppies = litters[i, 1];
                    index = $"Index of the mom with the smallest litter: [{i}, 0]\nIndex of the smallest litter: [{i}, 1]";
                }
            }

            return index;
        }
        static void Main() {
            //Mom Dogs, litter1
            //Mom Dogs, litter2
            int[,] litters = {
                { 1, 4 },
                { 1, 12 },
                { 2, 8 },
                { 2, 7 },
                { 3, 2 },
                { 3, 11 },
                { 4, 8 },
                { 4, 8 },
            };

            double[] average = new double[litters.GetLength(0)];
            string[] highestLitter = new string[litters.GetLength(0)];
            string index;

            //Calls average and print the results
            average = AveragePuppies(litters);
            Console.WriteLine("Average of puppies per Mom Dogs:");
            foreach (var item in average)
            {
                Console.WriteLine(item);
            }

            //Calls higgest number of puppies in a litter and print the results
            highestLitter = HighestLitter(litters);
            Console.WriteLine("\nHiggest number of puppies per Mom Dogs:");
            foreach (var item in highestLitter) {
                Console.WriteLine(item);
            }

            //Calls smallest litter and return and index of Mom Dogs and litter
            index = SmallestLitter(litters);
            Console.WriteLine();
            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
