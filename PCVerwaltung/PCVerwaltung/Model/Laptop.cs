using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    class Laptop : Produkt
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
    }
}
