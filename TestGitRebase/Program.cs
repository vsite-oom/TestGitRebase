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
            Marko();
            IvanBatinic();
            Console.ReadKey(false);
        }

        static void Nastavnik()
        {
            Console.WriteLine("Course title: OOM");
        }
        static void Marko()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Marko.");
        }
        static void IvanBatinic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Batinic.");
        }
    }
}
