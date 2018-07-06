using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using XamarinSample.Extend;
using XamarinSample.ViewModel;
using XamarinSample.ViewModel.Master;
using XamarinSample.ViewModel.Slide;
using XamarinSample.ViewModel.Tabbed;
using XamarinSample.Views;
using XamarinSample.Views.Master;
using XamarinSample.Views.Slide;
using XamarinSample.Views.Tabbed;

namespace XamarinSample
{
    public partial class App : PrismApplication
    {

        public App(IPlatformInitializer initializer = null) : base(initializer) { }


        protected override void OnInitialized()
        {
            InitializeComponent();
            
            NavigationService.NavigateAsync(new Uri("/CustomNavigationPage/LoginView", UriKind.Absolute));
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<CustomNavigationPage>();

            containerRegistry.RegisterForNavigation<MainIconTabbedPage, MainIconTabbedPageModel>();
            containerRegistry.RegisterForNavigation<MasterView, MasterViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailView, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<TabHomeView, TabHomeViewModel>();
            containerRegistry.RegisterForNavigation<TabVideoView, TabVideoViewModel>();
            containerRegistry.RegisterForNavigation<SetupView, SetupViewModel>();
            containerRegistry.RegisterForNavigation<AccountView, AccountViewModel>();
            containerRegistry.RegisterForNavigation<LoginView, LoginViewModel>();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
