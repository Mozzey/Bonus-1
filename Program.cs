using System;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // User will enter a numerical grade from 0 to 100
            // The app will show the corresponding letter grade
            // Prompt User to Continue

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to the Letter Grade Converter!");
                Console.Write("Enter a numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 0 && grade <= 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                else if (grade <= 66)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (grade <= 79)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade <= 87)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else
                {
                    Console.WriteLine("Letter Grade: A");
                }

            }
        }
    }
}
