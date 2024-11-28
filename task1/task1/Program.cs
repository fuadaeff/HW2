namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter age:");
            int age= int.Parse(Console.ReadLine());
            if (age >=0 && age <= 12{ 
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Yasli");
            }
        }
    }
}
