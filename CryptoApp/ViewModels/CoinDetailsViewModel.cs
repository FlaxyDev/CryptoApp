using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoApp.Models;

namespace CryptoApp.ViewModels
{
    public class CoinDetailsViewModel
    {
        public string Name { get; }
        public string Symbol { get; }
        public decimal PriceUsd { get; }
        public decimal MarketCapUsd { get; }
        public decimal Volume24hUsd { get; }
        public decimal PercentChange24h { get; }
        
        public string Image { get; }
        public CoinDetailsViewModel() { }
        public CoinDetailsViewModel(Coin coin)
        {
            Name = coin.Name;
            Symbol = coin.Symbol;
            PriceUsd = coin.PriceUsd;   
            MarketCapUsd = coin.MarketCapUsd;
            Volume24hUsd = coin.Volume24hUsd;
            PercentChange24h = coin.PercentChange24h;
            Image = coin.Image;
        }
    }
}
