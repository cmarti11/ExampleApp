using ExampleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace ExampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientPage : ContentPage
    {
        private readonly ClientViewModel _viewModel;

        public ClientPage()
        {
            InitializeComponent();
            _viewModel = Startup.Resolve<ClientViewModel>();
            BindingContext = _viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ClientViewModel.Client) &&
                _viewModel.Client.Latitude != default &&
                _viewModel.Client.Longitude != default &&
                !string.IsNullOrEmpty(_viewModel.Client.Name))
            {
                var position = new Position(_viewModel.Client.Latitude, _viewModel.Client.Longitude);
                ClientLocationMap.MoveToRegion(new MapSpan(position, 0.01, 0.01));
                ClientLocationMap.Pins.Add(new Pin
                {
                    Label = _viewModel.Client.Name,
                    Position = position
                });
            }
        }
    }
}