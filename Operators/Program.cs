using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstSeriesOfOutput();

            Console.WriteLine("-------------");
            SecondSeriesOfOutput();

            Console.WriteLine("-------------");
            ThirdSeriesOfOutput();

            Console.ReadKey();
        }

        /*
         * ⦁	Write C# code to produce the output shown below:
            x value                y value        expression                 result
            10                       5              x=y+3                     x=8
            10                       5              x=y-2                      x=3
            10                       5              x=y*5                     x=25
            10                       5              x=x/y                      x=2
            10                       5              x=x%y                    x=0

         */
        static void FirstSeriesOfOutput()
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("x={0}", x = y + 3);

            x = 10;
            Console.WriteLine("x={0}", x = y - 2);

            x = 10;
            Console.WriteLine("x={0}", x = y * 5);

            x = 10;
            Console.WriteLine("x={0}", x = x / y);

            x = 10;
            Console.WriteLine("x={0}", x = x % y);
        }

        /*
         Write C# code to display the output as shown below
            x value                 y value             expressions                results
            10                        5                  x+=y                          x=15
            10                        5                  x-=y-2                        x=7
            10                        5                  x*=y*5                       x=250        
            10                        5                  x/=x/y                         x=5
            10                        5                  x%=y                          x=0
        */
        static void SecondSeriesOfOutput()
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("x={0}", x += 3);

            x = 10;
            Console.WriteLine("x={0}", x -= y - 2);

            x = 10;
            Console.WriteLine("x={0}", x *= y * 5);

            x = 10;
            Console.WriteLine("x={0}", x /= x / y);

            x = 10;
            Console.WriteLine("x={0}", x %= y);

        }

        /*
         	Write C# code to prompt a user to enter an integer value. The value is stored in a variable called a. Then the program will show the output as seen below:
                The value of a is 10.
                ................................
                The value of ++a is 11.
                The value of a is 11.
                The value of a++ is 11.
                The value of a is 12.
                The value of --a is 11.
                The value of a is 11.
                The value of a-- is 11.
                The value of a is 10.
        */
        static void ThirdSeriesOfOutput()
        {
            Console.WriteLine("Enter an integer:");
            try
            {
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("The value of a is {0}\n................................", a);

                Console.WriteLine("The value of ++a is {0}", ++a);

                Console.WriteLine("The value of a is {0}", a);

                Console.WriteLine("The value of a++ is {0}", a++);

                Console.WriteLine("The value of a is {0}", a);

                Console.WriteLine("The value of --a is {0}", --a);

                Console.WriteLine("The value of a is {0}", a);

                Console.WriteLine("The value of a-- is {0}", a--);

                Console.WriteLine("The value of a is {0}", a);

            }
            catch (FormatException)
            {
                Console.WriteLine("Not a good number");
            }
        }
    }
}
