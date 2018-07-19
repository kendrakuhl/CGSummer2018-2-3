using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gather the three strings from the user:
            Console.Write("Enter your first string: ");
            string stringOne = Console.ReadLine();

            Console.Write("Enter your second string: ");
            string stringTwo = Console.ReadLine();

            Console.Write("Enter your third string: ");
            string stringThree = Console.ReadLine();

            // Now write your result to the console.
            // I did it two different ways so you could see another way to do it. :D
            Console.WriteLine("Here are your three strings: " + stringOne + stringTwo + stringThree);
            Console.WriteLine(string.Format("Here is an alternate way to concatenate: {0}{1}{2}", stringOne, stringTwo, stringThree));

            Console.ReadLine();
        }
    }
}
