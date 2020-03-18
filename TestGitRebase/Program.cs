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
            DanijelKrpes();
            Nastavnik();
            Marko();

            Console.ReadKey(false);
        }
        static void DanijelKrpes()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Danijel Krpes.");
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
    }
}
