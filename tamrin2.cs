namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 add vard kon");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int miangin = (a + b + c) / 3;
            Console.WriteLine(miangin);
        }
    }
}
