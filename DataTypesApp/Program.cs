namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of " + pieces + " apple(s): ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + pieces + " apple(s) is " + price);
            Console.WriteLine("The value of the original price is " + price);
            Console.WriteLine("The value of the original price is " + (int) price);
            Console.WriteLine("Press any key to exit......");
            Console.ReadKey();
        }
    }
}