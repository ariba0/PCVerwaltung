using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    public enum Architektur
    {
        normal,
        small,
        mini
    }
    class Mainboard : HWKomponent
    {
        private Architektur _architektur;
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        public Mainboard(string bezeichner, float preis, string hersteller, Architektur architektur) :base(bezeichner, preis, hersteller)
        {
            _architektur = architektur;
        }
    }
}
