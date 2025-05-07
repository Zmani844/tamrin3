using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bastanivanili = 5000;
            int bastanitotfarangi = 5500;
            int bastanishokolati = 6000;

            int tedadbastanivanili = 0;
            int tedadbastanitotfarangi = 0;
            int tedadbastanishokolati = 0;
            List<string> maboob = new List<string>();
            int daramademroz = 0;
            Console.WriteLine("tedad moshtari");
            int moshtari =int.Parse(Console.ReadLine());

            for (int i = 0; i < moshtari; i++) ;
            {
                Console.WriteLine($"moshtari{i+1}");
                int bastanikharidarishode = int.Parse(Console.ReadLine());

                Console.WriteLine("tetad vanili hay kharidari shode");
                int vanilikharidarishode = int.Parse(Console.ReadLine());

                Console.WriteLine("tedad totfarangi haye kharidari shide");
                int totfarangikharidarishode = int.Parse(Console.ReadLine());

                Console.WriteLine("tedade shokolati haye kharidari shode");
                int shokolatikharidarishode = int.Parse(Console.ReadLine());

                tedadbastanivanili += vanilikharidarishode;
                tedadbastanitotfarangi += totfarangikharidarishode;
                tedadbastanishokolati += shokolatikharidarishode;

                daramademroz += (vanilikharidarishode * bastanivanili) + (totfarangikharidarishode * bastanitotfarangi) + (shokolatikharidarishode * bastanishokolati);

                Console.WriteLine($"daramademroz{daramademroz}");
                Console.WriteLine($"tedad vanil haye forokhte shode{tedadbastanivanili}");
                Console.WriteLine($"tedad tot farangi forokhte shode{tedadbastanitotfarangi}");
                Console.WriteLine($"tedad shokolati forokhte shode{tedadbastanishokolati}");

                int mahboob = Math.Max(tedadbastanivanili, Math.Max(tedadbastanitotfarangi, tedadbastanishokolati));

            }   if (mahboob == tedadbastanivanili) ;
            {
                maboob.Add("vanili");
            }
            if (mahboob == tedadbastanitotfarangi) ;
            {
                maboob.Add("totfarangi");
            }
            if (mahboob == tedadbastanishokolati) ;
            {
                maboob.Add("shokolati");
            }
            if (maboob.Count == 1) ;
            {
                Console.WriteLine(maboob[0] + "behtarin foorosh");
            }
            else
            {
                Console.WriteLine(string.Join(, maboob));
            }





        }
    }
}
