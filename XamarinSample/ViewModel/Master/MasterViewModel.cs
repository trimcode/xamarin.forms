using System;
using Prism.Commands;
using Prism.Navigation;
using XamarinSample;
using XamarinSample.ViewModel.Base;

namespace XamarinSample.ViewModel.Master
{
    public class MasterViewModel : ViewModelBase
    {
        public DelegateCommand<MasterViewItem> ItemTappedCommand { get; set; }

        public MasterViewModel(INavigationService navigationService) : base(navigationService)
        {
            ItemTappedCommand = new DelegateCommand<MasterViewItem>((menu) =>
            {
                _navigationService.NavigateAsync("/MasterDetailView/NavigationPage/MainIconTabbedPage/" + menu.TargetType.Name);
            });
        }
    }
}
