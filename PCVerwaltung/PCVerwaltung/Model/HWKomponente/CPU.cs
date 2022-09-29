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
        public float TaktFrequenz { get; set; }
        public CPU(string bezeichner, float preis, string hersteller, float taktfreq) : base(bezeichner, preis, hersteller)
        {
            _taktFrequenz = taktfreq;
        }
    }
}
