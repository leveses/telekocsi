using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekocsi
{
    class Igeny
    {
        public string Azon { get; private set; }
        public string Indulas { get; private set; }
        public string Cel { get; private set; }
        public int Szemelyek { get; private set; }

        public Igeny(string n)
        {
            string[] sor = n.Split(';');
            Azon = sor[0];
            Indulas = sor[1];
            Cel = sor[2];
            Szemelyek = int.Parse(sor[3]);
        }
    }
}
