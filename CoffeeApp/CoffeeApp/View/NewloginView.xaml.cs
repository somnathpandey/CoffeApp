using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoffeeApp.ViewModel;
namespace CoffeeApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewloginView : ContentPage
	{
		public NewloginView ()
		{
			InitializeComponent ();
            BindingContext = new NewloginViewModel();
		}
	}
}