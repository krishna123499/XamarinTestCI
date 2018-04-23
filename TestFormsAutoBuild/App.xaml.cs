using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TestFormsAutoBuild
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TestFormsAutoBuildPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=52386719-0197-453b-a8dc-f192ee18eae2;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
            AppCenter.Start("android=52386719-0197-453b-a8dc-f192ee18eae2;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
