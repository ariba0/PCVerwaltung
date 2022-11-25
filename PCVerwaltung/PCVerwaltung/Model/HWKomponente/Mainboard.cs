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

    public enum Sockel
    {
        AMD,
        Intel
    }
    class Mainboard : HWKomponent
    {
        private Architektur _architektur;
        private Sockel _sockel;
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        private string _chipsatz;
        public Mainboard(string bezeichner, float preis, string hersteller, Architektur architektur, Sockel sockel, string chipsatz) :base(bezeichner, preis, hersteller)
        {
            _architektur = architektur;
            _sockel = sockel;
            _chipsatz = chipsatz;
        }
    }
}
