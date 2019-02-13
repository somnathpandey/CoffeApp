using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoffeeApp.Model;
using CoffeeApp.Myapi;
using Xamarin.Forms;

namespace CoffeeApp.ViewModel
{
    public class GdataViewModel : BaseClassViewModel
    {
        private ObservableCollection<GModel> items;
        public ObservableCollection<GModel> Items
        {
            get { return items; }
            set
            {

                items = value;
            }
        }

        private ObservableCollection<Mydata> newitem;
        public ObservableCollection<Mydata> Newitems
        {
            get { return newitem; }
            set { newitem = value; }
        }

        public GdataViewModel()
        {

            Newitems = new ObservableCollection<Mydata>()
            {
                new Mydata ()
                {
                    name="suljit",
                    phone= "0624762928432",
                    email="abc@gmail.com",

                },
                new Mydata ()
                {
                    name="furjit",
                    phone="0746767489748",
                    email="abc@yahoo.com",

                },

            };
            Items = new ObservableCollection<GModel>() {
                 new GModel()
                {
                    CarID = 1,
                    Make = "Tesla Model S",
                    YearOfModel = 2015
                },
                  new GModel()
                {
                    CarID = 2,
                    Make = "Audi R8",
                    YearOfModel = 2012
                },

            };
            GApi.GetAllNewsAsync(list =>
            {
                foreach (GModel items in list)
                {
                    Items.Add(items);
                }
            });
        }


    }
}
