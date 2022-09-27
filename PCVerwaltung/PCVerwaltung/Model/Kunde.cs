using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    class Kunde
    {
        private string _name;
        public string Name { get; set; }
        private List<Rechnung> _rechnungen;
    }
}
