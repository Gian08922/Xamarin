using DagZaf.Views.ViewRestaurante;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DagZaf.ViewModel;

namespace DagZaf.View.ViewAcceso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
        private void Registernav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
        private void Restaurantesnav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaRestaurante());
        }
    }
}