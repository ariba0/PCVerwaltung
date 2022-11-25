using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    class CPU : HWKomponent
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        private float _taktFrequenz;
        private int _anzahlKerne;
        private int _kühlleistung;

        public float TaktFrequenz { get; set; }
        public CPU(string bezeichner, float preis, string hersteller, float taktfreq, int anzahlKerne, int kühlleistung) : base(bezeichner, preis, hersteller)
        {
            _taktFrequenz = taktfreq;
            _anzahlKerne = anzahlKerne;
            _kühlleistung = kühlleistung;
        }
    }
}
