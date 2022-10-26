using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            int lowerLimitRandom = 0;
            int upperLimitRandom = 100;

            Console.Write("Исходный массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(lowerLimitRandom, upperLimitRandom + 1);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Числе являющиеся локальный максимумом:  ");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2]) 
            {
                Console.Write(numbers[numbers.Length - 1]);
            }

            Console.ReadKey();
        }
    }
}
