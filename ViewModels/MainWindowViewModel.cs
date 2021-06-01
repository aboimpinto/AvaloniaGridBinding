using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaGridBinding.Models;
using ReactiveUI;

namespace AvaloniaGridBinding.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Product _product;

        public Product Product 
        { 
            get => this._product;
            set => this.RaiseAndSetIfChanged(ref this._product, value); 
        }

        public MainWindowViewModel()
        {
            this.Product = new Product
            {
                Name = "Paulo Aboim Pinto",
                Status = "ON",
                ExpiresOn = "N/A"
            };
        }
    }
}
