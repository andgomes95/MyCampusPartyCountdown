using CampusPartyCountdown.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CampusPartyCountdown
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationPage(new MyCampusPartyCountdownView());
        }

        protected override void OnStart()
        {
            base.OnStart();

            AppCenter.Start("android=462b2596-b0ae-4ea3-a77d-8597683ea006;" +
                            "ios={Your iOS App secret here}",
                            typeof(Analytics), typeof(Crashes));
        }
    }
}
