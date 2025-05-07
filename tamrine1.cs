namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,b,c,ra vard kon");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int delta = b * b - 4 * a * c;
            Console.WriteLine(delta);
        }
    }
}
