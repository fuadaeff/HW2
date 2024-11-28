namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
