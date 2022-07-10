using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_II
{
    public class wlasciciel
    {
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int numer_tel { get; set; }

        public List<dokumenty> Dokumenty { get; set; }

        public List<samochod> Samochody { get; set; }

    }
}
