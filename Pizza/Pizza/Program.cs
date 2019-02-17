using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Pizza
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] instructions;

            var pizza = GetInputFilesAndPopulateThem(out instructions);

            PizzaProcessor(instructions, pizza);
        }

        public static char[][] GetInputFilesAndPopulateThem(out int[] headerInstructions)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"a_example.in");

            string[] inputTestFile = File.ReadAllLines(path);

            headerInstructions = Array.ConvertAll(inputTestFile[0].Split(' '), t => Convert.ToInt32(t));

            int rows = headerInstructions[0];
            //int lines = headerInstructions[1];
            //int minOfEachIngredientPerSlice = headerInstructions[2];
            //int maxCellsPerSlice = headerInstructions[3];

            char[][] pizza = new char[rows][];
            int i = 0;

            foreach (string input in inputTestFile.Skip(1))
            {
                pizza[i] = input.ToArray();
                i++;
            }

            return pizza;
        }

        public static void PizzaProcessor(int[] headerInstructions, char[][] pizza)
        {
            int rows = headerInstructions[0];
            int lines = headerInstructions[1];
            int minOfEachIngredientPerSlice = headerInstructions[2];
            int maxCellsPerSlice = headerInstructions[3];

            foreach (var pizzaSlice in pizza)
            {
            }
        }
    }
}