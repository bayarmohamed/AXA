using AXA.FOT.DAL.Abstraction;
using AXA.FOT.DAL.Concrete;
using AXA.FOT.MODULE.Offer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AXA.FOT.MODULE.Offer
{
    public class OfferModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
           
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IVehiculeRepository, VehiculeRepository>();
        }
    }
}