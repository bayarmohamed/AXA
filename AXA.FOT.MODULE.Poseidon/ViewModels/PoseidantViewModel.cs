using AXA.FOT.CORE;
using AXA.FOT.CORE.Dialogs;
using AXA.FOT.DOMAIN.Vehicules;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXA.FOT.MODULE.Poseidon.ViewModels
{
    public class PoseidantViewModel : BindableBase
    {
        public DelegateCommand CmdShowDialog { get; set; }
        private string _message;
        private IDialogService _dialogService;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        //IEventAggregator _ea;

        public PoseidantViewModel(IEventAggregator ea, IDialogService dialogService)
        {
            _dialogService = dialogService;
            ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
            Message = "Marque";
            CmdShowDialog = new DelegateCommand(SowDialogBox);
        }

        private void SowDialogBox()
        {
            var message = "This is a message that should be shown in the dialog.";
            //using the dialog service as-is
            _dialogService.ShowNotification(message, r =>
            {
                if (r.Result == ButtonResult.None)
                    Message = "Result is None";
                else if (r.Result == ButtonResult.OK)
                    Message = "Result is OK";
                else if (r.Result == ButtonResult.Cancel)
                    Message = "Result is Cancel";
                else
                    Message = "I Don't know what you did!?";
            });
        }

        private void MessageReceived(object obj)
        {
            Message = ((Vehicule)obj).Marque;
        }
    }
}
