using Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace superCheck
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            //InitializeComponent();
            var btnArmarLista = new Button
            {
                Text = "ARMAR LISTA"
            };

            btnArmarLista.Clicked += (sender, e) =>
            {
                this.Navigation.PushModalAsync(new ArmarListaPage());
                //http://www.heroesdelcodigo.com/xamarin-forms-navegacion/
            };
           
            var btnVerListas = new Button
            {
                Text = "VER MIS LISTAS"
            };


            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { btnArmarLista , btnVerListas }
            };
		}
	}
}
