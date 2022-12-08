using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELnovi.Models
{
    public class Oprema
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string DatVrPrimke { get; set; }
        public string NazivProjekta { get; set; }
        public IzvorFinanciranjaKlasa IzvorFinanciranja { get; set; }
        public string OpisOpreme { get; set; }
        public string OsobaNabave { get; set; }
        public string OsobaPrimke { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
