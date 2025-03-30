using System.Collections.ObjectModel;
using CryptoApp.Models;
using CryptoApp.Services;
using System.Threading.Tasks;

namespace CryptoApp.ViewModels
{
    public class CoinViewModel
    {
        private readonly CoinGeckoService _coinGeckoService;

        public ObservableCollection<Coin> Coins { get; set; }

        public CoinViewModel()
        {
            _coinGeckoService = new CoinGeckoService();
            Coins = new ObservableCollection<Coin>();
            LoadCoins();
        }

        private async void LoadCoins()
        {
            var coins = await _coinGeckoService.GetTopCoins(10);
            foreach (var coin in coins)
            {
                Coins.Add(coin);
            }
        }
    }
}
