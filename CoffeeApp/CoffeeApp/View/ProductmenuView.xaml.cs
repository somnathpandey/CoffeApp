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
	public partial class ProductmenuView :MasterDetailPage
	{
		public ProductmenuView ()
		{
            IsPresented = false;
			InitializeComponent ();
            BindingContext = new ProductmenuViewModel();
            
		}

        

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Price());
        //}

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            IsPresented = true;
        }

        //private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Price());
        //}

        //private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Price());
        //}
    }
}