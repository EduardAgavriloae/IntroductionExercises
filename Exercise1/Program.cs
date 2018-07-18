using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {   
            while (true)
            {
                DisplayExercices();
                string aux = Console.ReadLine();
                switch (aux)
                {
                    case "0":
                        return; 
                    case "1":
                        DoExerciseOne();
                        break;
                    case "2":
                        DoExerciseTwo();
                        break;
                    case "3":
                        DoExerciseThree();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option!");
                        break;

                }
                Console.WriteLine("-------------------------------\nPress any key to show the menu:");
                Console.ReadKey();
            }
            
        }

        
        static void DisplayExercices() {
            Console.WriteLine("\n\nSelect an option:\n");
            Console.WriteLine("0 -> Exit\n");
            Console.WriteLine("1 -> Write C# code to declare a variable to store the age of a person. Then the output of the program is as an example shown below:" +
                "\n     You are 20 years old.\n");
            Console.WriteLine("2 -> Write C# code to display the asterisk pattern as shown below"
        + "\n*****"
        + "\n*****"
        + "\n*****"
        + "\n*****"
        + "\n*****\n");
            Console.WriteLine("3 -> Write C# code to declare two integer variables, one float variable, and one string variable and assign 10, 12.5, " +
          "and \"C# programming\" to them respectively.Then display their values on the screen\n");
            Console.WriteLine("4 -> Write C# code to prompt a user to input his/her name and then the output will be shown as an example below:\n       Hello John!\n");
        }

        /*⦁	Write C# code to declare a variable to store the age of a person. Then the output of the program is as an example shown below:
            You are 20 years old.
        */
        static void DoExerciseOne()
        {
            Console.WriteLine("Exercise 1:\n");
            Person p1 = new Person();
            p1.SetAndPrintAge();

        }

        /*⦁	Write C# code to display the asterisk pattern as shown below
            *****
            *****
            *****
            *****
            *****
         */
        static void DoExerciseTwo() {
            Console.WriteLine("Exercise 2:\n");
            string row = "*****";
            for (int index = 1; index <= 5; index++)
            {
                Console.WriteLine(row);
            }
        }

        /*⦁	Write C# code to declare two integer variables, one float variable, and one string variable and assign 10, 12.5, 
          and "C# programming" to them respectively. Then display their values on the screen
        */
        static void DoExerciseThree()
        {
            Console.WriteLine("Exercise 3:\n");
            try
            {
                Console.WriteLine("Enter first integer:");
                int firstInteger = Convert.ToInt16(Console.ReadLine()) + 10;

                Console.WriteLine("Enter second integer:");
                int secondInteger = Convert.ToInt16(Console.ReadLine()) + 10;

                Console.WriteLine("Enter float number:");
                float floatNumber = (float)(Convert.ToDouble(Console.ReadLine()) + 12.5);

                Console.WriteLine("Enter a string:");
                string str = Console.ReadLine() + "C# programming";

                Console.WriteLine("The integers are now: {0}, {1}", firstInteger, secondInteger);
                Console.WriteLine("The float number: {0}", floatNumber);
                Console.WriteLine("And the final thing: {0}", str);
            }
            catch (FormatException)
            {
                Console.WriteLine("There are invalid numbers");
            }
            
        }

        /*⦁	Write C# code to prompt a user to input his/her name and then the output will be shown as an example below:
            Hello John!*/
        static void DoExerciseFour()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
        }

    }
}
