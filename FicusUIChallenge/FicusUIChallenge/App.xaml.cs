using System;
using FicusUIChallenge.Helpers;
using FicusUIChallenge.ViewModels;
using FicusUIChallenge.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FicusUIChallenge
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(NavigationConstants.MainPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
