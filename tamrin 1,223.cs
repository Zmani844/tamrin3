namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adad ra vard kon");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("tavan ra vard konid");
            int b = int.Parse(Console.ReadLine());

            double tavan = Math.Pow(a, b);
            Console.WriteLine(tavan);
        }
    }
}
