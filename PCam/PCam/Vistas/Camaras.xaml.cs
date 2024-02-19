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
	public partial class Camaras : ContentPage
	{
		public Camaras ()
		{
			InitializeComponent ();
		}

        public async void ImageButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new Perfil());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new Inicio());
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Camaras());
        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Historial());
        }

        private async void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Configuracion());
        }
    }
}