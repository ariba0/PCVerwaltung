using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    class PC : Produkt
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }

        private List<HWKomponent> _komponente;

        public PC(string bezeichner, List<HWKomponent> komponente)
        {
            _bezeichner = bezeichner;
            _komponente = komponente;
        }
    }
}
