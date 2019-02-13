using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using CoffeeApp.View;

namespace CoffeeApp.ViewModel
{
    public class NewloginViewModel : BaseClassViewModel
    {
        private string _userId { get; set; }
        public string UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
        private string _passward { get; set; }
        public string Passward
        {
            get
            {
                return _passward;
            }
            set
            {
                _passward = value;
            }
        }
        public ICommand mybutton { get; set; }

        public NewloginViewModel()
        {
            mybutton = new Command(button);
            async void button()
            {
                if (UserId == "" && Passward == "")
                {
                    await App.Current.MainPage.DisplayAlert
                        ("login user", "enter ID and password", "Ok");
                }
                else if (UserId == "suljit" && Passward == "abc123")
                {
                    await App.Current.MainPage.Navigation.PushModalAsync(new CarView());
                }
                else if (UserId != "suljit" && Passward != "abc123")
                {
                    await App.Current.MainPage.DisplayAlert("user faild", "write corect ID", "OK");
                }
            }
        }
        
    }
}
