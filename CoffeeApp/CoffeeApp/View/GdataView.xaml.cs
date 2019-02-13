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
    public partial class GdataView : ContentPage
    {
        public GdataView()
        {
            InitializeComponent();
            BindingContext = new GdataViewModel();
        }
    }
}