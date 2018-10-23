using Cinema_CATF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_CATF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarteleraPage : ContentPage
	{
		public CarteleraPage ()
		{
			InitializeComponent ();
            CargarPeliculas();
		}
        private async Task CargarPeliculas()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            //al utilizar el Result, no se debe utilizar el await
            var request = await client.GetAsync("/api/Cartelera");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Pelicula>>(responseJson);

                listCartelera.ItemsSource = response;
            }

        }

       

        private async void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var pelicula = e.SelectedItem as Pelicula;
            await Navigation.PushAsync(new FuncionPage(pelicula));
        }
    }
}