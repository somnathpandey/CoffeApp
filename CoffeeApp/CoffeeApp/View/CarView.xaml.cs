using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeApp.ViewModel;
using CoffeeApp.View;
using CoffeeApp.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarView : ContentPage
    {
        public CarView()
        {
             
            InitializeComponent();
            BindingContext = new ClassViewModel();
        }

        
    }
}