namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using Generics");
            Console.WriteLine("Enter an option");
            Console.WriteLine("1:Find integer maximum number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximumNumber.FindMaxInteger();
                    break;
                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
        }
    }
}