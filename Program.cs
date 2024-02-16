

using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            Task11();
            Task12();
        }

        static void Task12()
        {
            int[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int Half = X.Length / 2;
            double count = 0;
            double count1 = 1;
            for (int i = 0; i < Half; i++)
            {
                count += X[i];
            }
            count /= Half;
            Console.WriteLine(count);
            for (int i = 11; i < 20; i++)
            {
                count1 *= X[i];
            }
            Console.WriteLine(count1);


            double FinalProduct  = Math.Pow(count1, 0.1);


            Console.WriteLine(FinalProduct);
        }
        static void Task1()
        {



            Console.WriteLine("Enter the element count of the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];


            Console.WriteLine("Insert the massive elements: ");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Insert array element number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Insert the maximum of the elements in the array: ");
            int c = Convert.ToInt32(Console.ReadLine());


            foreach (int i in array)
            {
                if (i < c)
                {
                    Console.WriteLine(i);
                }

            }

        }

        static void Task2()
        {
            Console.WriteLine("Enter the element count of the array: ");
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];


            Console.WriteLine("Insert the elements: ");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Insert array element number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Insert the maximum of the elements in the array: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int count = 0;
            foreach (int i in array)
            {
                if (i < c)
                {
                    sum += i;
                    count++;
                }

            }

            double result = (double)sum / count;

            Console.WriteLine(result);

        }

        static void Task3()
        {
            Console.WriteLine("Enter the element count of the array: ");
           
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];


            Console.WriteLine("Insert the elements: ");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Insert array element number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Insert the maximum of the elements in the array: ");

            int c = Convert.ToInt32(Console.ReadLine());

            int product  = 1;
            int count = 0;
            foreach (int i in array)
            {
                if (i < c)
                {
                    product *= i;
                    count++;
                }

            }


        }

        static void Task4()
        {
            Console.WriteLine("Enter the element count of the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];

            Console.WriteLine("Insert the elements: ");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Insert array element number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Insert the maximum of the elements in the array: ");
            int c = Convert.ToInt32(Console.ReadLine());


            foreach (int i in array)
            {
                if (i > c)
                {
                    Console.WriteLine(i);
                }

            }

            Array.Sort(array);
        }


        static void Task5()
        {


            Console.WriteLine("Enter the element count of the array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Insert the elements: ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Insert array element number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Insert the maximum of the elements in the array: ");

            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All the elements in the array:  \n");
            foreach (int i in array)
            {
                if (i < c)
                {
                    Console.WriteLine(i);

                }


            }
            Array.Sort(array);

            int maxNumber = array.Max();


            Console.WriteLine($"The maximum number in the array: {maxNumber}");
        }

        static void Task6()
        {

        }

        static void Task7()
        {
            Console.WriteLine("Enter the element count of the array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Insert the elements: ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Insert array element number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Array.Sort(array);

            double maxNumber = array.Max();
            double minNumber = array.Min();

            double arithmeticaverage = (array.Max() + array.Min()) / 2;
            Console.WriteLine($" Arithmetic average:{arithmeticaverage}");

            double len1 = 1.0 / 2;
            double geometricaverage = Math.Pow(minNumber * maxNumber, len1);
            Console.WriteLine($"Geometric average: {geometricaverage}");

        }

        static void Task8()
        {
            int[] array1 = new int[14] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] array2 = new int[14] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] resultArray = new int[14];

            for (int i = 0; i < 14; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }

            Console.WriteLine("New array:");
            foreach (int item in resultArray)
            {
                Console.Write(item + " ");
            }
        }

        static void Task9()
        {
            

        }

     


        static void Task10()
        {
            int[] X = { 10, -7, 5, -13, 8, -6 };

            int maxNegativ = FindMaxNegative(X);
        }
        static int FindMaxNegative(int[] arr)
        {
            int maxNegativ = Int32.MinValue;

            foreach (int num in arr)
            {
                if (num < 0 && num > maxNegativ)
                {
                    maxNegativ = num;
                }
            }

            return maxNegativ;
            }


        static void Task11()
        {
            Random rnd = new Random();
            Console.Write("len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[len];
            for (int i = 0; i < 10; i++)
            {
                x[i] = Convert.ToInt32(rnd.Next(0, 100));

                Array.Sort(x);
                Array.Reverse(x);
                Console.WriteLine(x[i]);

            }

           
        }
    }
}


