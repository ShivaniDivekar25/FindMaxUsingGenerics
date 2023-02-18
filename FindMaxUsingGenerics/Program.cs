namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using Generics");
            Console.WriteLine("Enter an option");
            Console.WriteLine("1:Find integer maximum number\n2:Find float maximum number\n3:Find maximum string\n4:Find maximum using Generic");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximumNumber.FindMaxInteger();
                    break;
                case 2:
                    FindMaximumNumber.FindMaxFloat();
                    break;
                case 3:
                    FindMaximumNumber.FindMaxString();
                    break;
                case 4:
                    //For Integer value
                    Console.WriteLine("Enter first number");
                    int firstInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int secondInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third number");
                    int thirdInt = Convert.ToInt32(Console.ReadLine());
                    
                    //For Float value
                    Console.WriteLine("Enter first float number");
                    float firstFloat = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second float number");
                    float secondFloat = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter third float number");
                    float thirdFloat = (float)Convert.ToDouble(Console.ReadLine());
       
                    //For string value
                    Console.WriteLine("Enter first string");
                    string firstString = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string secondString = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string thirdString = Console.ReadLine();

                    //For Refactor-1 UC3
                    Console.WriteLine("Max value:" + GenericMaximum<int>.GenericMaxNumber(firstInt, secondInt, thirdInt));
                    Console.WriteLine("Max value:" + GenericMaximum<float>.GenericMaxNumber(firstFloat, secondFloat, thirdFloat));
                    Console.WriteLine("Max value:" + GenericMaximum<string>.GenericMaxNumber(firstString, secondString, thirdString));

                    //For Refactor-2 UC3
                    GenericMaximum<int> obj1 = new GenericMaximum<int>(firstInt, secondInt, thirdInt);
                    obj1.TestMaximum();
                    GenericMaximum<float> obj2 = new GenericMaximum<float>(firstFloat, secondFloat, thirdFloat);
                    obj2.TestMaximum();
                    GenericMaximum<string> obj3 = new GenericMaximum<string>(firstString, secondString, thirdString);
                    obj3.TestMaximum();
                    break;
                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
        }
    }
}