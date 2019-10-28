using System;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class ActionsPageViewModel : BaseViewModel
    {

        public DelegateCommand OnBackCommand { get; set; }

        public ActionsPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
            OnBackCommand = new DelegateCommand(async () =>
            {
                if (IsBusy) return;
                IsBusy = true;
                await NavigationService.GoBackAsync();
                IsBusy = false;
            });
        }
    }
}
