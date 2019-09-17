using MyLeasing.Common.Helpers;
using MyLeasing.Common.Models;
using Newtonsoft.Json;
using Prism.Navigation;

namespace MyLeasing.Prism.ViewModels
{
    public class PropertyTabbedPageViewModel : ViewModelBase
    {
        public PropertyTabbedPageViewModel(
            INavigationService navigation) : base(navigation)
        {
            var property = JsonConvert.DeserializeObject<PropertyResponse>(Settings.Property);
            Title = $"Property: {property.Neighborhood}";
        }
    }
}
