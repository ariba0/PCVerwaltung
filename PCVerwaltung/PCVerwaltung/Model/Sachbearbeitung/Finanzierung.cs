using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.Sachbearbeitung
{
    class Finanzierung
    {
        private int _runtime;
        private double _monthlyRates;
        private double _fullCost;
        private int _kunde;

        public Finanzierung(int runtime, double monthlyRates, double fullCost, int kundenid)
        {
            _runtime = runtime;
            _monthlyRates = monthlyRates;
            _fullCost = fullCost;
            _kunde = kundenid;
        }
    }
}
