using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main1(string[] args)
        {
            /*Console.Write("Please, Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            string grp;*/

            switch (id)
            {
                case 6:
                    grp = "Grp B";
                    break;
                case 13:
                    grp = "Grp D";
                    break;
                case 1:
                    grp = "Grp A";
                    break;
                case Is>20: //error, Dont use >,<
                    grp = "Grp E";
                    break;
                case Else:  //error, Have to use "default: "
                    grp = "Grp F";
                    break;
            }

            /*Console.WriteLine($"Your id is {id} and that's why {grp} .");
            Console.ReadKey();*/
        }


        static void Main_1(string[] args)
        {
            Console.Write("Please, Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            string grp;

            switch (id)
            {
                case 6:
                    grp = "Grp B";
                    break;
                case 13:
                    grp = "Grp D";
                    break;
                case 1:
                    grp = "Grp A";
                    break;
                case 20:
                    grp = "Grp E";
                    break;
                default:
                    grp = "Grp F";
                    break;
            }

            Console.WriteLine($"Your id is {id} and that's why {grp} .");
            Console.ReadKey(); 
        }

        static void Main2(string[] args)
        {
            int a = 4;
            int b = 5;
            int c = 6;
            int d = 8;
            //int a=4,b=5,c=6,d=8;

            if (((a * b / c) + d) >= ((b * c + d) / a))
            {
                Console.WriteLine("Line 1- a is greater to b");
                Console.WriteLine((a * b / c) + d);
            }
            else
            {
                Console.WriteLine("Line 1- a is not greater to b");
                Console.WriteLine((b * c + d) / a);

            }

            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            int a, b, c, x;
            a = 90;
            b = 15;
            c = 3;
            x = a - b / 3 + c * 2 - 1;

            Console.WriteLine(x);
            Console.ReadLine();
        }

        static void Main4(string[] args)
        {
            int a, b;
            int c = 10;
            int d = 12;
            int e = 5;
            int f = 6;
            a = c * (d + e) / f + d;
            Console.WriteLine(a);
            b = c * (d + e / f + d);
            Console.WriteLine(b);

            if (a < b)
            {
                Console.WriteLine("parantheses changes values");
            }
            else if (a > b)
            {
                Console.WriteLine("They have same value");
            }

            Console.ReadLine();
        }

        static void Main5(string[] args)
        {
            int a = 56, b = 87.6; //error
            int a = 52; b = 45;   //error
            int a = 6; int b = 85;
            int a = b = 54;      //error
        }

        static void Main6(string[] args)     //HARD
        {
            int i;
            int j = 1;
            int[] ar = { 21, 22, 13, 4 };

            switch (ar[j])
            {
                case 1:
                    i++;
                    break;
                case 2:
                    i+=2;
                    j = 3;
                    continue;
                case 3:
                    i %= 2;
                    j = 4;
                    continue;
                default:
                    --i;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }      

        static void Main7(string[] args)
        {
        /*  Which of the following is correct about variable naming conventions in C#?
            A - A name must begin with a letter that could be followed by a sequence of letters, digits (0 - 9) or underscore.
            B - The first character in an identifier cannot be a digit.
            C - Both of the above.
            D - None of the above.
            Answer: Both of the above.*/
        }
    
        static void Main8(string[] args)    
        {
            int i, j, id = 0;
            switch (id)
            {
                case i:
                    Console.WriteLine("I am in Case i");
                    break;
                case j:
                    Console.WriteLine("I am in Case j");
                    break;

            }
        }      
         
        static void Main9(string[] args)
        {
            int n = 2;
            int p = 4;
            int q = 5;
            int w = 3;

            if (!((p * q) / n <= (q * w) + n / p))
            {
                Console.WriteLine(++p + w++ + " " + ++n);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(--p + q-- + " " + --n);
                Console.WriteLine(a);
            }

        }

        static void Main10(string[] args)
        {
            int a, b, c, x;
            a = 80;
            b = 15;
            c = 2;
            x = a-b/(3*c)*(a+c);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static void Main11(string[] args)
        {
            ++x++; //error
            x++1;  //error
            x += 1; //x++; ++x;
            x = +1;  //error

        }

        static void Main12(string[] args)
        {
         /*   Default Type of number without decimal is ?
               a.Long Int
               b.Unsigned Long
               c.Int
               d.Unsigned Int
               Answer: Int     */

        }

        static void Main13(string[] args)
        {
            int i = 9, j = 7;
            switch (i - j + 3)
            {
                case 9: 7:   //error, have to use only one value like this case 9: or case 7:
                    j += 6;
                    break;
                case 5:
                    i -= 4;
                    break;
            }
            Console.WriteLine(i + "\n" + j);
            Console.ReadLine();
        }

        static void Main14(string[] args)
        {
            /*    Which of following statements about objects in “C#” is correct?
                   a.Everything you use in C# is an object, including Windows Forms and controls
                   b.Objects have methods and events that allow them to perform actions
                   c.All objects created from a class will occupy equal number of bytes in memory
                   d.All of the above
                   e.None of the mentioned 
                   Answer:  All of the above              */
        }

        static void Main15(string[] args)
        {
            int a = 5, b = 6, c = 9, u = 10;
            int h;
            h = (Convert.ToInt32(u < b)) + (a + b--) + 2;
            Console.WriteLine(h);
            Console.WriteLine(b);
            Console.WriteLine(u<b);

        }

        static void Main16(string[] args)
        {
            int i;
            int b = 8, a = 32;
            for (i = 0; i <= 10; i++)
            {
                if ((a / b * 2) == 2)
                {
                    Console.WriteLine(i + " ");
                    continue;
                }
                else if (i != 4)
                    Console.WriteLine(i + " ");
                else
                    break;
                Console.ReadLine();
            }

        }

        static void Main17(string[] args)   //strange
        { 
            for(int i=0, b=1; i+b<10; i++, b++)
            {
                Console.WriteLine(i+b);
                
            }

            Console.ReadKey();
        }


        //https://www.tutorialspoint.com/csharp/csharp_mock_test.htm#:~:text=Q%204%20%2D%20Which%20of%20the,0%20%2D%209)%20or%20underscore
        //https://compsciedu.com/c-sharp-programming/Classes-and-Objects/discussion/33087
        //https://compsciedu.com/c-sharp-programming/Data-Types_Variables-and-Operators/discussion/32922

    
    }
}

