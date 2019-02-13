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
	public partial class Aboutpage : ContentPage
	{
		public Aboutpage ()
		{
            
			InitializeComponent ();
            BindingContext = new AboutPageViewModel();
		}
	}
}