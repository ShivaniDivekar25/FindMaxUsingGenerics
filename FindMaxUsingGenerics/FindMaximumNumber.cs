using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class FindMaximumNumber
    {
        public static void FindMaxInteger()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber>secondNumber && firstNumber>thirdNumber)
                Console.WriteLine("The {0} is greatest of all number",firstNumber);
            else if(secondNumber>thirdNumber)
                Console.WriteLine("The {0} is greatest of all number",secondNumber);
            else
                Console.WriteLine("The {0} is greatest of all number",thirdNumber);
        }
        public static void FindMaxFloat()
        {
            Console.WriteLine("Enter first float number");
            float firstNumber = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second float number");
            float secondNumber = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third float number");
            float thirdNumber = (float)Convert.ToDouble(Console.ReadLine());

            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0) 
                Console.WriteLine("The {0} is greatest of all number", firstNumber);
            else if (secondNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine("The {0} is greatest of all number", secondNumber);
            else
                Console.WriteLine("The {0} is greatest of all number", thirdNumber);
        }
        public static void FindMaxString()
        {
            Console.WriteLine("Enter first string");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();
            Console.WriteLine("Enter third string");
            string thirdString = Console.ReadLine();

            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
                Console.WriteLine("The {0} is greatest of all number", firstString);
            else if (secondString.CompareTo(thirdString) > 0)
                Console.WriteLine("The {0} is greatest of all number", secondString);
            else
                Console.WriteLine("The {0} is greatest of all number", thirdString);
        }
    }
}
