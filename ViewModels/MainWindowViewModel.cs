using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace AvaloniaGridBinding.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _name;
        private string _status;
        private string _expiresOn;

        public string Name 
        { 
            get => this._name;
            set => this.RaiseAndSetIfChanged(ref this._name, value);
        }

        public string Status 
        { 
            get => this._status;
            set => this.RaiseAndSetIfChanged(ref this._status, value);
        }

        public string ExpiresOn 
        { 
            get => this._expiresOn;
            set => this.RaiseAndSetIfChanged(ref this._expiresOn, value);
        }

        public MainWindowViewModel()
        {
            this.Name = "Paulo Aboim Pinto";
            this.Status = "ON";
            this.ExpiresOn = "N/A";
        }
    }
}
