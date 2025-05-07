namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tedad dars");
            int dars = int.Parse(Console.ReadLine());
            int vahed = 0;
            int nomre = 0;
            for (int i = 1; i <= dars; i++) ;
            {
                Console.WriteLine("vahed");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("nomre");
                int b = int.Parse(Console.ReadLine());
                nomre = a * b;
                vahed = b;
            }
            int f = (int)nomre / vahed;
            Console.WriteLine(f);

        }
    }
}
