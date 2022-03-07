using System;

namespace task1
{
    internal class Program
    {
        /*ToDo
           1.Write a C# program that takes three letters as input and display them in reverse order.
           2.Write a C# program that takes 2 inputs form user respectively name and surname, and then print it as "NAME SURNAME" (both uppercase) in console
           3.Write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle and print it in console
           */

        static void Main1(string[] args) //2nd task
        {

            Console.Write("Please,Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please,Enter your surname: ");
            string surname = Console.ReadLine();
            var fullname = name + " " + surname;
            Console.WriteLine("Your fullname is " + fullname.ToUpper() + ".");

            Console.ReadLine();
        }


        static void Main2(string[] args) //3rd task
        {
            double radius, perimeter, area;
            Console.Write("Please,Enter the radius of circle: ");
            radius = Convert.ToDouble(Console.ReadLine());   //radius = double.Parse(Console.ReadLine());
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
            Console.WriteLine("Perimeter of the circle is " + perimeter);
            Console.WriteLine("Area of the circle is " + area);

            Console.ReadLine();
        }


        static void Main3(string[] args) //1st task 1st way
        {

            string word, reverse = "";
            Console.Write("Write a word: ");
            word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)

            {
                reverse += word[i];
            }
            Console.WriteLine(reverse);

            Console.ReadKey();
        }


        static void Main4(string[] args) //1st task 2nd way
        {


            Console.Write("Enter 1st letter: ");
            string fl = Console.ReadLine();
            Console.Write("Enter 2nd letter: ");
            string sl = Console.ReadLine();
            Console.Write("Enter 3rd letter: ");
            string tl = Console.ReadLine();

            var reverse = tl + sl + fl;
            Console.WriteLine(reverse);

            Console.ReadKey();
        }











        }
}
