using Xamarin.Forms;

namespace ExampleApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Startup.Initialize();
            MainPage = new AppShell();
        }

    }
}
