using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCam.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pestana1 : ContentPage
    {
        public Pestana1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pestana2());
        }
    }
}