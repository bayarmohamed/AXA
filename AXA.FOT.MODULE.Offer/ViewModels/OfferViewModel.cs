using AXA.FOT.CORE;
using AXA.FOT.DAL.Abstraction;
using AXA.FOT.DOMAIN.Vehicules;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXA.FOT.MODULE.Offer.ViewModels
{
    public class OfferViewModel : BindableBase
    {
        private readonly IVehiculeRepository _ivehiculeRepository;
        readonly IEventAggregator _ea;


        public DelegateCommand<object> CmdSendMessage { get; set; }
        public ObservableCollection<Vehicule> Vehicules {
            get {
                return new ObservableCollection<Vehicule>(_ivehiculeRepository.GetAll()) ;
            }
            set {
            }
        }
      

        public OfferViewModel(IVehiculeRepository ivehiculeRepository, IEventAggregator ea)
        {
            _ivehiculeRepository = ivehiculeRepository;
            _ea = ea;
            CmdSendMessage = new DelegateCommand<object>(Execute);
           
        }

        private void Execute(object param)
        {
            if (param == null) return;
            var car = param as Vehicule;
            _ea.GetEvent<MessageSentEvent>().Publish(car);
        }
    }
}
