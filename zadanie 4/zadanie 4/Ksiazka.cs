using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Ksiazka
    {
        public int Id { get; set; }
        public string Tytul { get; set; }

        public int rok { get; set; }
        [ForeignKey("Autor")]
        public string Autor { get; set; }
        public Autor autor { get; set; }
    }
}
