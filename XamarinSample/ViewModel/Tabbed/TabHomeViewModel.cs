using System;
using Prism.Commands;
using Prism.Navigation;
using XamarinSample.ViewModel.Base;

namespace XamarinSample.ViewModel.Tabbed
{
    public class TabHomeViewModel : ViewModelBase
    {
        public DelegateCommand OnClickSlideMenuCommand { get; set; }


        public TabHomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            OnClickSlideMenuCommand = new DelegateCommand(OnClickSlideMenuAsync);
        }


        public async void OnClickSlideMenuAsync()
        {
            await _navigationService.NavigateAsync("SetupView");
        }
    }
}
 