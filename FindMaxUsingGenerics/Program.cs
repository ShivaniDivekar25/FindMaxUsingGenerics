namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using Generics");
            Console.WriteLine("Enter an option");
            Console.WriteLine("1:Find integer maximum number\n2:Find float maximum number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximumNumber.FindMaxInteger();
                    break;
                case 2:
                    FindMaximumNumber.FindMaxFloat();
                    break;
                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
        }
    }
}