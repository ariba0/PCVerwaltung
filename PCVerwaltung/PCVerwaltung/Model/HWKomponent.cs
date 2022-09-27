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
        protected float _preis;
        protected PC _pc;

        protected HWKomponent(string bezeichner, float preis)
        {
            _bezeichner = bezeichner;
            _preis = preis;
        }

        protected void AssignToPC(PC pc)
        {
            _pc = pc;
        }
    }
}
