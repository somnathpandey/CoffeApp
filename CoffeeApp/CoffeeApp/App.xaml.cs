using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoffeeApp.View;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CoffeeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


             //MainPage = new LoginpageView();
             MainPage = new NavigationPage(new LoginpageView());
            //ILocalNotifications localNotifications = DependencyService.Get<ILocalNotifications>();
            //Button showNotificationButton = new Button();
            //showNotificationButton.Text = "Show Local Notification";
            //showNotificationButton.Clicked += (sender, e) =>
            //localNotifications.Show("Test", "Local notification alert", 1);

            //MainPage = new ContentPage
            //{
            //  Content=new StackLayout
            //  {
            //      VerticalOptions = LayoutOptions.Center,
            //      Children =
            //      {
            //          showNotificationButton
            //      }
            //  }
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
