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
            
            AnteMiskovic();
            AuroMazzi();
            BornaBrisar();
            BrunoČale();
            DanijelKrpes();
            DarijBaldasari();
            DomagojSalkic();
            DonaPejnovic();
            EmilOrdanic();
            FilipVelebitSamodol();
            FranKalinger();
            FranŠafranec();
            IvanBatinic();
            IvanBlazeka();
            IvanMihin();
            IvanZoric();
            JosipVuckovic();
            JulijanSribar();
            MarioBilic();
            MarkoBoros();
            MarkoVitkovic();
            MatejaVukic();
            PaolaKolar();
            PaskoBerisic();
			RolandRostohar();
            SaraCuzelePapata();
            SenadMandzic();
            SvenGotal();
            JosipaBanovac();
            Console.ReadKey(false);
        }

        static void Nastavnik()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My name is Julijan");
            var myClass = new Teacher();
            myClass.Present();
        }

        static void AnteMiskovic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ante Miskovic.");
            Console.WriteLine("I like ćevap.");
            Console.WriteLine("My favorite place is Zagreb.");
        }

        static void AuroMazzi()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Auro Mazzi.");
            Console.WriteLine("I like the song 'I got it from Agnes' by Tom Lehrer!");
            Console.WriteLine("My favourite place is the fridge");
            Console.WriteLine("My favourite movie is Groundhog Day");
            var myClass = new AuroMazzi();
            myClass.Present();
        }

        static void BornaBrisar()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("Aj lajk chai");
            Console.WriteLine("My Name is Borna Brisar.");
            Console.WriteLine("My favourite place is home. ");
            Console.WriteLine("My favourite movie is 300. ");
            var myClass = new BornaBrisar(); 
            myClass.Present();
        }

        static void BrunoČale()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Bruno Cale.");
            Console.WriteLine("I like cevape.");
        }

        static void DanijelKrpes()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Danijel Krpes.");
            Console.WriteLine("My jello is still shaking from the earthquake.");
            Console.WriteLine("My favorite place is Cape Canaveral");
        }

        static void DarijBaldasari()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Darij Baldasari.");
            Console.WriteLine("I like sir");
            Console.WriteLine("My favorite place is Bobovisce");
        }

        static void DomagojSalkic()
        {
            System.Console.WriteLine("Courese title: OOM");
            Console.WriteLine("My Name is Domagoj Salkić.");
            Console.WriteLine("I like chocolate.");
            Console.WriteLine("My favorite place is Home");
            Console.WriteLine("My favorite movie is The Godfather.");
            var myClass = new DomagojSalkic();
            myClass.Present();
        }

        static void DonaPejnovic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Dona Pejnovic.");
            Console.WriteLine("I like ramen");
        }

        static void EmilOrdanic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Emil Ordanic.");
            Console.WriteLine("I like Corona");
            Console.WriteLine("My favoruite city is Zagreb");
        }

        static void FilipVelebitSamodol()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Filip Velebit Samodol.");
            Console.WriteLine("I Like neku grupu ili omiljenu hranu.");
        }

        static void FranKalinger()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Fran Kalinger.");
        }

        static void FranŠafranec()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Blažeka.");
            Console.WriteLine("I like chocolate.");
        }

        static void IvanBatinic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Batinic.");
            Console.WriteLine("I like pauza.");
            Console.WriteLine("My favourite place is krevet.");
            Console.WriteLine("My favourite movie is Vruci u sedlu.");
            var myClass = new IvanBatinic();
            myClass.Present();
        }

        static void IvanBlazeka()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Blažeka.");
            Console.WriteLine("I like čevapi s lukom");
            Console.WriteLine("My favourite place is Pušća Bistra");
            Console.WriteLine("My favourite movie is Jovan Fitilj (John Wick)");
            var myClass = new IvanBlazeka();
            myClass.Present();
        }

        static void IvanMihin()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Mihin.");
            Console.WriteLine("I like ananas.");
            Console.WriteLine("My favorite country is Canada.");
            Console.WriteLine("My favorite movie is Scarface.");
        }

        static void IvanZoric()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Ivan Zorić.");
            Console.WriteLine("I like healthy food.");
            Console.WriteLine("My favourite place is London.");
            Console.WriteLine("My favourite movie is idk.");
        }

        static void JosipVuckovic()
        {
            Console.WriteLine();
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Josip Vuckovic.");
            Console.WriteLine("I like ... something... sometimes...");
            Console.WriteLine("My favourite place is far away....");
            Console.WriteLine("My favorite movie is SW...");
            var myClass = new JosipVuckovic();
            myClass.Present();
        }

        static void JulijanSribar()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Julijan Šribar.");
            Console.WriteLine("I like chocolate.");
            Console.WriteLine("My favourite place is Ozalj.");
            Console.WriteLine("My favourite movie is Casablanca.");
            var myClass = new JulijanSribar();
            myClass.Present();
        }

        static void MarioBilic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Mario Bilić.");
            Console.WriteLine("I like food");
            Console.WriteLine("My favourite place is my garage");
            Console.WriteLine("My favourite movie is ");
            var myClass = new MarioBilic();
            myClass.Present();
        }

        static void MarkoBoros()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Marko Boroš.");
            Console.WriteLine("I'm eating pancakes at the moment.");
            Console.WriteLine("My favourite place to eat cevapi is Orašje");
        }

        static void MarkoVitkovic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Marko Vitković.");
        }

        static void MatejaVukic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Mateja Vukic.");
            Console.WriteLine("I like cabbage.");
            Console.WriteLine("My favuorite place is Murvica");
            Console.WriteLine("My favourite movie is Pulp Fiction");
            var myClass = new MatejaVukic();
            myClass.Present();
        }

        static void PaolaKolar()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Paola Kolar.");
            Console.WriteLine("I like Cheesecake");
            Console.WriteLine("My favourite place is Lviv.");
            Console.WriteLine("My favourite movie is Dirty Dancing");
            var myClass = new PaolaKolar();
            myClass.Present();

        }

        static void PaskoBerisic()
        {
            
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Pasko Berisic.");
            Console.WriteLine("I like nothing.");
            Console.WriteLine("My favorite place is nowhere.");
            Console.WriteLine("My favorite movie is NoN.");
            var myClass = new PBerisic();
            myClass.Present();
            
        }
		static void RolandRostohar()
		{
			Console.WriteLine("Course title: OOM");
			Console.WriteLine("My Name is Roland Rostohar.");
			Console.WriteLine("I like taking a good s**t");
			Console.WriteLine("My favourite place is toilet");
		}
		static void SaraCuzelePapata()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Sara Ćuzele Papata.");
            Console.WriteLine("I like chocolate.");
            Console.WriteLine("My favourite place is home.");
            Console.WriteLine("My favourite movie is fight club.");
            var myClass = new SaraCuzelePapata();
            myClass.Present();
        }
        static void SenadMandzic()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Senad Mandzic.");
            Console.WriteLine("I like chocolate");
        }
        static void SvenGotal()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Sven Gotal.");
            Console.WriteLine("I like soup.");
            Console.WriteLine("My favourite place is Zagreb.");
            Console.WriteLine("My favourite movie is: Event Horizon");

            var myClass = new SvenGotal();
            myClass.Present();
        }

        static void JosipaBanovac()
        {
            Console.WriteLine("Course title: OOM");
            Console.WriteLine("My Name is Josipa Banovac.");
            Console.WriteLine("I like white colour.");
            Console.WriteLine("My favourite place is Skradin.");
            Console.WriteLine("My favourite movie is: The call of wild");

            var myClass = new JosipaBanovac();
            myClass.Present();
        }
    }
}