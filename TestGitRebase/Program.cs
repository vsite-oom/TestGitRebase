using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitRebase
{
    class Program
    {
        static void Main(string[] args)
        {
            Nastavnik();
            SaraCuzelePapata();
            AuroMazzi();
            Marko();
            FranKalinger();
            IvanBatinic();


            Console.ReadKey(false);
        }

        static void SaraCuzelePapata()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Sara Ćuzele Papata.");
        }
        static void Marko()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Marko.");
        }
        static void Nastavnik()
        {
            Console.WriteLine("Course title: OOM");
        }
        static void FranKalinger()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Fran Kalinger.");
        }

        static void AuroMazzi()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Auro Mazzi.");
        }
        static void IvanBatinic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Batinic.");
        }
    }
}
