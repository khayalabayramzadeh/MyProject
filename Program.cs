using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    internal class Program
    {



        //static void Main_quiz(string[] args)     //HARD
        //{
        //    int i;
        //    int j = 1;
        //    int[] ar = { 21, 22, 13, 4 };

        //    switch (ar[j])
        //    {
        //        case 1:
        //            i++;
        //            break;
        //        case 2:
        //            i += 2;
        //            j = 3;
        //            //continue;
        //        case 3:
        //            i %= 2;
        //            j = 4;
        //            //continue;
        //        default:
        //            --i;
        //    }

        //    Console.WriteLine(i);
        //    Console.ReadLine();


        //}


        static void Main_operators()
        {
            //Arithmetic Operators  +  -  *  /	%  ++  --
            //Assignment Operators  =  +=  -=  *=  /=  %=  &=  |=  ^=  >>=  <<=
            //Comparison Operators  ==  >  <  >=  <=  !=
            //Logical Operators  &&  ||  !

            int a = 5;
            a &= 4;  //AND
            Console.WriteLine(a);                   

            int b = 5;
            b |= 4;  //OR
            Console.WriteLine(b);

            int c = 5;          
            c ^= 4;  //XOR
            Console.WriteLine(c);

            int d = 5;   //00000000        0 0 0 0 0 1 0 1
            d >>= 4;  
            Console.WriteLine(d);

            int e = 5;   //01010000
            e <<= 4;   
            Console.WriteLine(e);

            Console.ReadKey();


        }

        static void Main1(string[] args)
        {
            //Arithmetic Operators  +  -  *  /	%  ++  --
            //Assignment Operators  =  +=  -=  *=  /=  %=  &=  |=  ^=  >>=  <<=
            //Comparison Operators  ==  >  <  >=  <=  !=
            //Logical Operators  &&  ||  !


            Console.WriteLine("Arithmetic Operators  + - * / %  ++  --");

            Console.Write("\nPlease, Enter 1st integer number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, Enter 2nd integer number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n         Options:");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulus\n6.Increment\n7.Decrement");
            Console.Write("\nSelect the number of one of these operations: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
                case 5:
                    Console.WriteLine(num1 % num2);
                    break;
                case 6:
                    Console.WriteLine($"Increment of 1st number is {++num1}");
                    break;
                case 7:
                    Console.WriteLine($"Decrement of 2nd number is {--num2}");
                    break;
                default:
                    Console.WriteLine("Not the right choice!!!");
                    break;

            }




            Console.WriteLine("\nComparison Operators  ==  >  <  >=  <=  !=");

            Console.Write("\nPlease, Enter 1st integer number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, Enter 2nd integer number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("1st number is greater than 2nd number.");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("1st number is smaller than 2nd number.");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("1st number is equal 2nd number.");
            }
            else
            {
                Console.WriteLine("1st number is not equal 2nd number.");
            }



            
            Console.WriteLine("\nAssignment Operators  =  +=  -=  *=  /=  %=  &=  |=  ^=  >>=  <<=");

            int n3 = 2, n4 = 4;
            n3 += n4;
            n4 -= n3;
            n3 *= n4;
            n4 /= n3;
            n3 %= n4;
            n4 &= n3;
            n3 |= n4;
            n4 ^= n3;
            n3 >>= n4;
            n4 <<= n3;

            Console.WriteLine(n3);
            Console.WriteLine(n4);



            Console.ReadKey();




        }

        static void Main2(string[] args)
        {
            Console.Write("Enter 1st number: ");
            double fnum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            double snum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            double tnum = Convert.ToDouble(Console.ReadLine());


            double[] arr = { fnum, snum, tnum };
            var maxnum = arr[0];
            var minnum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxnum)
                {
                    maxnum = arr[i];
                }
                if (arr[i] < minnum)
                {
                    minnum = arr[i];
                }
            }

                Console.WriteLine($"Max number of them is {maxnum}.");
                Console.WriteLine($"Min number of them is {minnum}.");

                Console.ReadKey();
            
        }

        static void Main3(string[] args)
        {
            
            Console.WriteLine("Result of the function:  y = x2 - 4x + 1 \n");

            for(int i = -5; i <= +5; i++)
            {
                Console.WriteLine($"x = {i}   y = {i*i - 4*i + 1}");
            }

            Console.ReadKey();
        }


        static void Main4(string[] args) 
        {

            int x = 7;
            switch (x)
            {
                case 21:
                    Console.WriteLine("x = 21");
                    break;
                case int i when (i>21):
                    Console.WriteLine("x > 21");
                    break;
                case int i when (i < 21):
                    Console.WriteLine("x < 21");
                    break;
                default:
                    Console.WriteLine("Exit..");
                    break;
          
            }

            Console.ReadLine();







        }

        static void Main5(string[] args)
        {
      
            for(int i = 2; i <= 7; i++)
            {
                Console.WriteLine("i value:"+ i);
            }

            Console.WriteLine("Exit..");
            Console.ReadLine();
        }

        static void Main4_1(string[] args)
        {
            int x = 5;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x value equals to 10");
                    break;
                case int i when (i > 10):
                    Console.WriteLine("x value greater than 10");
                    break;
                case int i when (i < 10):
                    Console.WriteLine("x value less than 10");
                    break;
                default:
                    Console.WriteLine("Press Enter Key to Exit..");
                    break;

            }

            Console.ReadLine();
        }

        static void Main5_1(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value:" + i);
            }

            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        static void Main6(string[] args)
        {
            int number = 10;

            number += 5;
            Console.WriteLine(number);
            number -= 5;
            Console.WriteLine(number);
            number *= 5;
            Console.WriteLine(number);
            number /= 5;
            Console.WriteLine(number);
            number %= 5;
            Console.WriteLine(number);
            number &= 5;
            Console.WriteLine(number);
            number |= 5;
            Console.WriteLine(number);
            number ^= 5;
            Console.WriteLine(number);
            number <<= 5;
            Console.WriteLine(number);
            number >>= 5;
            Console.WriteLine(number);


            Console.ReadKey();
        }

        static void Main3_1(string[] args)
        {
            Console.WriteLine("Result of the function:  y = x2 - 3x + 11 \n");

            for (int i = -7; i <= +7; i++)
            {
                Console.WriteLine($"x = {i}   y = {i * i - 3 * i + 11}");
            }

            Console.ReadKey();
        }

        static void Main7(string[] args)
        {
            int a, b;
            char operation;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation: ");
            operation= Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }
            else if (operation == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }
            else if (operation == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
            else if (operation == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            else
            {
                Console.WriteLine("Wrong Character");
            }

            Console.ReadKey();
        }

    }


}
