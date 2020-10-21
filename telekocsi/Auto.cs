using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekocsi
{
    class Auto
    {
        public string Indulas { get; private set; }
        public string Cel { get; private set; }
        public string Rendszam { get; private set; }
        public string Telefonszam { get; private set; }
        public int Ferohely { get; private set; }

        public Auto(string n)
        {
            string[] sor = n.Split(';');
            Indulas = sor[0];
            Cel = sor[1];
            Rendszam = sor[2];
            Telefonszam = sor[3];
            Ferohely = int.Parse(sor[4]);
        }
    }
}
