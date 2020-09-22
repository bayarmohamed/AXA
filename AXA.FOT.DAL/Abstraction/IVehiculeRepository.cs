using AXA.FOT.DOMAIN.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXA.FOT.DAL.Abstraction
{
    public interface IVehiculeRepository
    {
        IEnumerable<Vehicule> GetAll();
    }
}
