using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CoffeeApp.View;
using CoffeeApp.Model;
using System.Collections.ObjectModel;

namespace CoffeeApp.ViewModel
{
    public class ProductmenuViewModel : BaseClassViewModel

    {
       public ICommand Aboutimage { get; set; }
        public ProductmenuViewModel()
        {
            Aboutimage = new Command(aboutimage);
                async void aboutimage()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new Aboutpage());

            }
               Carcommand = new Command(carlists);
            async void carlists()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new CarView());

            }
            Gcommand = new Command(Glists);
            async void Glists()
            {

                await App.Current.MainPage.Navigation.PushModalAsync(new GdataView());
            }
            Bout = new Command(bout);
            async void bout()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new Aboutpage());
            }
            Mybout=new Command(mybout);
            async void mybout()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new Aboutpage());
            }
                
            
        }
        public ICommand Bout { get; set; }
        public ICommand Mybout { get; set; }
        public ICommand Carcommand { get; set; }
        public ICommand Gcommand { get; set; }
         
       
    }
}
