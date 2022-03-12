using System;
using System.Collections;
using System.IO;

namespace Lesson5
{
    class Program1
    {
        static void Main4()
        {
            Program2.DoSomething();

            ArrayList list = Program1.CreateAndInitializeArrayList(100, "Hi everyone", DateTime.Now);  
            //CreateAndInitializeArrayList(100, "Hi everyone", DateTime.Now);
            PrintArrayList(list);



            int[] myArray = { 1, 5, 7, 9, 10 };

            int sumWithFor = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sumWithFor += myArray[i];
            }
            Console.WriteLine($"Sum with for operator is: {sumWithFor}");


            int sumWithForeach = 0;
            foreach (var i in myArray)  //it's for collections like arrays,lists
            {
                sumWithForeach += i;
            }
            Console.WriteLine($"Sum with foreach operator is: {sumWithForeach}");

            Console.ReadKey();
        }

       


        static void Main1(string[] args)  
        {
            //for loop

            for (int i = 1; i <= 100; i++)  //dovrlerin sayi evvelceden melum olur
            {

                if (i % 10 == 0)
                {
                    continue;
                }

                if (i > 70)
                {
                    break;
                }

                Console.WriteLine(i);
            }


            for (int i = 10; i > 0; i-=2)
            {
                Console.WriteLine(i);
            }
            
            
            Console.ReadKey();
        }


        static void Main2()
        {
            //while loop

            while (true)
            {
                Console.WriteLine("Do you want to continue?  Yes/No");
                string userAnswer = Console.ReadLine();
                bool isContinue = userAnswer.ToLower() == "yes";

                if (isContinue)
                {
                    Console.WriteLine("You want to continue.");
                    continue;
                }
                else
                {
                    Console.WriteLine("You choose to exit.");
                    break;
                }
            }


            int i = 1;        //initialization
            while (i <= 100)  //condition
            {
                Console.WriteLine(i);
                i++;          //iterator
            }

            Console.ReadLine();
        }
        
        
        
        static void Main3()
        {
            // do while loop

            bool isContinue;
            do
            {
                Console.WriteLine("Do you want to continue ? Yes/No");
                string userAnswer = Console.ReadLine();
                isContinue = userAnswer.ToLower() == "yes";

                Console.WriteLine(isContinue ? "you want to continue" : "you choose to exit");
            }
            while (isContinue);


            Console.ReadKey();
        }


        static ArrayList CreateAndInitializeArrayList(int itemCount, string text, DateTime date)
        {
            ArrayList list = new ArrayList();          //int var1 = Convert.ToInt32(list1[0]);

            for (int i = 10; i <= itemCount; i += 10)
            {
                list.Add(i);
            }


            list.Add(text);
            list.Add(date);



            return list;
        }

        static void PrintArrayList(ArrayList list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            return;

            int a = 5;
        }
    }
}