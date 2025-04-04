using System.Windows;
using CryptoApp.Models;
using CryptoApp.ViewModels;

namespace CryptoApp.Views
{
    public partial class CoinDetailsWindow : Window
    {
        public CoinDetailsWindow(Coin coin)
        {
            InitializeComponent();
            DataContext = new CoinDetailsViewModel(coin);
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
