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
            JosipaBanovac();

            Console.ReadKey(false);
        }
        
        static void Nastavnik()
        {
            Console.WriteLine("Course title: OOM");
        }
        
        static void JosipaBanovac()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Josipa Banovac.");
        }
        
        static void JulijanSribar()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Julijan Šribar.");
        }

    }
}
