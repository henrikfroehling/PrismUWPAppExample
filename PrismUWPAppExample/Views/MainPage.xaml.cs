namespace PrismUWPAppExample.Views
{
    using ViewModels;
    using Windows.UI.Xaml.Controls;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        public MainPageViewModel ViewModel => DataContext as MainPageViewModel;
    }
}
