using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank.ViewModels
{
    public class MainPageViewModel : ViewModelBase, IConfirmNavigationAsync
    {
        private readonly IPageDialogService pagedialoge;

        private INavigationService _navigationService { get; }
        public DelegateCommand NavigateSpeak { get; }
        public MainPageViewModel(INavigationService navigationService , IPageDialogService pagedialoge)
            : base(navigationService)
        {
            _navigationService = navigationService;
            this.pagedialoge = pagedialoge;
            NavigateSpeak = new DelegateCommand(NavigateSpeakMethod);
            Title = "Main Page";
        }

        private void NavigateSpeakMethod()
        {
            var p = new NavigationParameters();
            p.Add("title", "Hello world");
            _navigationService.NavigateAsync("SpeakPage",p);
        }

        public Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            return pagedialoge.DisplayAlertAsync("Hello", "Save", "YEs", "Cancel");
        }
    }
}
