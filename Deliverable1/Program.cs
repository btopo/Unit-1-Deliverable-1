using System;



namespace Deliverable1

{

    class Program

    {

        static void Main(string[] args)

        {

            bool proceed = true;

            while (proceed)  //

            {

                Console.WriteLine("How many people are we making PB & J sandwiches for? then press ENTER: ");

                int numpeople = Int16.Parse(Console.ReadLine());



                double numSlices = numpeople * 2;

                double numTablespoons = numpeople * 2;

                double numTeaspoons = numpeople * 4;



                double loafsOfBread = Math.Ceiling(numSlices / 28);

                double jarsOfPeanutbutter = Math.Ceiling(numTablespoons / 32);

                double jarsOfJelly = Math.Ceiling(numTeaspoons / 48);



                Console.WriteLine("You need:");

                Console.WriteLine(numSlices + " Slices of Bread");

                Console.WriteLine(numTablespoons + " Tablespoons of Peanut butter");

                Console.WriteLine(numTeaspoons + " Teaspoons of Jelly");

                Console.WriteLine("Which is...");

                Console.WriteLine(loafsOfBread + " Loaves of Bread");

                Console.WriteLine(jarsOfPeanutbutter + " Jars of Peanut Butter");

                Console.WriteLine(jarsOfJelly + " Jars of Jelly");



                Console.Write("Would you like to start again? press Yes/Y or No/N: ");

                string answer = Console.ReadLine();

                if (string.Equals("yes", answer) || answer.Contains("Y") || answer.Contains("y"))

                {

                    //Proceed

                }

                else

                {

                    Console.WriteLine("Goodbye!");

                    proceed = false;

                }

            }

        }

    }

}