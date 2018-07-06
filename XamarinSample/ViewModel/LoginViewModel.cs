using System;
using Prism.Commands;
using Prism.Navigation;
using XamarinSample.Model;
using XamarinSample.ViewModel.Base;

namespace XamarinSample.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {

        private LoginObj _loginObj;

        public DelegateCommand SignInCommand { get; private set; }


        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            _loginObj = new LoginObj();

            SignInCommand = new DelegateCommand(SignInAsync);
        }


        public LoginObj OBJ
        {
            get { return _loginObj; }
            set { SetProperty(ref _loginObj, value); }
        }


        public async void SignInAsync()
        {
            OBJ.Validate();

            if (OBJ.IsValid)
            {
                IsBusy = true;

                await System.Threading.Tasks.Task.Delay(2000); //休眠一秒

                await _navigationService.NavigateAsync(new Uri("/MasterDetailView/NavigationPage/MainIconTabbedPage", UriKind.Absolute));

                IsBusy = false;
            }
        }
    }
}
