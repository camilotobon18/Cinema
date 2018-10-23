using Cinema_CATF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_CATF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuncionPage : ContentPage
    {
        public FuncionPage(Pelicula pelicula)
        {
            InitializeComponent();
            
            BindingContext = pelicula;

        }

        private async void Funcion_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var funcion = e.SelectedItem as Funcion;
            //await Navigation.PushAsync(new CompraPage(funcion));
            int cantidad = Convert.ToInt32(entryCantidad.Text);
            var totalaPagar =  cantidad * funcion.Precio;
        }
    }   
}