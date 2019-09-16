﻿using MyLeasing.Common.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyLeasing.Prism.ViewModels
{
    public class ContractsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private PropertyResponse _property;
        private ObservableCollection<ContractItemViewModel> _contracts;

        public ContractsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Contracts";
        }

        public ObservableCollection<ContractItemViewModel> Contracts
        {
            get => _contracts;
            set => SetProperty(ref _contracts, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("property"))
            {
                _property = parameters.GetValue<PropertyResponse>("property");
                LoadContracts();
            }
        }

        private void LoadContracts()
        {
            Contracts = new ObservableCollection<ContractItemViewModel>(_property.Contracts.Select(c => new ContractItemViewModel(_navigationService)
            {
                EndDate = c.EndDate,
                Id = c.Id,
                IsActive = c.IsActive,
                Lessee = c.Lessee,
                Price = c.Price,
                Remarks = c.Remarks,
                StartDate = c.StartDate
            }).ToList());
        }
    }
}
