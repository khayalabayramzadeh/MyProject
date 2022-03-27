using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {

        /*ToDo

          Enter the value between 10 and 100.Initialize int array with random values with length of user entered value.Do following tasks:
          1.Write a program in C# sort array both descending and ascending order
          2.Write a C# program to find the 3rd max element of array.
          3.Write a program in C# to find first 4 max elements.

         Other tasks - Write seperate method for each task and call them in Main method
          1.Write a program in C# to create a function to swap the values of two integer numbers without additional variable.
          Test Data : Enter a number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5
          2.Write a program in C# to create a function to display the n number Fibonacci sequence. 
          Test Data : Input number of Fibonacci Series : 5 Expected Output : The Fibonacci series of 5 numbers is : 0 1 1 2 3 5 8
          3.Write a program in C# to create a function to calculate the sum of the individual digits of a given number. 
          Test Data : Enter a number: 1234 Expected Output : The sum of the digits of the number 1234 is : 10
          4.Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. 
          Test Data : Please input a string : This is a test string. Expected Output : "This is a test string." contains 4 spaces

        */

        static void Main(string[] args)
        {
            Random random = new Random(); //task1
            Console.Write("Please, Enter the value between 10 and 100 which determines the number of list items:  ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] randomlist = new int[number];

            for (int i = 0; i < number; i++)
            {
                randomlist[i] = random.Next(10, 100);
                Console.WriteLine($"Random List[{i}] = {randomlist[i]}");
            }


            Console.Write("Sort array by ascending order: ");
            Array.Sort(randomlist);
            for (int i = 0; i < randomlist.Length; i++)
            {
                Console.Write($"{randomlist[i]} ");
            }


            Console.Write("\nSort array by descending order: ");
            Array.Reverse(randomlist);
            for (int j = 0; j < randomlist.Length; j++)
            {
                Console.Write($"{randomlist[j]} ");
            }


            Console.WriteLine($"\n3rd max element of array is: {randomlist[2]}");  //task2


            Console.Write("First 4 max elements: "); //task3
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{randomlist[j]} ");
            }


            Console.Write($"\nEnter a number: ");  //task4
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter another number: ");
            int var2 = Convert.ToInt32(Console.ReadLine());
            SwapValuesOfTwoNumbers(var1, var2);


            Console.Write("Input number of Fibonacci Series: ");  //task5
            int num= Convert.ToInt32(Console.ReadLine());
            CreateFibonacciSequence(num);


            Console.Write("\nEnter a number: ");  //task6
            int n = Convert.ToInt32(Console.ReadLine());
            SumOfIndividualDigitsOfNumber(n);


            Console.Write("\nPlease input a string: ");  //task7 1st way
            string str = Console.ReadLine();
            CountNumberOfSpaces(str);


            Console.Write("Input a string : ");  //task7 2nd way    
            string str2 = Console.ReadLine();
            Console.WriteLine("'" + str2 + "'" + " contains " + SpaceCount(str2) + " spaces.");


            Console.ReadKey();
        }


        static void SwapValuesOfTwoNumbers(int var1, int var2)
        {
            /*int var3 = var2;  //with additional variable
            var2 = var1;
            var1 = var3;
            var result = $"Now the 1st number is : {var1} , and the 2nd number is : {var2}";*/

            var result = $"Now the 1st number is : {var2} , and the 2nd number is : {var1}";  //without additional variable

            Console.WriteLine(result);
        }


        static void CreateFibonacciSequence(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;

            if (num < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }

            else
            {
                Console.Write("0 1 ");

                for (int i = 0; i < num - 2; i++)
                {
                    num3 = num1 + num2;
                    num1 = num2;
                    num2 = num3;
                    Console.Write($"{num3} ");
                }
            }
        }


        static void SumOfIndividualDigitsOfNumber(int n)
        {
            var nStr = n.ToString();
            char[] chlist = nStr.ToCharArray();

            int sum = 0,digit;

            for(int i = 0; i < chlist.Length; i++)
            {
                digit = chlist[i]-'0';
                sum += digit;
            }

            Console.WriteLine($"The sum of the digits of the number {n} is: {sum}");
        }


        static void Main6(string[] args)   //task6 without method
        {

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine("The sum of the digits of the number : " + sum);


            Console.ReadKey();
        }


        static void CountNumberOfSpaces(string str)
        {
            char[] charlist= str.ToCharArray();
            int counter = 0;

            for(int i = 0; i < charlist.Length; i++)
            {
                if (charlist[i] == ' ')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        static int SpaceCount(string str)
        {
            int count = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    count++;
            }
            return count;
        }
    }
}

