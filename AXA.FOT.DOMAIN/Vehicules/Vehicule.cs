using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXA.FOT.DOMAIN.Vehicules
{
    public class Vehicule
    {
        public string NumPlaque { get; set; }
        public string Marque { get; set; }
        public double Valeur_catalogue_incendie_plus_vol { get; set; }
        public double Valeur_catalogue_omnium_complete { get; set; }
    }
}
