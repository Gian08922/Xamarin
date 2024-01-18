using DagZaf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DagZaf.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DagZaf.Views.ViewBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoPage : ContentPage
    {
        public TodoPage()
        {
            InitializeComponent();
            BindingContext = new TodoViewModel();
        }
    }
}