using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task60
{
    internal class Program
    {
        static double CalculateFunction(double a, double b, double ω, double φ, double x)
        {
            return a * Math.Exp(-b * x) * Math.Sin(ω * x + φ);
        }

        static bool IsLocalMinimum(double prevY, double currentY, double nextY)
        {
            return currentY < prevY && currentY < nextY;
        }

        static bool IsLocalMaximum(double prevY, double currentY, double nextY)
        {
            return currentY > prevY && currentY > nextY;
        }
        static void Main(string[] args)
        {
            double a = 1.0;
            double b = 0.1;
            double ω = 1.0;
            double φ = 0.0;
            double step = 0.1;
            double x = 0.0;
            double prevY = CalculateFunction(a, b, ω, φ, x);
            double currentY;

            double[] yValues = new double[5];
            int index = 0;

            for (x = 0.1; x <= 5.0; x += step)
            {
                currentY = CalculateFunction(a, b, ω, φ, x);

                if (IsLocalMinimum(prevY, currentY, CalculateFunction(a, b, ω, φ, x + step)))
                {
                    if (index >= yValues.Length)
                    {
                        Array.Resize(ref yValues, yValues.Length + 5);
                    }

                    yValues[index] = currentY;
                    index++;
                    Console.WriteLine($"Минимум: x = {x}, y = {currentY}");
                }
                else if (IsLocalMaximum(prevY, currentY, CalculateFunction(a, b, ω, φ, x + step)))
                {
                    if (index >= yValues.Length)
                    {
                        Array.Resize(ref yValues, yValues.Length + 5);
                    }

                    yValues[index] = currentY;
                    index++;
                    Console.WriteLine($"Максимум: x = {x}, y = {currentY}");
                }

                prevY = currentY;
            }

            double[] actualYValues = new double[index];
            Array.Copy(yValues, actualYValues, index);

            for (int i = 0; i < actualYValues.Length; i++)
            {
                Console.WriteLine(actualYValues[i] + " ");
            }
            Console.WriteLine(actualYValues.Length);

        }
    }
    }

