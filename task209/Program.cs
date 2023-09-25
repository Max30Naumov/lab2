using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task209
{
    internal class Program
    {
       public static void AddNums()
        {
            int[] a = new int[20] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 1, 1 };
            int[] b = new int[20] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9, 1, 1 };


            int[] c = new int[20];
            int carry = 0;
            for (int i = 19; i >= 0; i--)
            {
                c[i] = a[i] + b[i] + carry;
                carry = c[i] / 10;
                c[i] %= 10;
            }

            Console.WriteLine("Сумма:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine();

        }
        public static void MinusNums()
        {

            int[] a = new int[30] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            int[] b = new int[30] { 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };


            int[] c = new int[30];
            int borrow = 0;
            for (int i = 29; i >= 0; i--)
            {
                c[i] = a[i] - b[i] - borrow;
                if (c[i] < 0)
                {
                    c[i] += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }
            }

            Console.WriteLine("Разность:");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            AddNums();
            MinusNums();
        }
    }
}
