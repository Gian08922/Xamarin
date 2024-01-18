using DagZaf.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DagZaf.Views.ViewRestaurante
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaRestaurante : ContentPage
    {
        public IList<Restaurante> Restaurantes { get; private set; }

        public ListaRestaurante()
        {
            InitializeComponent();
            Restaurantes = new List<Restaurante>();
            Restaurantes.Add(new Restaurante
            {
                Nombre = "Burger King",
                Numero = "Uno",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Burger_King_2020.svg/1024px-Burger_King_2020.svg.png"
            });
            Restaurantes.Add(new Restaurante
            {
                Nombre = "Mc Donald's",
                Numero = "Dos",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/McDonald%27s_Golden_Arches.svg/1024px-McDonald%27s_Golden_Arches.svg.png"
            });
            Restaurantes.Add(new Restaurante
            {
                Nombre = "Vips",
                Numero = "Tres",
                ImgUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.bolsamania.com%2Fbuscartrabajo%2Fwp-content%2Fuploads%2Flogo-vips.jpg&f=1&nofb=1"
            });
            Restaurantes.Add(new Restaurante
            {
                Nombre = "Fosters Hollywood",
                Numero = "Cuatro",
                ImgUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.franquiciasfranquishop.es%2Fsites%2Fdefault%2Ffiles%2F2018-01%2Flogo%2520foster.JPG&f=1&nofb=1"
            });

            BindingContext = this;
        }
        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Restaurante selectedItem = e.CurrentSelection[0] as Restaurante;
        }

    }
}