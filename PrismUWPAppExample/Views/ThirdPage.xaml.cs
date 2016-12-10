namespace PrismUWPAppExample.Views
{
    using ViewModels;
    using Windows.UI.Xaml.Controls;

    public sealed partial class ThirdPage : Page
    {
        public ThirdPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        public ThirdPageViewModel ViewModel => DataContext as ThirdPageViewModel;
    }
}
