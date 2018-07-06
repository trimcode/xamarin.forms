using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace XamarinSample.ViewModel.Base
{
    public abstract class ViewModelBase : BindableBase, INavigationAware
    {
        protected readonly INavigationService _navigationService;

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }


        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
