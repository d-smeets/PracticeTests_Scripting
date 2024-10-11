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
            Console.WriteLine("A = Reading and writing");
            Console.WriteLine("B = Math and Methods 1");
            Console.WriteLine("C = Math and Methods 2");
            Console.WriteLine("D = Choices Choices");
            string sectionText = Console.ReadLine();
            string section1 = "A";
            string section2 = "B";
            string section3 = "C";
            string section4 = "D";
            



            if (sectionText == section1) { readingAndWriting(); }
            if (sectionText == section2) { mathAndMethod1(); }
            if (sectionText == section3) { mathAndMethod2(); }
            if (sectionText == section4) {choicesChoices(); }

            // Code for Reading and writing section of the Test
            void readingAndWriting() 
            {
                Console.WriteLine("Please enter you Street Name");
                string street = Console.ReadLine();
                Console.WriteLine("Now please enter you house number");
                string houseNumber = Console.ReadLine();
                Console.WriteLine("If you could please enter your postal code awell");
                string postalCode = Console.ReadLine();
                Console.WriteLine("And lastly please enter your residence");
                string residence = Console.ReadLine();
                Console.WriteLine("Thank you for entering your infomation");

                Console.WriteLine(street + " " + houseNumber + ", " + postalCode + " " + residence); // writes every input inbetween
            };


            //Code for Math And Methods 1 section of test
            void mathAndMethod1() 
            {
                int total = 50;

                Substract10();
                Console.WriteLine("the total is now:" + total);
                Substract10();
                Console.WriteLine("the total is now:" + total);
                Substract10();
                Console.WriteLine("the total is now:"+ total);
                Substract10();
                Console.WriteLine("the total is now:"+ total);

                void Substract10()
                {
                    total -= 10;
                }


            }


            // code for Math and Method 2 section of the Test
            void mathAndMethod2() 
            {
                int num1 = 100; // Number 1 Value 
                int num2 = 25;  // Number 2 Value

                Subtracer();
                Console.WriteLine(num1);
                Subtracer();
                Console.WriteLine(num1);
                Subtracer();
                Console.WriteLine(num1);
                Subtracer();
                Console.WriteLine(num1);
                Subtracer();
                Console.WriteLine(num1);



                void Subtracer() // method to substrackt numbers 
                {
                    num1 = -num2;
                    num2 = -5;
                }

            }


            //Code for Choices Choices section of the test
            void choicesChoices() 
            {

                string TRex = "Tyrannosaurus Rex";
                string Titan = "Titanosaur";
                string Bird = "Pterodactyl";

                Console.WriteLine("Please Write is your favorite Dinosaur is :)");
                string myDino = Console.ReadLine();
                if (myDino == TRex)
                {
                    Console.WriteLine("BONE - CRUNCHING MADNESS");
                }
                else if (myDino == Titan)
                {
                    Console.WriteLine("That's a big one!!");
                }
                else if (myDino == Bird)
                {
                    Console.WriteLine("Oh yeah, the m’fing Pterodacty");
                }
                else
                {
                    Console.WriteLine("your choice is:" + myDino + " We Sadly didnt have that in our database");
                }
            }

        }   
    }
}
