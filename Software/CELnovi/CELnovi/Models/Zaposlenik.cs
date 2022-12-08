using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELnovi.Models
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public bool ProvjeriLozinku (string lozinka)
        {
            return Lozinka == lozinka;
        }
    }
}
