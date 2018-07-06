using System;
using Prism.Navigation;
using XamarinSample.ViewModel.Base;

namespace XamarinSample.ViewModel.Master
{
    public class MasterDetailViewModel : ViewModelBase
    {
        public MasterDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
