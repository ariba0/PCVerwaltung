using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    class SSD : HWKomponent
    {
        private int _speicher;
        private int _lesegeschwindigkeit;
        private int _schreibgeschwindigkeit;
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        public SSD(string bezeichner, float preis, string hersteller, int speicher, int lesegeschwindigkeit, int schreibgeschwindigkeit) : base(bezeichner, preis, hersteller)
        {
            _speicher = speicher;
            _lesegeschwindigkeit = lesegeschwindigkeit;
            _schreibgeschwindigkeit = schreibgeschwindigkeit;
        }
    }
}
