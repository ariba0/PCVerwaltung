using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    class Monitor : HWKomponent
    {
        private string _resolution;
        private int _größe;
        private int _frequenz;
        private int _reaktionszeit;
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        public Monitor(string bezeichner, float preis, string hersteller, string resolution, int größe, int frequenz, int reaktionszeit) : base(bezeichner, preis, hersteller)
        {
            _resolution = resolution;
            _größe = größe;
            _frequenz = frequenz;
            _reaktionszeit = reaktionszeit;
        }
    }
}
