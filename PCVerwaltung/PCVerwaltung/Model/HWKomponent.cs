using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    abstract class HWKomponent
    {
        protected string _bezeichner;
        protected string _hersteller;
        protected float _preis;
        protected PC _pc;

        protected HWKomponent(string bezeichner, float preis, string hersteller)
        {
            _bezeichner = bezeichner;
            _preis = preis;
            _hersteller = hersteller;
        }

        protected void AssignToPC(PC pc)
        {
            _pc = pc;
        }
    }
}
