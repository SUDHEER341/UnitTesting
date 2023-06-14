namespace UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

            Logical_Programs obj = new Logical_Programs();
            Console.WriteLine("Enter the number to display the reverse of it!");
            int number = Convert.ToInt32(Console.ReadLine());
            obj.Reverse_Number(number);

            Console.WriteLine("Enter the number to check whether it is prime or not");
            int number1 = Convert.ToInt32(Console.ReadLine());
            obj.Prime_Number(number1);

            Console.WriteLine("Please enter the number to check it is Perfect number or not");
            int number2 = Convert.ToInt32(Console.ReadLine());
            obj.Perfect_Number(number2);

            Console.WriteLine("Please enter the number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            obj.Fibanocci_Series(number3);
        }
    }
}