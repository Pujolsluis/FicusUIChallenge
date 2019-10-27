using System;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class ActionsPageViewModel : BaseViewModel
    {


        public ActionsPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
        }
    }
}
