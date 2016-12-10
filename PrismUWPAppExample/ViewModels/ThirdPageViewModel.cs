namespace PrismUWPAppExample.ViewModels
{
    using Prism.Commands;
    using Prism.Windows.Navigation;

    public sealed class ThirdPageViewModel
    {
        private INavigationService _navigationService;

        public ThirdPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateBackCommand = new DelegateCommand(_navigationService.GoBack);
            DisplayText = "Hello ThirdPage!";
        }

        public string DisplayText { get; }

        public DelegateCommand NavigateBackCommand { get; }
    }
}
