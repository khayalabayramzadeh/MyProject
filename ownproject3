using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //Operators 
                //Arithmetic Operators  +, -, *, /, %, ++, --
                int a = 19;
                int b = 6;
                int c = 8;
                int d = 9;
                Console.WriteLine(a + b);
                Console.WriteLine(a - b);
                Console.WriteLine(a * b);
                Console.WriteLine(a / b);
                Console.WriteLine(a % b);
                Console.WriteLine(a++); //Firstly, the past value of a is print, then return increased value.That is, 19.
                Console.WriteLine(a);  // 20
                Console.WriteLine(b--);  // 6
                Console.WriteLine(b);  //5

                Console.WriteLine(++c); //9
                Console.WriteLine(--d); //8


                //Logical Operators  &&, ||, !

                bool andresult = (4 < 9) && (a == b);
                bool orresult = (4 < 9) || (a == b);
                bool notResult1 = !(a > 6);
                bool notResult2 = a <= 6;

                //Relational Operators  ==, !=, >, <, >=, <=

                var eqlresult = 6 == 7;
                var noteqlresult = 100 != int.Parse(Console.ReadLine());

                //Assignment Operators  =,  +=, -= and etc.

                int var4;
                var4 = a;
                var4 += 5; //var4 = var4 + 5;
                var4 -= 10;
            
        

                //Miscellaneous Operators – Ex: sizeof(), typeof(), ?:, is, as and *, &

                var size = sizeof(int);
                int value1 = 19;
                var check = value1.GetType() == typeof(int);

                bool result = value1 is int; // a int -dirmi ? cavab true ve ya false ola biler
                long value2 = 15;
                int? value3 = value2 as int?; // as cevirme yerine yetirir


                //value1 = null; // bu kod ona gore xeta verir ki, value tiplere null deyeri vere bilmirik.
                int? y = null; // nullable int tipi, sadece int sozunun yanina ? isaresi qoyulur, int-den yegane ferqi elave olaraq null deyeri ala bilmesidir.

                if (y.HasValue) // y-in deyeri varmi ?
                {
                    int z = y.Value; // eger varsa y-in deyerini goturub adi not nullable int z deyishenine menimsedirik.
                }

                Type x = null; // reference tipdir ve null deyeri ala bilir.

               

            }
        


        static void Main1(string[] args)
        {

            int var1 = int.Parse("43645");
            int var2 = int.Parse(Console.ReadLine());
            var isItOK = int.TryParse(Console.ReadLine(), out int result);

            if (isItOK)
            {
                var sum = 282 + result;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Enter integer number");
            }

            
            var var3 = Convert.ToBoolean(1);

            float var6 = 43534.67F;
            var stringResult = var6.ToString();

            object var4 = var3;
            

            


        }





        static void Main2(string[] args)
        {
            //implicit or auto conversion
            byte var1 = 10;
            short var2 = var1;
            int var3 = var2;
            double var4 = var3;
            
            //explicit or manual conversion
            int var6 = 600;
            byte var7 = (byte)var6;
            Console.WriteLine(var7);


            checked
            {
                int var8 = 90000;
                int var9 = int.Parse(Console.ReadLine());
                int var10 = var8 * var9;
            }

            
        }
    }
}
