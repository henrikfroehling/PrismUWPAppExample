namespace PrismUWPAppExample.ViewModels
{
    using Prism.Commands;
    using Prism.Windows.Navigation;

    public sealed class MainPageViewModel
    {
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            DisplayText = "Hello MainPage!";
        }

        public string DisplayText { get; }

        public DelegateCommand NavigateCommand => new DelegateCommand(Navigate);

        private void Navigate()
        {
            _navigationService.Navigate(PageTokens.SecondPage, null);
        }
    }
}
