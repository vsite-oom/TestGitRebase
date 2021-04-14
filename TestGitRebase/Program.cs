using System;

namespace TestGitRebase
{
    class Program
    {
        static void Main(string[] args)
        {
            Nastavnik();
            Iposavac();
            DKrpes();
            JSribar();
            JSribar2();
            mcop();
            AZunic();
            VBehin();
            DJergovic();
            KBratkovic();
            JSribar3();
            IBukvic();
            FGurqiti();
            IMihin();
            JHusic();
            mateo2903();

            var azunic = new AZunic();
            azunic.Message();

            var iobradovic = new IObradovic();
            iobradovic.Message();

            var jsribar = new JSribar();
            jsribar.Message();

            var dkrpes = new DKrpes();
            dkrpes.Message();

            var imihin = new IMihin();
            imihin.Message();

            var kbratkovic = new KBratkovic();
            kbratkovic.Message();
            
            var mateo = new Mateo2903();
            mateo.Message();

        }

        static void IBukvic()
        {
            //TODO : add comment
        }

        static void Nastavnik()
        {

        }

        static void DKrpes()
        {
            Console.WriteLine("My name is Danijel Krpes");
            Console.WriteLine("I am student of VSITE, third year.");
        }

        static void Iposavac()
        {

        }
        static void mcop()
        {
            Console.WriteLine("My name is Matija Cop");
            Console.WriteLine("I Am a student at Vsite, third year");

        }

        static void JSribar()
        {
            Console.WriteLine("My name is Julijan Šribar");
            Console.WriteLine("I am a student of VSITe, fourth year.");
        }

        static void JSribar2()
        {

        }

        static void AZunic()
        {

        }

        static void VBehin()
        {
            Console.WriteLine("My name is Valentina Behin.");
        }

        static void IMihin()
        {
            Console.WriteLine("My name is Ivan Mihin");
            Console.WriteLine("I am a student of VsiTe, third year");
        }

        static void DJergovic()
        {
            Console.WriteLine("My name is Dario Jergović");
            Console.WriteLine("I am a student of VSITE, third year.");
        }

        static void KBratkovic()
        {
            Console.WriteLine("My name is Kresimir Bratkovic");
            Console.WriteLine("I am a student of VSITE, fourth year.");
        }
        static void FGurqiti()
        {
            Console.WriteLine("My name in Fati Gurqiti");
            Console.WriteLine("I am a student of KOU");
        }

        static void mateo2903()
        {
            Console.WriteLine("My name is Mateo Jadrušić");
            Console.WriteLine("I am a student of VSITE, fourth year.");
        }

        static void JSribar3()
        {
            Console.WriteLine("My name is Julijan Šribar");
            Console.WriteLine("I'm a student at VSITe");
        }
        static void JHusic()
        {
            Console.WriteLine("My name is Jasmin Husić");
            Console.WriteLine("I am a student of VSITE, fourth year.");
        }
    }
}
