using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {

        /*ToDo
          1.Write a program in C# to display the first 10 natural numbers

          2.Write a C# program to find the sum of first 20 odd natural numbers.

          3.Write a program in C# to read 5 numbers from keyboard and find their sum and average.

          4.Write a program in C# to display the multiplication table vertically from 1 to n.
           Test Data:
           Input upto the table number starting from 1 : 8
           Expected Output:
           Multiplication table from 1 to 8
           1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
           ...
           1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80

          5.Write a program in C# to display the pattern like right angle triangle using an asterisk. The pattern like :

           *
           **
           ***
           ****
           *****

          6.Write a program in C# to make such a pattern like right angle triangle with number increased by 1. The pattern like :
           1
           2 3
           4 5 6
           7 8 9 10

          7.Write a program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. Test Data :
            Input the number or terms :5
            Expected Output :
            9 99 999 9999 99999
            The sum of the series = 111105

          8.Write a C# program to find prime numbers up to users entered value.
            Exmpl: input-100, Result: 2, 3, 5, 7, 11, 13 ... 89, 97

          9.Write a program in C# to check whether a number can be express as sum of two prime numbers.
            Test Data :
            Input a positive integer: 16
            Expected Output :
            16 = 3 + 13
            16 = 5 + 11

          10.Write a program in C# to check whether a number is a palindrome (visual simmetric) or not. Test Data :
           Input a number: 121
           Expected Output :
           121 is a palindrome number.*/

        static void Main1(string[] args) //task1
        {
            Console.WriteLine("The first 10 natural numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }


        static void Main2_1(string[] args)  //task2
        {
            int sumOfoddnum = 0;

            for (int i = 1; i <= 20; i++)
            {
                sumOfoddnum += 2 * i - 1;
            }

            Console.WriteLine($"The sum of first 20 odd natural numbers is: {sumOfoddnum}");

            Console.ReadKey();

        }

        static void Main2_2(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Display the sum of n odd natural number:\n");
            Console.Write("Input number of terms: ");

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are: ");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"The Sum of odd Natural Number upto {n} terms: {sum}");
            Console.ReadKey();
        }


        static void Main3_1(string[] args)  //task3
        {
            int[] myarray = new int[5];
            Console.WriteLine("Enter 1st int number: ");
            myarray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd int number: ");
            myarray[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd int number: ");
            myarray[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 4th int number: ");
            myarray[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 5th int number: ");
            myarray[4] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= myarray.Length; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of entered 5 numbers is: {sum}");
            Console.WriteLine($"Average of entered 5 numbers is: {sum / 5.0}");

            Console.ReadKey();

        }

        static void Main3_2(string[] args)
        {

            int i, num, sum = 0;
            double avg;

            Console.WriteLine("Input the 5 numbers: ");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Number-{0}:", i);

                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            avg = sum / 5.0;
            Console.Write("The sum of 5 number is: {0}\nThe Average is: {1}\n", sum, avg);
            Console.ReadKey();
        }



        static void Main4(string[] args) //task4
        {
            Console.Write("Input upto the table number starting from 1 :  ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table from 1 to {num}:");

            for (int j = 1; j <= num; j++)
            {
                Console.WriteLine($"Multiplication table of {j}:");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{j}x{i} = {i * j}");
                }

            }

            Console.ReadKey();

        }

        static void Main5_1(string[] args)  //task5
        {
            string asterisk1 = "*";
            string asterisk2 = "*";

            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine(asterisk1);
                asterisk1 = asterisk2 + asterisk1;

            }

            Console.ReadKey();

        }

        static void Main5_2(string[] args)  //task5
        {

            Console.WriteLine("Display the pattern like right angle using asterisk:");
            Console.Write("Input number : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)

                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Main6(string[] args)  //task6
        {
            Console.Write("Display the pattern like right angle triangle with number increased by 1:\n");
            Console.Write("Input number : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int num = 1;

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{num++} ");
                }

                Console.Write("\n");
                //Console.WriteLine();

            }

            Console.ReadKey();
        }



        static void Main7(string[] args)  //task7
        {
            Console.Write("Display the sum of the series [ 9 + 99 + 999 + 9999 ...]:\n");
            Console.Write("Input the number or terms:  ");
            int terms = Convert.ToInt32(Console.ReadLine());

            int firstnum = 9;
            int sum = 0;

            for (int i = 1; i <= terms; i++)
            {
                Console.Write($"{firstnum}  ");
                sum += firstnum;
                firstnum = firstnum * 10 + 9;
            }

            Console.WriteLine($"\nThe sum of number series is: {sum}");

            Console.ReadKey();
        }



        static void Main8(string[] args)  //task8           //Very hard
        {
            Console.Write("Please Enter any number to find simple numbers up to this number:  ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            Console.WriteLine("These are prime numbers : ");

            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {
                    if ((i != j) && (i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write($"{i} ");
                }

                isPrime = true;
            }

            Console.ReadKey();

        }


        static void Main9(string[] args)  //task9   //very hard
        {
            int var1 = 1, var2 = 1, var3 = 0;

            Console.Write("Enter any number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i <= n / 2; i++)
            {
                var1 = 1;
                var2 = 1;

                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        var1 = 0;
                        j = i;
                    }
                }

                for (int j = 2; j < n - i; j++)
                {
                    if ((n - i) % j == 0)
                    {
                        var2 = 0;
                        j = n - i;
                    }
                }

                if ((var1 == 1) && (var2 == 1))
                {
                    Console.WriteLine($"{n} = {i} + {n - i}");
                    var3 = 1;
                }
            }

            if (var3 == 0)
            {
                Console.Write($"{n} can't be expressed as sum of two prime numbers.");
            }

            Console.ReadKey();
        }




        static void Main10_1(string[] args)  //task10
        {
            Console.Write("Enter any number : ");
            int n = int.Parse(Console.ReadLine());
            string numN = Convert.ToString(n);

            char[] cArray = numN.ToCharArray();
            string reverse = "";

            for (int i = cArray.Length - 1; i >=0; i--)
            {
                reverse += cArray[i];
            }

            if (numN == reverse)
            {
                Console.WriteLine($"{numN} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{numN} is NOT a palindrome number.");
            }

            Console.ReadKey();
        }



        static void Main10_2(string[] args)  //task10
        {
            int i, var1, sum = 0;

            Console.Write("Enter any number : ");
            int number = int.Parse(Console.ReadLine());

            for (i = number; number != 0; number /= 10)
            {
                var1 = number % 10;
                sum = sum * 10 + var1;
            }

            if (i == sum)
            {
                Console.Write("{0} is a palindrome number.", i);
            }
            else
            {
                Console.Write("{0} is not a palindrome number.", i);
            }

            Console.ReadKey();
        }


        static void Main10_3(string[] args)  //task10
        {
            int number = 0;
            int nNumber = 0;
            int var = 0;
            int var1 = 0;


            Console.Write("Enter Number : ");
            nNumber = number = int.Parse(Console.ReadLine());


            while (number > 0)
            {
                var = number % 10;
                var1 = var1 * 10 + var;
                number = number / 10;

            }


            if (var1 == nNumber)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is not a Palindrome");

            Console.ReadKey();
        }

       
       





    


















  }
}
