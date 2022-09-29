using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    class Mainboard : HWKomponent
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        public Mainboard(string bezeichner, float preis, string hersteller) :base(bezeichner, preis, hersteller)
        {

        }
    }
}
