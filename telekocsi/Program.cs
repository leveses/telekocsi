using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace telekocsi
{
    class Program
    {
        static List<Auto> autok = new List<Auto>();
        static List<Igeny> igenyek = new List<Igeny>();
        static void Main(string[] args)
        {
            Beolvas();
            Hirdetok();
            Ferohely();
            Legtobb();
            Console.ReadKey();
        }
        
        private static void Legtobb()
        {
            Dictionary<string, int> indulas = new Dictionary<string, int>();
            Dictionary<string, int> cel = new Dictionary<string, int>();
            foreach (var i in autok)
            {
                if (!indulas.ContainsKey(i.Indulas))
                {
                    indulas.Add(i.Indulas,0);
                }
                if (!cel.ContainsKey(i.Cel))
                {
                    cel.Add(i.Cel,0);
                }
            }
            foreach (var i in autok)
            {
                indulas[i.Indulas]++;
                cel[i.Cel]++;
            }

        }

        private static void Ferohely()
        {
            int x = 0;
            foreach (var i in autok)
            {
                if (i.Indulas == "Budapest" && i.Cel == "Miskolc") 
                {
                    x += i.Ferohely;
                }
            }
            Console.WriteLine("3. feladat");
            Console.WriteLine($"Összesen {x} férőhelyet hirdettek az autósok Budapestről Miskolcra");
        }

        private static void Hirdetok()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("{0} autós hirdetett fuvart.",autok.Count());
        }

        private static void Beolvas()
        {
            
            StreamReader file = new StreamReader("autok.csv");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                autok.Add(new Auto(file.ReadLine()));
            }
            file.Close();

            StreamReader file2 = new StreamReader("igenyek.csv");
            file2.ReadLine();
            while (!file2.EndOfStream)
            {
                igenyek.Add(new Igeny(file2.ReadLine()));
            }
            file2.Close();
        }
    }
}
