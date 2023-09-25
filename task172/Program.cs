using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task172
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
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }

            Console.WriteLine("Массив после смены местами:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
