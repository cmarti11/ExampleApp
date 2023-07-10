using ExampleApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExampleApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}