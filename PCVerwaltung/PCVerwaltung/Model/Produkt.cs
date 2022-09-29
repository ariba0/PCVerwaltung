using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    abstract class Produkt
    {
        protected string _bezeichner;
        protected float _verkaufsPreis;
        protected float _einkaufsPreis;
        protected int _id;

        protected Produkt(string bezeichner, float verkaufsPreis, float einkaufsPreis, int id)
        {
            _bezeichner = bezeichner;
            _verkaufsPreis = verkaufsPreis;
            _einkaufsPreis = einkaufsPreis;
            _id = id;
        }
    }
}
