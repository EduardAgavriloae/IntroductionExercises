using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            FindGreatestValue();

            Console.WriteLine("----------------");
            GetGrade();
        }

        /*
         *Write a C# program that prompts the user to input three integer values and find the greatest value of the three values. 
        */
        static void FindGreatestValue()
        {
            try
            {
                Console.WriteLine("x = ");
                int x = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("y = ");
                int y = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("z = ");
                int z = Convert.ToInt16(Console.ReadLine());

                if (x > y && x > z)
                    Console.WriteLine("The biggest number is: {0}", x);
                if (y > z && y > x)
                    Console.WriteLine("The biggest number is: {0}", y);
                if (z > y && z > x)
                    Console.WriteLine("The biggest number is: {0}", z);
            }
            catch (FormatException)
            {
                Console.WriteLine("A number is not good.");
            }
        }

        /*	Write a C# program that determines a student’s grade. The program will read three types of scores 
         *	(quiz score, mid-term score, and final score) and determine the grade based on the following rules:
                ⦁	if the average score =90% =>grade=A
                ⦁	if the average score >= 70% and<90% => grade=B
                ⦁	if the average score>=50% and<70% =>grade=C
                ⦁	if the average score<50% =>grade=F
        */
       static void GetGrade()
        {
            try
            {
                Console.WriteLine("Values between 0 and 100 please\nQuiz score:");
                float quizScore = (float)Convert.ToDouble(Console.ReadLine());
                if (quizScore < 0 && quizScore > 100)
                {
                    Console.WriteLine("That's not between 0 and 100...");
                    return;
                }

                Console.WriteLine("Mid-term score:");
                float midScore = (float)Convert.ToDouble(Console.ReadLine());
                if (midScore < 0 && midScore > 100)
                {
                    Console.WriteLine("That's not between 0 and 100...");
                    return;
                }

                Console.WriteLine("Final score:");
                float finalScore = (float)Convert.ToDouble(Console.ReadLine());
                if (finalScore < 0 && finalScore > 100)
                {
                    Console.WriteLine("That's not between 0 and 100...");
                    return;
                }

                float avg = (quizScore + midScore + finalScore) / 3;
                Console.Write("Avg Score = {0} => grade = ", avg);

                if (avg <= 50)
                {
                    Console.WriteLine("F");
                    return;
                }
                else if (avg < 70)
                {
                    Console.WriteLine("C");
                    return;
                }
                else if (avg < 90)
                {
                    Console.WriteLine("B");
                    return;
                }
                else Console.WriteLine("A");


            }
            catch (Exception)
            { Console.WriteLine("You got something wrong"); }
        }

    }
}
