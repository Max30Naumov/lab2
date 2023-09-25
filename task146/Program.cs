using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(100);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nВведите цифру k: ");
            int k = int.Parse(Console.ReadLine());

            int[] resultArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string originalNumberAsString = arr[i].ToString();
                string newNumberAsString = originalNumberAsString + k.ToString();
                resultArray[i] = int.Parse(newNumberAsString);
            }

            Console.WriteLine("Элементы исходного массива, оканчивающиеся на цифру k:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
