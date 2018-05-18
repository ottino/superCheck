using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace superCheck
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ArmarListaPage : ContentPage
	{
		public ArmarListaPage ()
		{
            var lblPrueba = new Label
            {
                Text = "Cliqueaste en ARMAR LISTA"

            };

            Content = new StackLayout
            {

                Children = { lblPrueba }
            };
		}
	}
}