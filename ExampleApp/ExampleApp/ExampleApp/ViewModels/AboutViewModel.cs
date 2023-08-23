using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ExampleApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            MessagingCenter.Subscribe<LoginViewModel>(this, "Fail", (sender) =>
            {
                IncreaseFailureAttemptsCount();
            });
        }

        private int _failureAttemptsCount = 0;

        public int FailureAttemptsCount { get => _failureAttemptsCount; set => SetProperty(ref _failureAttemptsCount, value); }

        public ICommand OpenWebCommand { get; }

        private void IncreaseFailureAttemptsCount()
        {
            FailureAttemptsCount++;
        }

    }
}