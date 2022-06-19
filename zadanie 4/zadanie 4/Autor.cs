using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Autor
    {
        public Autor()
        {
            Ksiazka = new List<Ksiazka>();
        }
        public int Id { get; set; }
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }
        public List<Ksiazka> Ksiazka { get; set; }
    }
}