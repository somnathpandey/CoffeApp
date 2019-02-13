using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using CoffeeApp.View;
using System.Windows.Input;
using CoffeeApp.Model;



namespace CoffeeApp.ViewModel
{
    public class LoginpageViewModel: BaseClassViewModel
    {
       // public INavigation navigation { get; set; }
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
        private string password { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public ICommand loginbutton { get; set; }
        
        public LoginpageViewModel()
        {
            loginbutton = new Command(button);
            async void button()
            { 
                
            }  
        }
         
    }
}
