using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBABILITY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n;
                Console.WriteLine("Enter the num of items");
                n = int.Parse(Console.ReadLine());
                double[] items = new double[n];

                int i;
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("the numbers " + ((i + 1)));
                    items[i] = int.Parse(Console.ReadLine());

                }
                Array.Sort(items);

                Console.WriteLine("the numbers : ");


                foreach (double x in items)
                {

                    Console.Write(x + "\t");

                }

                int j = (n + 1) / 2;
                double median = items[j - 1];
                int u = n / 2;
                double g = (n / 2) + 1;
                double mediann = (items[(int)g - 1] + items[u - 1]) / 2;
                if (n % 2 != 0)
                {
                    Console.Write("\n" + "the median :");
                    Console.WriteLine(median);
                }
                else
                {
                    Console.WriteLine("\n" + "the median :" + mediann);

                }
                double mode1 = items[0];
                int count1 = 0;
                for (i = 0; i < n; i++)
                {
                    double mode = items[i];
                    int count = 0;
                    for (j = 0; j < n; j++)
                    {
                        if (items[j] == mode)
                            count++;
                    }
                    if (count > count1)
                        count1 = count;
                    mode1 = mode;
                }
                Console.WriteLine("the mode ;" + (mode1));

                double range = items[n - 1] - items[0];
                Console.WriteLine(" the range :" + (range));

                int q1Index = (int)Math.Ceiling(n * 0.25) - 1;
                double q1 = items[q1Index];

                int q3Index = (int)Math.Floor(n * 0.75) - 1;
                double q3 = items[q3Index];

                Console.WriteLine("q1 :" + (q1));
                Console.WriteLine("q3 :" + (q3));
                int p90Index = (int)Math.Ceiling(n * 0.9) - 1;
                double p90 = items[p90Index];
                Console.WriteLine("p90 :" + (p90));
                double iqr = q3 - q1;
                Console.WriteLine("interquartile :" + ((iqr)));






            }
        }
    }
}
