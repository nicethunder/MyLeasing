using MyLeasing.Common.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasing.Prism.ViewModels
{
    public class PropertiesPageViewModel : ViewModelBase
    {
        private OwnerResponse _onwer;

        public PropertiesPageViewModel(
            INavigationService navigationService) : base(navigationService)
        {
            Title = "Properties";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("owner"))
            {
                _onwer = parameters.GetValue<OwnerResponse>("owner");
                Title = $"Properties of: {_onwer.FullName}";

            }
        }
    }
}
