using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model.HWKomponente
{
    class SSD : HWKomponent
    {
        public string Bezeichner { get => _bezeichner; set => _bezeichner = value; }
        public SSD(string bezeichner, float preis) : base(bezeichner, preis)
        {

        }
    }
}
