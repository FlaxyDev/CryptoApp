using System.Collections.ObjectModel;
using CryptoApp.Models;
using CryptoApp.Services;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CryptoApp.Helpers;
using CryptoApp.Views;

namespace CryptoApp.ViewModels
{
    public class CoinViewModel : INotifyPropertyChanged
    {
        private readonly CoinGeckoService _coinGeckoService;
        private string _searchQuery;
        private ObservableCollection<Coin> _filteredCoins;

        public ObservableCollection<Coin> Coins { get; set; } = new ObservableCollection<Coin>();

        public ObservableCollection<Coin> FilteredCoins
        {
            get => _filteredCoins;
            set
            {
                if (_filteredCoins != value)
                {
                    _filteredCoins = value;
                    OnPropertyChanged(nameof(FilteredCoins)); 
                }
            }
        }

        public ICommand OpenDetailsCommand { get; private set; }

        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                if (_searchQuery != value)
                {
                    _searchQuery = value;
                    OnPropertyChanged(); 
                }
            }
        }

        public CoinViewModel()
        {
            _coinGeckoService = new CoinGeckoService();
            OpenDetailsCommand = new RelayCommand<Coin>(OpenCoinDetails);
            LoadCoins();
        }

        private async Task LoadCoins()
        {
            var coins = await _coinGeckoService.GetTopCoins(10);
            Coins.Clear();
            foreach (var coin in coins)
            {
                Coins.Add(coin);
            }
            FilterCoins(); 
        }

        private void FilterCoins()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
            {
                FilteredCoins = new ObservableCollection<Coin>(Coins); 
            }
            else
            {
                var filteredList = Coins
                    .Where(c => c.Name.Contains(SearchQuery, StringComparison.InvariantCultureIgnoreCase) ||
                                c.Symbol.Contains(SearchQuery, StringComparison.InvariantCultureIgnoreCase))
                    .ToList();

                FilteredCoins = new ObservableCollection<Coin>(filteredList); 
            }
        }

        private void OpenCoinDetails(Coin coin)
        {
            if (coin != null)
            {
                var detailsWindow = new CoinDetailsWindow(coin);
                detailsWindow.ShowDialog();
            }
        }

        public void PerformSearch()
        {
            FilterCoins(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
