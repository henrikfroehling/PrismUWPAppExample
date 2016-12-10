namespace PrismUWPAppExample.Views
{
    using ViewModels;
    using Windows.UI.Xaml.Controls;

    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        public SecondPageViewModel ViewModel => DataContext as SecondPageViewModel;
    }
}
