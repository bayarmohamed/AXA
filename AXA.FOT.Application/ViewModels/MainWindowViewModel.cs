using AXA.FOT.MODULE.Offer.Views;
using AXA.FOT.MODULE.Poseidon.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace AXA.FOT.Application.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            cmdExecuteOffer = new DelegateCommand(ExecuteCommand);
            cmdExecutePoseidant = new DelegateCommand(ExecutePoseidantCommand);
            this.regionManager = regionManager;
        }

        private void ExecutePoseidantCommand()
        {
            //regionManager.Regions["ContentRegion"].Add(new Poseidant());
            regionManager.RequestNavigate("ContentRegion", "Poseidant");
        }

        private void ExecuteCommand()
        {
            //regionManager.Regions["ContentRegion"].Add(new Offer());
            regionManager.RequestNavigate("ContentRegion", "Offer");
        }

        public DelegateCommand cmdExecuteOffer { get; set; }
        public DelegateCommand cmdExecutePoseidant { get; set; }
        private IRegionManager regionManager;
    }
}
