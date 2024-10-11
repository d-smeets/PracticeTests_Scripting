using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace OefenToetsP1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //choosing section for the result of the code for the test
            Console.WriteLine("What section of the test would you like to see?");
            Console.WriteLine("A = BirthDayInput");
            Console.WriteLine("B = Math and Methods 1");
            Console.WriteLine("C = Math and Methods 2");
            Console.WriteLine("D = Favorite Color choice");
            string sectionText = Console.ReadLine();
            string section1 = "A";
            string section2 = "B";
            string section3 = "C";
            string section4 = "D";




            if (sectionText == section1) { birthDayInput(); }
            if (sectionText == section2) { mathAndMethod1(); }
            if (sectionText == section3) { mathAndMethod2(); }
            if (sectionText == section4) { favColorChoice(); }

            // Code for Birthday input section of the Test
            void birthDayInput()
            {
                Console.WriteLine("Please Enter Your Birth Month");
                string birthMonth = Console.ReadLine();
                Console.WriteLine("Please Enter Your Birthday now");
                string birthday = Console.ReadLine();
                Console.WriteLine("Please Enter The year you where born");
                string birthyear = Console.ReadLine();
                Console.WriteLine("So your date of birth is the following?");
                Console.WriteLine(birthday + " " + birthMonth +" "+ birthyear );
            };


            //Code for Math And Methods 1 section of test
            void mathAndMethod1()
            {
                int Points = 20;

                AddFive();
                AddFive();
                AddFive();
                AddFive();
                AddFive();
                AddFive();

                void AddFive()
                {
                    Points += 5;
                    Console.WriteLine( "Your Points are: " + Points);
                }

            }


            // code for Math and Method 2 section of the Test
            void mathAndMethod2()
            {
                int initialSpeed = 120;
                int deceleration = 15;

                SlowDown();
                SlowDown();
                SlowDown();
                SlowDown();


                void SlowDown()
                {
                    initialSpeed -= deceleration;
                    deceleration += 3;
                    Console.WriteLine("Your Speed is now: " + initialSpeed);
                }



            }


            //Code for favorite color section of the test
            void favColorChoice()
            {

                string R = "Red";
                string G = "Green";
                string B = "blue";


                Console.WriteLine("What might be your favorite Color??");
                string favoriteColor = Console.ReadLine();

                if (favoriteColor == R)
                {
                    Console.WriteLine("Bold choice!");
                }
                else if (favoriteColor == G)
                {
                    Console.WriteLine("Nature lover, I see");
                }
                else if (favoriteColor == B)
                {
                    Console.WriteLine("Cool and calm!");
                }
                else
                {
                    Console.WriteLine("your choice is:" + favoriteColor + " Sounds intresting");
                }


            }

        }
    }
}