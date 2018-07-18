using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDataTypes
{
    class Person
    {
        private int age;

        public void SetAndPrintAge()
        {

            Console.WriteLine("Enter age without mounths:");
            var enteredAge = Console.ReadLine();

            if (ValidAge(enteredAge))
            {
                this.age = Convert.ToInt16(enteredAge);
                SayAge(this.age);
            }
        }

        //method for checking if the age is valid
        private bool ValidAge(object age)
        {   
            try
            {
                if (Convert.ToInt16(age) >= 0 && Convert.ToInt16(age) <= 140)
                    return true;
            }
            catch (InvalidCastException)
            {
                return PrintAndQuit(age);
            }
            catch (FormatException)
            {
                return PrintAndQuit(age);
            }

            return PrintAndQuit(age);

        }
        //method for saying that the entered age is not valid and returning false
        private bool PrintAndQuit(object o)
        {
            Console.WriteLine("{0} is not a valid age", Convert.ToString(o));
            return false;
        }

        //printing the wanted message
        private void SayAge(int age)
        {
            if (age > 1)
                Console.WriteLine("You are {0} years old.", age);
            else
                Console.WriteLine("You are {0} year old.", age);
        }

    }
}
