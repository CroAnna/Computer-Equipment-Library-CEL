using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELnovi.Models
{
    public class IzvorFinanciranjaKlasa
    {
        public int Id { get; set; }
        public string Iznos { get; set; }
        public string Naziv { get; set; }
        
        public override string ToString()
        {
            return Naziv;
        }
    }
}
