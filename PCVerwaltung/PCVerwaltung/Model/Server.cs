using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    class Server : Produkt
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
    }
}
