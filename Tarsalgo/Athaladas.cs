using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarsalgo
{
    class Athaladas
    {

        readonly int ora;
        readonly int perc;
        readonly string azon;
        readonly string irany;
        readonly DateTime ido;
        static int bentLevokSzama = 0;

        public int Ora => ora;

        public int Perc => perc;

        public string Azon => azon;

        public string Irany => irany;

        public DateTime Ido => ido;

        public int BentLevokSzama;

        public Athaladas(int ora, int perc, string azon, string irany)
        {
            this.ora = ora;
            this.perc = perc;
            this.azon = azon;
            this.irany = irany;
            this.ido = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, ora, perc, 0);
            this.BentLevokSzama = irany.Equals("be") ? ++bentLevokSzama : --bentLevokSzama;
        }

    }
}
