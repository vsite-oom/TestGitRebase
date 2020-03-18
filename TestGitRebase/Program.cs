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
            IvanZoric();

            Console.ReadKey(false);
        }
        static void IvanZoric()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Zorić.");
        }
        static void Nastavnik()
        {
            Console.WriteLine("Course title: OOM");
        }


    }
}
