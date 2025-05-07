namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tedad kol");

            int a = int.Parse(Console.ReadLine());

            int kol = a / 3;

            int baghimande = a % 3;
            Console.WriteLine(kol);
            Console.WriteLine(baghimande);

        }
    }
}
