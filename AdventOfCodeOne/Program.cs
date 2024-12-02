using System;

namespace AdventOfCodeOne 
{ 
    class Program
    {
        private static void Main(string[] args)
        {
            const string fileName = "C:\\Users\\max54\\RiderProjects\\advent_of_code\\AdventOfCodeOne\\input.txt"; 
            string input = System.IO.File.ReadAllText(fileName); 
            string[] lines = input.Split('\n'); 
            int[] numbersOne = new int[lines.Length]; 
            int[] numbersTwo = new int[lines.Length]; 
            for(int i = 0; i < lines.Length; i++)
            {
                int[] nums = lines[i].Split("   ").Select(int.Parse).ToArray(); 
                numbersOne[i] = nums[0]; 
                numbersTwo[i] = nums[1]; 
            }
            Array.Sort(numbersOne);
            Array.Sort(numbersTwo);
            int result = 0;
            for(int i = 0; i < numbersOne.Length; i++) 
            { 
                result += Math.Abs(numbersOne[i] - numbersTwo[i]);
            }
            Console.WriteLine(result);
        }
    }
}