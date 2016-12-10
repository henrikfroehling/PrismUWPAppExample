namespace PrismUWPAppExample
{
    using Prism.Unity.Windows;
    using System.Threading.Tasks;
    using Windows.ApplicationModel.Activation;

    public sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            await base.OnInitializeAsync(args);
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(PageTokens.MainPage, null);
            return Task.CompletedTask;
        }
    }
}
