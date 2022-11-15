using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.Sachbearbeitung
{
    class Kunde
    {
        private string _name;
        private int _id;
        private List<Rechnung> _rechnungen;
        private List<Finanzierung> _finanzierungen;

        public Kunde(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
