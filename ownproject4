using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson4
{
    public class Program
    {
        static void Main()
        {
            //Decision Making
            var var1 = Console.ReadLine();

            if (var1 == "5")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else if (var1 == "6")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else if (var1 == "7")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else if (var1 == "8")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else
            {
                Console.WriteLine("Other number");
            }

            //switch
            switch (var1)
            {
                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("Number is {0}", var1);
                    break;
                default:
                    Console.WriteLine("Other number");
                    break;
            }

            //short circuiting ?:

            var var2 = int.Parse(Console.ReadLine());

            string result;

            result = var2 >= 5 ? "true" : "false";

            if (var2 >= 5)
            {
                result = "true";
            }
            else
            {
                result = "false";
            }

            Console.WriteLine(result);



            Console.WriteLine("Program ended");
            Console.ReadLine();
        }


        static void Main2()
        {
            //arrays [1,2,3,6,7,8,9]

            int[] array1 = new int[3];
            array1[0] = 20;
            array1[1] = 11;
            array1[2] = 23;

            int sum = array1[0] + array1[1] + array1[2];

            int sum1 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            Console.WriteLine($"Sum is: {sum}.");
            Console.WriteLine($"Sum1 is: {sum1}.");


            int[] array2 = new int[5];
            var random = new Random();
            Console.WriteLine("Array elements:");

            int sum2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 100);
                Console.WriteLine(array2[i]);
                sum2 += array2[i];
            }
            Console.WriteLine($"Sum2 is: {sum2}.");

            var max_element = array2.Max();
            Console.WriteLine($"Maximum element of array2 is {max_element}.");


            //2 dimensional arrays
            int[,] dim2Array = new int[2, 3];
            dim2Array[0, 0] = 5;
            dim2Array[0, 1] = 6;
            dim2Array[0, 2] = 7;
            dim2Array[1, 0] = 8;
            dim2Array[1, 1] = 9;
            dim2Array[1, 2] = 10;

            Console.WriteLine(dim2Array.Length);
            Console.WriteLine(dim2Array.Rank);
            Console.WriteLine(dim2Array.GetLength(0));
            Console.WriteLine(dim2Array.GetLength(1));

            var sum2DimArray = 0;

            for (int i = 0; i < dim2Array.GetLength(0); i++)
            {
                for (int j = 0; j < dim2Array.GetLength(1); j++)
                {
                    sum2DimArray += dim2Array[i, j];
                }
            }

            Console.WriteLine(sum2DimArray);


            //3dim array
            int[,,] dim3Array1 = new int[2, 3, 4];

            Console.ReadKey();

        }



        static void Main3(string[] args)
        {
            const double pi = 3.14;

            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            Console.WriteLine(date1.ToString("dd.MM.yyyy hh:mm:ss"));
            Console.WriteLine(date1.Date.ToString("dd.MM.yyyy"));
            Console.WriteLine(date1.DayOfWeek);
            Console.WriteLine((int)date1.DayOfWeek);
            Console.WriteLine(date1.Kind);
            Console.WriteLine(date1.TimeOfDay);
            Console.WriteLine(date1.AddDays(2));
            Console.WriteLine(date1.Add(TimeSpan.Parse("20:50:08")));
            Console.WriteLine(TimeSpan.FromDays(3));
            Console.WriteLine(date1.Add(TimeSpan.Parse("4.20:50:08")));
            Console.WriteLine(date1.Subtract(TimeSpan.Parse("20:50:08")));
            Console.WriteLine(date1.ToLongDateString());
            Console.WriteLine(date1.ToShortDateString());
            
            DateTime date2 = DateTime.UtcNow;
            Console.WriteLine(date2.Kind);
            
            var date3 = DateTime.Parse("05.11.2020 08:30:00");
            TimeSpan TimeRange = date1 - date3;
            Console.WriteLine(TimeRange);

            var stringResult = $"TimeRange is {TimeRange}, year is {TimeRange.Days / 365}, days is {TimeRange.Days}";
            var stringResult2 = string.Format("TimeRange is {0}, year is {1}, days is {2}", TimeRange, TimeRange.Days / 365, TimeRange.Days);
            Console.WriteLine("TimeRange is {0}, year is {1}, days is {2}", TimeRange, TimeRange.Days / 365, TimeRange.Days);

            Console.WriteLine(stringResult);
            Console.WriteLine(stringResult2);

            Console.ReadKey();
            
        }

        static void Main4(string[] args)
        {
            Console.Write("Please,Enter the day of week: ");
            var DayType = (DaysOfWeek)int.Parse(Console.ReadLine());

            if (DayType == DaysOfWeek.Saturday || DayType == DaysOfWeek.Sunday)
            {
                Console.WriteLine("Have a nice weekend...");
            }
            else
            {
                Console.WriteLine("Good Days!!!");
            }

            Console.ReadKey();
        }

            public enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday,
            Sunday
        }
    






    }
}
