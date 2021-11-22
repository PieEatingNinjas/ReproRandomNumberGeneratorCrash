using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Security.Cryptography;

namespace ReproRandomNumberGeneratorCrash
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            try
            {
                var x = RandomNumberGenerator.GetInt32(10);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.GetType().Name);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
