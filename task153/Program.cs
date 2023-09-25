using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task153
{
    internal class Program
    {
       
        static void MultiplyPolynomials(double[] A, double[] B, double[] C)
        {
            int K = A.Length;
            int L = B.Length;
            int M = K + L;

            for (int i = 0; i < M; i++)
            {
                C[i] = 0; 

                for (int j = 0; j < K; j++)
                {
                    if (i - j >= 0 && i - j < L)
                    {
                        C[i] += A[j] * B[i - j];
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            int K = 3; 
            int L = 2; 
            int M = K + L;

            double[] A = { 1, 2, 3 }; 
            double[] B = { 4, 5 };    
            double[] C = new double[M];

            MultiplyPolynomials(A, B, C);

            Console.WriteLine("Коэффициенты произведения многочленов C:");
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"C[{i}] = {C[i]}");
            }
        }
    }
}
