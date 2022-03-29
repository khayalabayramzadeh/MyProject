using System;

namespace Lesson8
{
    class Program
    {
        public static void Main(string[] args)
        {

            User user_1 = new User("Khayala", "Bayramzadeh", 2002);
            user_1.PrintUserToConsole();
            Console.WriteLine(user_1.GetAgeAfterXYeaars(5));


            User.MaxUserNameLetterCount = 100;


            User user_2 = new User(1994);
            user_2.name = "Kamran";
            user_2.surname = "Shahaliyev";
            user_2.PrintUserToConsole();


            User user_3 = new User("Banu","Huseynova");
            user_3.YearOfBirth = 2001;
            user_3.PrintUserToConsole();


            User.MaxUserNameLetterCount = 1000;


            User user_4 = new User();
            user_4.name = "Raul";
            user_4.surname = "Najafov";
            user_4.YearOfBirth = 2000;
            user_4.PrintUserToConsole();


            User[] userArray = new User[100];
            foreach (var user in userArray)
            {

            }


            Program p_1 = new Program();
            Console.WriteLine(p_1.SumNumbers(5, 6));
   
        }


        public int SumNumbers(int a, int b)
        {
            return a + b;
        }


    }

    class User
    {
        public string name;
        public string surname;
        public int YearOfBirth;


        public string GetFullName()
        {
            return name + " " + surname;
        }


        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }


        public void PrintUserToConsole()
        {
            var str = $"My fullname is {name} {surname}, and my birhdate is {YearOfBirth} and my maxNameLetterCount is {MaxUserNameLetterCount}";
            Console.WriteLine(str);
        }


        public int GetAgeAfterXYeaars(int year)
        {
            return GetAge() + year;
        }


        public User(string name, string surname, int birthdate)
        {
            this.name = name;
            this.surname = surname;
            this.YearOfBirth = birthdate;
        }


        public User(int birthdate)
        {
            this.YearOfBirth = birthdate;
        }


        public User(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }


        public User()
        {

        }


        ~User()
        {

        }


        public static int MaxUserNameLetterCount;


        /*public User()
        {
            Program.Main(new[] { "" });
            Program p_1 = new Program();
            p_1.SumNumbers(7, 8);
        }*/
        
        
        static void ChangeUserMaxLetterCount(int newCount)
        {
            MaxUserNameLetterCount = newCount;
        }

       

        
    }
}
