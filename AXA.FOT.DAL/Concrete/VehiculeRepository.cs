using AXA.FOT.DAL.Abstraction;
using AXA.FOT.DOMAIN.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXA.FOT.DAL.Concrete
{
    public class VehiculeRepository : IVehiculeRepository
    {
        IEnumerable<Vehicule> vehicules = new List<Vehicule>() {
            new Vehicule { Marque= "BRX", NumPlaque="ssss", Valeur_catalogue_incendie_plus_vol=12, Valeur_catalogue_omnium_complete=23 },
            new Vehicule { Marque= "derX", NumPlaque="rrrr", Valeur_catalogue_incendie_plus_vol=12, Valeur_catalogue_omnium_complete=23 }
        };
        public IEnumerable<Vehicule> GetAll()
        {
            return vehicules;
        }
    }
}
