using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.Sachbearbeitung
{
    class Rechnung
    {
        private double _cost;
        private string _product;
        private int _kunde;

        public Rechnung(double cost, string product, int kundenid)
        {
            _cost = cost;
            _product = product;
            _kunde = kundenid;
        }

        
    }
}
