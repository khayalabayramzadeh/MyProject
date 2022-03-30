using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS
            //Single-dimensional arrays
            int[] arr_1 = new int[5] { 2, 5, 8, 7, 2 };  //1st Way

            int[] arr_2 = new int[] { 2, 5, 8, 7, 2 };   //2nd Way

            int[] arr_3 = { 2, 5, 8, 7, 2 };             //3rd Way

            int[] arr_4 = new int[5];                    //4th Way
            arr_4[0] = 2;
            arr_4[1] = 5;
            arr_4[2] = 8;
            arr_4[3] = 7;
            arr_4[4] = 2;


            int[] copied_numbers = arr_1;   //copy

            string[] fruits = { "apple", "orange", "mango", "banana" };
            fruits[2] = "pear";             //modify


            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits.Length);


            //Multidimensional arrays
            int[,] arr_5 = new int[3, 3];
            arr_5[0, 0] = 1;
            arr_5[0, 1] = 2;
            arr_5[0, 2] = 3;
            arr_5[1, 0] = 4;
            arr_5[1, 1] = 5;
            arr_5[1, 2] = 6;
            arr_5[2, 0] = 7;
            arr_5[2, 1] = 8;
            arr_5[2, 2] = 9;


            int[,] arr_6 = new int[,] {{ 1, 2, 3 },
                                       { 4, 5, 6 },
                                       { 7, 8, 9 } };


            int[,] arr_7 = new int[3, 3] {{ 1, 2, 3 },
                                         { 4, 5, 6 },
                                         { 7, 8, 9 } };


            int[,] arr_8 = {{ 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };


            int sum = 0;
            for (int i = 0; i < arr_8.GetLength(0); i++)
            {
                for (int j = 0; j < arr_8.GetLength(1); j++)
                {
                    sum += arr_8[i, j];

                }
            }
            Console.WriteLine(sum);



            int[,,] arr_9 = new int[7, 8, 3];
            arr_9[1, 2, 3] = 17;


            //Jagged arrays
            int[][] arr_10 = new int[4][];
            arr_10[0] = new int[2] {0,1};
            arr_10[1] = new int[4] {2,3,4,5};
            arr_10[2] = new int[8] {6,7,8,9,10,11,12,13};
            arr_10[3] = new int[10] {14,15,16,17,18,19,20,21,22,23};



            int x_1 = 10;
            x_1 = 17;
            Console.WriteLine(x_1);

            const int y = 45;
            //y = 48;  //ERROR
            Console.WriteLine(y);


            // TYPE CASTING
            // Implicit casting < to > and explicit casting > to <
            // char>int>long>float>double - implicit casting
            // double>float>long>int>char - explicit casting

            int x2 = 8;
            double myDouble = x2;
            Console.WriteLine(x2);
            Console.WriteLine(myDouble);

            double newDouble = 8.21;
            int b = (int)newDouble;
            Console.WriteLine(newDouble);
            Console.WriteLine(b);


            int newInt = 10;
            double newDouble2 = 4.2;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(newInt));
            Console.WriteLine(Convert.ToDouble(newInt));
            Console.WriteLine(Convert.ToInt32(newDouble2));
            Console.WriteLine(Convert.ToString(myBool));


            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Username is {username}.");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            
            Console.WriteLine(Math.Truncate(897.56));
            Console.WriteLine(Math.Round(-897.56));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Abs(-81));
            Console.WriteLine(Math.Cos(90));
            Console.WriteLine(Math.Max(90,103));

            var myStr = "Khayala Bayramzadeh";
            Console.WriteLine(myStr[0]);
            Console.WriteLine(myStr.IndexOf("a"));
            string lastName = myStr.Substring(8);
            Console.WriteLine(myStr.Length);
            Console.WriteLine(myStr.ToCharArray());
            Console.WriteLine(myStr.ToLower());

            string txt1 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt1);
            string txt2 = "It\'s alright.";
            Console.WriteLine(txt2);
            string txt3 = "The character \\ is called backslash.";
            Console.WriteLine(txt3);
            string txt4 = "Hello\nWorld!";
            Console.WriteLine(txt4);
            string txt5 = "Hello\tWorld!";
            Console.WriteLine(txt5);
            string txt = "Hello Wor\bld!";
            Console.WriteLine(txt);


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }





            Console.ReadKey();
        }
    }
}
