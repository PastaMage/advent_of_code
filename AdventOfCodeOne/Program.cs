using System;

namespace AdventOfCodeOne 
{ 
    class Program
    {
        private static void Main(string[] args)
        {
            const string fileName = "/home/pastamage/advent_of_code/AdventOfCodeOne/AdventOfCodeOne/input.txt"; 
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
            
            foreach (int line in numbersOne) 
            { 
                Console.WriteLine(line); 
            }
        }
    }
}