using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        /*ToDo
        1.Write a C# that calculates the day of week (ex: Monday) of your birthday
        2.Write a C# that calculates you current life days (how many days past since your birth)
        3.Write a C# program to calculate what day of the week is after 40 days from this moment
        4.Write a program in C# to check whether the given year, month and day are the current or not. Test Data :
         Input the Day : 17
         Input the Month : 09
         Input the Year : 2016
         Expected Output :
         The formatted Date is : 17/09/2016 The current date status : True
        5.Write a program in C# to get the day of week from last day of the current year against a given date. Test Data:
         Input the Day : 12
         Input the Month : 12
         Input the Year : 2012
         Expected Output :
         The formatted Date is : 12/12/2012
         The Last day of the year 2012 is : 31/12/2012
        6.Write a program in C# Sharp to find the last day of a week against a given date. Test Data:
         Input the Day : 16
         Input the Month : 06
         Input the Year : 2016
         Expected Output :
         The formatted Date is : 16/06/2016 The last day of the week for the above date is: 18/06/2016
        7.Write a C# Sharp program to find the largest of three numbers. Test Data :
         Input the 1st number :25
         Input the 2nd number :63
         Input the 3rd number :10
         Expected Output :
         The 2nd Number is the greatest among three
        8.Write a program in C# Sharp to read any day number in integer and display day name in the word.
          Test Data : 4 Expected Output : Thursday
        9.Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
          Test Date and Expected Output
          Enter the first Integer :10
          Enter the second Integer :2
           Here are the options :
           1-Addition.
           2-Substraction.
           3-Multiplication.
           4-Division.
           5-Exit.
         Input your choice :3
         The Multiplication of 10 and 2 is: 20*/


        static void Main1(string[] args) //task1
        {
            Console.WriteLine("Please, Write your date of birth: ");
            DateTime dayofweek = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"The day you were born is the day of the week is: '{dayofweek.DayOfWeek}'");

            Console.ReadKey();
        }


        static void Main2(string[] args) //task2
        {
            Console.WriteLine("Please, Write your date of birth: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            DateTime currentdate = DateTime.Now;
            TimeSpan timeRange = currentdate - birthdate;
            Console.WriteLine($"It's been {timeRange.Days} days since you were born.");

            Console.ReadKey();

        }
        

        static void Main3(string[] args) //task3
        {
            DateTime currentdate = DateTime.Now;
            var dayofweek= (currentdate.AddDays(40)).DayOfWeek;
            Console.WriteLine($"It will be a {dayofweek} of the week 40 days after the current date.");
            
            Console.ReadKey();

        }


        static void Main4(string[] args) //task4
        {
            int day, month, year;
            Console.Write("Input the Day: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            year = int.Parse(Console.ReadLine());


            DateTime formatdate = new DateTime(year, month, day);
            var strformatdate = formatdate.ToShortDateString();

            if (day == (DateTime.Now).Day)
            {
                if(month == (DateTime.Now).Month)
                {
                    if(year == (DateTime.Now).Year)
                    {
                        Console.WriteLine($"The formatted Date is: {strformatdate}"); 
                            Console.WriteLine("The current date status: True");
                    }

                }

            }
            else
            {
                Console.WriteLine($"The formatted Date is: {strformatdate}");
                Console.WriteLine("The current date status: False");
            }


            Console.ReadKey();

        }
       

        static void Main5(string[] args) //task5
        {
            int day, month, year;
            Console.Write("Input the Day: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            var onlydate = date.ToString("dd/MM/yyyy");

            Console.WriteLine($"The formatted Date is: {onlydate}");
            Console.WriteLine($"The Last day of the year {year} is: 31/12/{year}");

 
            Console.ReadKey();
}



        static void Main6(string[] args) //task6        //HELP ME, I COULDNT COMPLETE THIS CODE
        {
            int day, month, year;
            Console.Write("Input the Day: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            var onlydate = date.ToString("dd/MM/yyyy");

           

            Console.WriteLine($"The formatted Date is: {onlydate}");
            Console.WriteLine($"The last day of the week for the above date is: {date}");


            Console.ReadKey();


        }
      


        static void Main7_1(string[] args) //task7 1stway
        {
            int[] array = new int[3];
            Console.Write("Input the 1st number: ");
            array[0] = int.Parse(Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            array[1] = int.Parse(Console.ReadLine());
            Console.Write("Input the 3rd number: ");
            array[2] = int.Parse(Console.ReadLine());

            int maxnum = array.Max();
            Console.WriteLine($"The {maxnum} number is the greatest among three.");
            Console.ReadKey();
        
        }

        static void Main7_2(string[] args) //task7 2ndway
        {
            
            Console.Write("Input the 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("The 1st number is the greatest among three.");
            }
            else if(num2>num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd number is the greatest among three.");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among three.");
            }
           
            Console.ReadKey();

        }

        static void Main8(string[] args) //task8
        {
            Console.Write("Write the day of week by integer number: ");
            int dayofweek = int.Parse(Console.ReadLine());

            switch (dayofweek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Write the day of the week correctly!");
                    break;
            }


            Console.ReadKey();

        }

        static void Main9(string[] args) //task9
        {
            Console.Write("Enter the first Integer: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second Integer: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here are the options :");
            Console.WriteLine("1 - Addition.");
            Console.WriteLine("2 - Substraction.");
            Console.WriteLine("3 - Multiplication.");
            Console.WriteLine("4 - Division.");
            Console.WriteLine("5 - Exit.");
            Console.WriteLine();
            Console.Write("Input your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The Addition of {num1} and {num2} is: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"The Substraction of {num1} and {num2} is: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"The Multiplication of {num1} and {num2} is: {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"The Division of {num1} and {num2} is: {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Exit...");
                    break;

            }


            Console.ReadKey();
}


        /*static void Main6(string[] args)
        {
            Console.WriteLine("Enter a day");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a month");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            string formatdate = inputDate.ToString("dd/MM/yyyy");

            DayOfWeek dayOfWeek = inputDate.DayOfWeek;

            Console.WriteLine("Format Date:" + inputDate);

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("The last day of the week for the above date is:");
                    break;
                
                default:
                    Console.WriteLine("Not day of week");
                    break;
            }*/
        /*DateTime myBirtday = new DateTime(1994, 9, 14, 0, 0, 0);
         var myBirtday = new DateTime(1996, 11, 1);
        bool b = formattedDate == formattedNow;
        */

        /*static void Main6(string[] args)
        {
            Console.Write("Enter day number(from 1 to 31): ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter month number(from 1 to 12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter a year(4 digits): ");
            int year = int.Parse(Console.ReadLine());

            DateTime inputtedDate = new DateTime(year, month, day);
            string formattedDate = inputtedDate.ToString("dd/MM/yyyy");

            DayOfWeek dayOfWeek = inputtedDate.DayOfWeek;

            Console.WriteLine("The formatted Date is: " + formattedDate);

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("The last day of the week for the above date is: " + inputtedDate.AddDays(6).ToString("dd/MM/yyyy"));
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("The last day of the week for the above date is: " + inputtedDate.AddDays(5).ToString("dd/MM/yyyy"));
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("The last day of the week for the above date is: " + inputtedDate.AddDays(4).ToString("dd/MM/yyyy"));
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("The last day of the week for the above date is: " + inputtedDate.AddDays(3).ToString("dd/MM/yyyy"));
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the week for the above date is: " + inputtedDate.AddDays(2).ToString("dd/MM/yyyy"));
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("The last day of the week for the above date is: " + inputtedDate.AddDays(1).ToString("dd/MM/yyyy"));
                    break;
                    
                default:
                    Console.WriteLine("Inputted day is the last day of the week.");
                    break;
            }
*/

        /*using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Day : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Input the Month : ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input the Year : ");
            int year = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(year, month, day);

            Console.WriteLine(dateTime.DayOfWeek);

            Console.WriteLine("The formatted date is : {0}.", dateTime.ToString("dd.MM.yyyy"));

            if (dateTime.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(6).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(5).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(4).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(3).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(2).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(1).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(0).ToString("dd.MM.yyyy"));
            }
        }
    }
}*/

        /**/
















    }
}
