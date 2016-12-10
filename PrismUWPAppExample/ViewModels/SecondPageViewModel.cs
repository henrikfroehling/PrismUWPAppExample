namespace PrismUWPAppExample.ViewModels
{
    using Prism.Commands;
    using Prism.Windows.Navigation;

    public sealed class SecondPageViewModel
    {
        private INavigationService _navigationService;

        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateBackCommand = new DelegateCommand(_navigationService.GoBack);
            DisplayText = "Hello SecondPage!";
        }

        public string DisplayText { get; }

        public DelegateCommand NavigateBackCommand { get; }

        public DelegateCommand NavigateCommand => new DelegateCommand(Navigate);

        private void Navigate()
        {
            _navigationService.Navigate(PageTokens.ThirdPage, null);
        }
    }
}
