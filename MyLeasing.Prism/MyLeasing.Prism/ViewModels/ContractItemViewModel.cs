using MyLeasing.Common.Models;
using Prism.Commands;
using Prism.Navigation;

namespace MyLeasing.Prism.ViewModels
{
    public class ContractItemViewModel : ContractResponse
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectContractCommand;

        public ContractItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectContractCommand => _selectContractCommand ?? (_selectContractCommand = new DelegateCommand(SelectContractAsync));

        private async void SelectContractAsync()
        {
            var parameters = new NavigationParameters
            {
                { "contract", this }
            };

            await _navigationService.NavigateAsync("ContractPage", parameters);
        }
    }
}
