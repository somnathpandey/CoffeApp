using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginpageView : ContentPage
	{
		public LoginpageView ()
		{
           
            InitializeComponent ();
           
            
            BindingContext = new LoginpageViewModel();
		}
	}
}