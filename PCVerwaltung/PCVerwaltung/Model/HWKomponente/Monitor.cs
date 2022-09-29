using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    class Monitor : HWKomponent
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        public Monitor(string bezeichner, float preis, string hersteller) : base(bezeichner, preis, hersteller)
        {

        }
    }
}
