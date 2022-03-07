using System;

namespace task2
{
    internal class Program
    {

            /*ToDo
            1.Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd
            2.Write a C# program which takes 2 string input from user and return if second string is in first string. 
            Example. 1st input: Azərbaycan, 2nd input: can, Result should be true because can is in Azərbaycan
            3.Get 2 int number input from user and calculate the exact input1 / input2.Example: 16, 5.Result should be 3.2 not 3.
            */

        static void Main1(string[] args)  //3rd task
        {
            float num1, num2, result;
            Console.Write("Enter 1st int number: ");
            num1 =int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd int number: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 / num2;
            Console.WriteLine("Answer of the division is " + result);
            Console.ReadKey();
        }

        static void Main2(string[] args) //2nd task 1st way
        {
            string input1, input2;
            Console.Write("Write 1st word: ");
            input1 = Console.ReadLine();
            Console.Write("Write 2nd word: ");
            input2 = Console.ReadLine();
            if (input1.Contains(input2))
            {
                Console.WriteLine(input2 + " is in " + input1 + ".");
            }
            else
            {
                Console.WriteLine(input2 + " is not in " + input1 + ".");
            }

            Console.ReadKey();
        }


        static void Main3(string[] args) //2nd task 2nd way
        {

            Console.Write("birinci sozu yaz:");
            string var1 = Console.ReadLine();

            Console.WriteLine("ikinci sozu yaz:");
            string var2 = Console.ReadLine();

            Console.WriteLine(var1.Contains(var2));
            Console.ReadLine();

        }


        static void Main4(string[] args) //1st task 
        {
            int num1, num2;
            Console.Write("Input 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            num2 = int.Parse(Console.ReadLine());

            bool check = ((num1 % 2 == 0) && (num2 % 2 == 0)) || ((num1 % 2 != 0) && (num2 % 2 != 0));
            Console.WriteLine(check);
            Console.ReadKey();

        }


        }
}
