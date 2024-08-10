using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica01.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practica01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home2());
        }
    }
}