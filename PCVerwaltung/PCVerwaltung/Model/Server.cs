using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    class Server : Produkt
    {
        public Server(string bezeichner, float verkaufsPreis, float einkaufsPreis, int id) : base(bezeichner, verkaufsPreis, einkaufsPreis, id)
        {
            _bezeichner = bezeichner;
            _verkaufsPreis = verkaufsPreis;
            _einkaufsPreis = einkaufsPreis;
            _id = id;
        }
    }
}
