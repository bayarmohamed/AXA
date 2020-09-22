using AXA.FOT.Application.Dialog;
using AXA.FOT.Application.Views;
using AXA.FOT.MODULE.Offer.Views;
using AXA.FOT.MODULE.Poseidon.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace AXA.FOT.Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Offer>();
            containerRegistry.RegisterForNavigation<Poseidant>();
            containerRegistry.RegisterDialog<NotificationDialog, NotificationDialogViewModel>();

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(typeof(AXA.FOT.MODULE.Offer.OfferModule));
            moduleCatalog.AddModule(typeof(AXA.FOT.MODULE.Poseidon.PoseidonModule));
        }
    }
}
