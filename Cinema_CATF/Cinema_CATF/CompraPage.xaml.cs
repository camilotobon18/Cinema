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
	public partial class CompraPage : ContentPage
	{
        public CompraPage()
        {
        }

        public CompraPage (Funcion funcion)
		{
			InitializeComponent ();
            BindingContext = funcion;
		}
	}
}